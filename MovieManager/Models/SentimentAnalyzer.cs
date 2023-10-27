using System.Net;
using System.Text.Json;
using System.Web;
using VaderSharp2;

namespace MovieManager.Models
{
    public class SentimentAnalyzer
    {
        public double PercentScore {  get; set; }
        public string PosNegNeu { get; set; }
        public List<string> Posts { get; set; }

        static public SentimentAnalyzer AnalyzeSentiment(string queryText)
        {
            var json = "";

            using (WebClient wc = new WebClient())
            {
                //fake like you are a "real" web browser
                wc.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                json = wc.DownloadString("https://www.reddit.com/search.json?limit=100&q=" + HttpUtility.UrlEncode(queryText));
            }
            var textToExamine = new List<string>();
            JsonDocument doc = JsonDocument.Parse(json);
            // Navigate to the "data" object
            JsonElement dataElement = doc.RootElement.GetProperty("data");
            // Navigate to the "children" array
            JsonElement childrenElement = dataElement.GetProperty("children");
            foreach (JsonElement child in childrenElement.EnumerateArray())
            {
                if (child.TryGetProperty("data", out JsonElement data))
                {
                    if (data.TryGetProperty("selftext", out JsonElement selftext))
                    {
                        string selftextValue = selftext.GetString();
                        if (!string.IsNullOrEmpty(selftextValue)) { textToExamine.Add(selftextValue); }
                        else if (data.TryGetProperty("title", out JsonElement title)) //use title if text is empty
                        {
                            string titleValue = title.GetString();
                            if (!string.IsNullOrEmpty(titleValue)) { textToExamine.Add(titleValue); }
                        }
                    }
                }
            }

            var analyzer = new SentimentIntensityAnalyzer();

            Double postsTotal = 0;
            int nonZeroCount = 0;

            foreach (string post in textToExamine)
            {
                var results = analyzer.PolarityScores(post);
                postsTotal += results.Compound;
                if (results.Compound != 0) nonZeroCount++;
            }

            var score = postsTotal / nonZeroCount;
            var percentScore = Math.Round(score * 100);
            var posNegNeu = "Neutral";
            if (score < 0) posNegNeu = "Negative";
            else if (score > 0) posNegNeu = "Positive";

            return new SentimentAnalyzer{ PercentScore = percentScore, PosNegNeu = posNegNeu, Posts = textToExamine };
        }
    }
}
