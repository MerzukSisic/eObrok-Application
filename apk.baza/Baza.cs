using Microsoft.EntityFrameworkCore;
using System.Configuration;
using apk.klase;

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

    }
}