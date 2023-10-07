using System.ComponentModel.DataAnnotations;

namespace MimaBookStore.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
