﻿namespace Student.Klase
{
    public class Uposlenici
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Lozinka { get; set; }
        public DateTime DatumZaposljenja { get; set; }
        public byte[] Slika { get; set; }
        public Roles Role { get; set; }
        public int RoleId { get; set; }
    }
}
