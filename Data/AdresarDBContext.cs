using Adresar_v1.Models;
using Microsoft.EntityFrameworkCore;

namespace Adresar_v1.Data
{
    public class AdresarDBContext:DbContext

    {
        public AdresarDBContext(DbContextOptions<AdresarDBContext> options) : base(options) { }

        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Kontakt> Kontakti { get; set; }
    }
}
