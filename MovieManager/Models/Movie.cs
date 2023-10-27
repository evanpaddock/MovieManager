namespace MovieManager.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Year_Of_Release { get; set; }
        public byte[] Media { get; set; }
        public string IMDB_Url { get; set; }

    }
}
