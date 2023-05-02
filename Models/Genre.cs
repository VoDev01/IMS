using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(25)]
        [MinLength(5)]
        public string Name { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}
