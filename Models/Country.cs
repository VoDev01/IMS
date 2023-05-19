using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(75)]
        public string Name { get; set; }
        public IEnumerable<MoviePage> MoviesPages { get; set; }
        public IEnumerable<MoviePageItem> MoviePageItems { get; set; }
    }
}
