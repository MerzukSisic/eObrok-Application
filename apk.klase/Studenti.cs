namespace apk.klase
{
    public class Studenti
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int BrojObrokaRucak { get; set; }
        public int BrojObrokaVecera { get; set; }
        public int BrojKartice { get; set; }
        public DateTime Datum { get; set; }
        public DateTime VrijemeZadnjegObroka { get; set; }
        public bool JeoRucak { get; set; }
        public bool JeoVeceru { get; set; }
        public int Counter { get; set; }
        public DateTime? DatumResetovanja { get; set; }
        public byte[] Slika { get; set; }
        public bool? DupliRucak { get; set; }
        public bool? DuplaVecera { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
