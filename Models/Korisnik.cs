using System.ComponentModel.DataAnnotations;

namespace Adresar_v1.Models
{
    public class Korisnik
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public List <Kontakt> Kontakt { get; set; }
    }
}
