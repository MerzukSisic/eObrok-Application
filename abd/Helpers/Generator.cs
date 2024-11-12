namespace Student.AO.Helpers
{
    public class Generator
    {
        public static string GetLozinka(int brojZnakova = 15)
        {
            string znakovi = "1234567890'+qwertzuiopšđžasdfghjklčćyxcvbnm,.-QtERTZUIOPŠĐŽASDFGHJKLČĆYXCVBNM;:_!#$%&/()=?*";
            string lozinka = "";//tWK!
            Random rand = new Random();
            for (int i = 0; i < brojZnakova; i++)
                lozinka += znakovi[rand.Next(0, znakovi.Length)];
            return lozinka;
        }
      
    
    }
}
