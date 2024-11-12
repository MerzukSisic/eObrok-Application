using apk.baza;
using apk.klase; // Provjerite da li ovdje postoji tačna klasa "Studenti"
using Student.AO.Helpers;
using System.Xml.Linq;

namespace Student.AO.forme
{
    public partial class frmNoviStudent : Form
    {
        Baza db = new Baza();
        private apk.klase.Studenti studenti; // Specifikujte puni naziv klase

        public frmNoviStudent(apk.klase.Studenti studenti) // Specifikujte puni naziv klase
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
                tbIme.Text = studenti.Ime;
                tbPrezime.Text = studenti.Prezime;
                pbSlika.Image = Ekstenzije.ToImage(studenti.Slika);
                dtpUplaceno.Value = studenti.Datum;
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

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidniPodaci())
            {
                if (studenti == null)
                {
                    var noviStudent = new apk.klase.Studenti // Specifikujte puni naziv klase
                    {
                        Ime = tbIme.Text,
                        Prezime = tbPrezime.Text,
                        BrojObroka = 44,
                        BrojKartice = (db.Studenti.Any() ? db.Studenti.Max(s => s.BrojKartice) + 1 : 001),
                        Datum = DateTime.Now,
                        VrijemeZadnjegObroka = DateTime.Now,
                        Slika = Ekstenzije.ToByteArray(pbSlika.Image)
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
            studenti.Ime = tbIme.Text;
            studenti.Prezime = tbPrezime.Text;
            studenti.Datum = DateTime.Now;
            studenti.Slika = Ekstenzije.ToByteArray(pbSlika.Image);
            studenti.BrojObroka = 44;
            db.Studenti.Update(studenti);
            db.SaveChanges();
            Close();
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
    }
}
