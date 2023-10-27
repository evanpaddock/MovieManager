using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MovieManager.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        [DisplayName("Release Year")]
        public string Year_Of_Release { get; set; }

        [DisplayName("IMDB Link")]
        public string IMDB_Url { get; set; }

        [DataType(DataType.Upload)]
        [DisplayName("Movie Media")]
        public byte[]? Media { get; set; }
    

    }
}
