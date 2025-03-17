using apk.baza;
using App.Helpers;
using Student.Klase;

namespace App.forms
{
    public partial class frmNoviKonobar : Form
    {
        Baza db = new Baza();
        private Uposlenici uposlenici;
        public frmNoviKonobar(Uposlenici uposlenici)
        {
            InitializeComponent();
            this.uposlenici = uposlenici;
        }

        private void frmNoviKonobar_Load(object sender, EventArgs e)
        {
            if (uposlenici != null)
            {
                btnIzbrisi.Visible = true;
                tbIme.Text = uposlenici.Ime.ToString();
                tbLozinka.Text = uposlenici.Lozinka.ToString();
                dtpDatum.Value = uposlenici.DatumZaposljenja;
                pbSlika.Image = Ekstenzije.ToImage(uposlenici.Slika);
            }
            else
            {
                btnIzbrisi.Visible = false;

            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (ValidniPodaci())
            {
                if (uposlenici == null)
                {
                    var noviKorisnik = new Uposlenici
                    {
                        Ime = tbIme.Text,
                        Lozinka = tbLozinka.Text,
                        DatumZaposljenja = dtpDatum.Value,
                        Slika = Ekstenzije.ToByteArray(pbSlika.Image),
                        RoleId = 2
                    };
                    db.Korisnici.Add(noviKorisnik);
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    uposlenici.Ime = tbIme.Text;
                    uposlenici.Lozinka = tbLozinka.Text;
                    uposlenici.DatumZaposljenja = dtpDatum.Value;
                    uposlenici.Slika = Ekstenzije.ToByteArray(pbSlika.Image);
                    db.Korisnici.Update(uposlenici);
                    db.SaveChanges();
                    Close();
                }
            }
        }
        private bool ValidniPodaci()
        {
            return Helpers.Validator.ProvjeriUnos(tbIme, err, "Obavezna vrijednosti") &&
                         Helpers.Validator.ProvjeriUnos(tbLozinka, err, "Obavezna vrijednosti") &&
                         Helpers.Validator.ProvjeriUnos(pbSlika, err, "Obavezna vrijednosti");
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            db.Korisnici.Remove(uposlenici);
            db.SaveChanges();
            Close();
        }
    }
}
