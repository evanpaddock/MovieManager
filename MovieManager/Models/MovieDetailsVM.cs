namespace MovieManager.Models
{
    public class MovieDetailsVM
    {
        public Movie Movie { get; set; }
        public List<Actor> Actors { get; set; }
        public SentimentAnalyzer SentimentAnalyzer { get; set; }
    }
}
