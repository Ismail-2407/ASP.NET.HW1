using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; } 
    }
}