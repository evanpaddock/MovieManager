using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MovieManager.Models
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string IMDB_Url { get; set; }

        [DataType(DataType.Upload)]
        [DisplayName("Actor Image")]
        public byte[]? Photo { get; set; }
    }
}
