using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(75)]
        public string Name { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}
