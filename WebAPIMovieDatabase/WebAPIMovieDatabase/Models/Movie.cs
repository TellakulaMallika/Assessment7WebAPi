using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIMovieDatabase.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        
        
        public string StatCast { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
