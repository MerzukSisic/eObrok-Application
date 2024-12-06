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
            tbBrojObroka.Text = student.BrojObroka.ToString();
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

            if (student.BrojObroka > 0)
            {
                TimeSpan vrijemeRazlike = trenutnoVrijeme - student.VrijemeZadnjegObroka;

                if (vrijemeRazlike.TotalHours <= 2)
                {
                    if (student.JeoRucak)
                    {
                        student.DupliRucak = true;
                        cbDupliRucak.Checked = true;
                    }
                    else if (student.JeoVeceru)
                    {
                        student.DuplaVecera = true;
                        cbDuplaVecera.Checked = true;
                    }
                }

                if (trenutnoVrijeme.Hour >= 12 && trenutnoVrijeme.Hour < 17)
                {
                    if (!student.JeoRucak)
                    {
                        student.JeoRucak = true;
                        student.VrijemeZadnjegObroka = trenutnoVrijeme;
                        MessageBox.Show("Student je pojeo ručak.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student je već pojeo ručak.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (trenutnoVrijeme.Hour >= 17 && trenutnoVrijeme.Hour < 21)
                {
                    if (!student.JeoVeceru)
                    {
                        student.JeoVeceru = true;
                        student.VrijemeZadnjegObroka = trenutnoVrijeme;
                        MessageBox.Show("Student je pojeo večeru.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student je već pojeo večeru.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                student.BrojObroka--;
                db.Studenti.Update(student);
                db.SaveChanges();
                MessageBox.Show($"Broj obroka smanjen. Preostalo: {student.BrojObroka}", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
