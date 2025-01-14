using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adresar_v1.Models
{
    public class Kontakt
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public string Ime { get; set; }
        [Required]
        
        public string Prezime {  get; set; }

        [Required]
        
        public string Email { get; set; }

        public string? Adresa { get; set; }
        [Required]
        [MaxLength(20)]
        public string BrojTelefona { get; set; }
        
        public Korisnik Korisnik { get; set; }
        [Required]
        [ForeignKey(nameof(Korisnik))]
        public int KorisnikId { get; set; }
    }
}
