using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models
{
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(25)]
        [MinLength(5)]
        public string Name { get; set; }
        public IEnumerable<MoviePage> MoviesPages { get; set; }
        public IEnumerable<MoviePageItem> MoviePageItems { get; set; }
    }
}
