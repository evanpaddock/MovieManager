namespace MovieManager.Models
{
    public class ActorDetailsVM
    {
        public Actor Actor { get; set; }
        public List<Movie> Movies { get; set; }
        public SentimentAnalyzer SentimentAnalyzer { get; set; }
    }
}
