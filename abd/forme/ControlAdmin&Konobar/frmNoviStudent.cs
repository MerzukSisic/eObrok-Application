using apk.baza;
using apk.klase;
using App.Helpers;

namespace App.forme.ControlAdmin_Konobar
{
    public partial class frmNoviStudent : Form
    {
        Baza db = new Baza();
        private Studenti studenti;

        public frmNoviStudent(Studenti studenti)
        {
            this.studenti = studenti;
            InitializeComponent();
        }

        private bool ValidniPodaci()
        {
            return Helpers.Validator.ProvjeriUnos(tbIme, err, "Obavezna vrijednosti") &&
                Helpers.Validator.ProvjeriUnos(tbPrezime, err, "Obavezna vrijednosti") &&
                Helpers.Validator.ProvjeriUnos(pbSlika, err, "Obavezna vrijednosti");
        }

        private void frmNoviStudent_Load(object sender, EventArgs e)
        {
            if (studenti != null)
            {
                // Ako uređujemo postojećeg studenta, prikaži dugmad "Izbriši" i "Obnovi Obroke"
                btnIzbrisi.Visible = true;
                btnObnoviObroke.Visible = true;

                // Popuni polja s podacima postojećeg studenta
                tbBrojKartice.Text = studenti.BrojKartice.ToString();
                tbIme.Text = studenti.Ime;
                tbPrezime.Text = studenti.Prezime;
                pbSlika.Image = Ekstenzije.ToImage(studenti.Slika);
                dtpUplaceno.Value = studenti.Datum;
            }
            else
            {
                // Ako dodajemo novog studenta, sakrij dugmad "Izbriši" i "Obnovi Obroke"
                btnIzbrisi.Visible = false;
                btnObnoviObroke.Visible = false;
            }
        }
        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite izbrisati studenta", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                db.Studenti.Remove(studenti);
                db.SaveChanges();
                Close();
            }
            else
            {
                Close();
            }

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (ValidniPodaci())
            {
                if (studenti == null)
                {
                    int brojKartice = db.Studenti.Any() ? db.Studenti.Max(s => s.BrojKartice) + 1 : 1;
                    var noviStudent = new Studenti
                    {
                        Ime = tbIme.Text,
                        Prezime = tbPrezime.Text,
                        BrojObrokaRucak = 22,
                        BrojObrokaVecera = 22,
                        BrojKartice = (db.Studenti.Any() ? db.Studenti.Max(s => s.BrojKartice) + 1 : 001),
                        Datum = DateTime.Now,
                        Slika = Ekstenzije.ToByteArray(pbSlika.Image),
                    };
                    db.Studenti.Add(noviStudent);
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    studenti.Ime = tbIme.Text;
                    studenti.Prezime = tbPrezime.Text;
                    studenti.Datum = dtpUplaceno.Value;
                    studenti.Slika = Ekstenzije.ToByteArray(pbSlika.Image);
                    db.Studenti.Update(studenti);
                    db.SaveChanges();
                    Close();
                }
            }
        }

        private void btnObnoviObroke_Click(object sender, EventArgs e)
        {
            studenti.BrojObrokaRucak = 22;
            studenti.BrojObrokaVecera = 22;
            studenti.Datum = DateTime.Now;
            db.Studenti.Update(studenti);
            db.SaveChanges();
            Close();
        }

        private void btnIzbrisi_Click_1(object sender, EventArgs e)
        {
            // Prikaz potvrdnog dijaloga
            DialogResult result = MessageBox.Show(
                "Da li ste sigurni da želite izbrisati studenta?", // Poruka
                "Potvrda brisanja",                                // Naslov
                MessageBoxButtons.YesNo,                          // Tip dugmadi (Yes/No)
                MessageBoxIcon.Question                           // Ikona (upitnik)
            );

            // Provjera odgovora korisnika
            if (result == DialogResult.Yes)
            {
                // Ako korisnik odabere "Yes", izbriši studenta
                db.Studenti.Remove(studenti);
                db.SaveChanges();
                Close(); // Zatvori formu nakon brisanja
            }
            // Ako korisnik odabere "No", ne radi ništa
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbSlika_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}