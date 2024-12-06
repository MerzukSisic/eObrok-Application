using Microsoft.EntityFrameworkCore;
using System.Configuration;
using apk.klase;
using Student.Klase;

namespace apk.baza
{
    public class Baza : DbContext
    {
        private readonly string dbPutanja;

        public Baza()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["Baza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }

        public DbSet<Studenti> Studenti { get; set; }
        public DbSet<Uposlenici> Korisnici { get;set; }
        public DbSet<Roles> Roles { get;set; }
    }
}