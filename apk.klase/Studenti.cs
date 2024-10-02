namespace apk.klase
{
    public class Studenti
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int BrojObroka { get; set; }
        public int BrojKartice { get; set; }
        public DateTime Datum { get; set; }
        public byte[] Slika { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
