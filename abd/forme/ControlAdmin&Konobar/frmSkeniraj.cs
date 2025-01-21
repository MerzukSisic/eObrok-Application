using apk.baza;
using apk.klase;
using App.Helpers;

namespace App.forms
{
    public partial class frmSkeniraj : Form
    {
        private Studenti student;
        Baza db = new Baza();

        public frmSkeniraj(Studenti student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmSkeniraj_Load(object sender, EventArgs e)
        {
            // Proveri da li je potreban reset podataka
            ProveriDatumReseta();

            // Učitaj podatke za prikaz
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            pbSlika.Image = Ekstenzije.ToImage(student.Slika);
            tbIme.Text = student.Ime;
            tbPrezime.Text = student.Prezime;
            tbBrojObrokaRucak.Text = student.BrojObrokaRucak.ToString();
            tbBrojObrokaVecera.Text = student.BrojObrokaVecera.ToString();
            tbBrojKartice.Text = student.BrojKartice.ToString();
            cbRucak.Checked = student.JeoRucak;
            cbVecera.Checked = student.JeoVeceru;
            cbDupliRucak.Checked = student.DupliRucak ?? false;
            cbDuplaVecera.Checked = student.DuplaVecera ?? false;
        }

        private void ProveriDatumReseta()
        {
            if (student.DatumResetovanja == null || student.DatumResetovanja.Value.Date < DateTime.Now.Date)
            {
                student.JeoRucak = false;
                student.JeoVeceru = false;
                student.DupliRucak = false;
                student.DuplaVecera = false;

                student.DatumResetovanja = DateTime.Now; 

                db.Studenti.Update(student); 
                db.SaveChanges();
            }
        }

        private void btnSkeniraj_Click(object sender, EventArgs e)
        {
            DateTime trenutnoVrijeme = DateTime.Now;
            int ukupnoObroka = student.BrojObrokaVecera + student.BrojObrokaRucak;

            if (ukupnoObroka > 0)
            {
                TimeSpan vrijemeRazlike = trenutnoVrijeme - student.VrijemeZadnjegObroka;

                if (vrijemeRazlike.TotalHours <= 2)
                {
                    if (student.JeoRucak && student.BrojObrokaRucak > 0)
                    {
                        student.DupliRucak = true;
                        cbDupliRucak.Checked = true;
                        student.BrojObrokaRucak--;
                        MessageBox.Show("Student je iskoristio dupli ručak.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (student.JeoVeceru && student.BrojObrokaVecera > 0)
                    {
                        student.DuplaVecera = true;
                        cbDuplaVecera.Checked = true;
                        student.BrojObrokaVecera--;
                        MessageBox.Show("Student je iskoristio duplu večeru.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (trenutnoVrijeme.Hour >= 12 && trenutnoVrijeme.Hour < 17)
                {
                    if (!student.JeoRucak && student.BrojObrokaRucak > 0)
                    {
                        student.JeoRucak = true;
                        student.VrijemeZadnjegObroka = trenutnoVrijeme;
                        student.BrojObrokaRucak--;
                        MessageBox.Show("Student je pojeo ručak.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student je već pojeo ručak ili nema obroka za ručak.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (trenutnoVrijeme.Hour >= 17 && trenutnoVrijeme.Hour < 21)
                {
                    if (!student.JeoVeceru && student.BrojObrokaVecera > 0)
                    {
                        student.JeoVeceru = true;
                        student.VrijemeZadnjegObroka = trenutnoVrijeme;
                        student.BrojObrokaVecera--;
                        MessageBox.Show("Student je pojeo večeru.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student je već pojeo večeru ili nema obroka za večeru.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DialogResult rezultat = MessageBox.Show("Izvan je predviđenog vremena za obrok. Želite li ipak iskoristiti obrok?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (rezultat == DialogResult.Yes)
                    {
                        student.VrijemeZadnjegObroka = trenutnoVrijeme;
                        MessageBox.Show("Obrok je uspješno iskorišten izvan predviđenog vremena.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Obrok nije iskorišten.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                db.Studenti.Update(student);
                db.SaveChanges();

                MessageBox.Show($"Broj obroka smanjen. Preostalo ručkova: {student.BrojObrokaRucak}, večera: {student.BrojObrokaVecera}", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Student nema više obroka na raspolaganju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
