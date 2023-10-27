namespace MovieManager.Models
{
    public class ActorDetails
    {
        public Actor Actor { get; set; }
        public List<Movie> Movies { get; set; }
        public SentimentAnalyzer SentimentAnalyzer { get; set; }
    }
}
