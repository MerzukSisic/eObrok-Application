using apk.baza;
using App.forms;
using System.Data;

namespace App
{
    public partial class frmPocetna : Form
    {
        Baza db = new Baza();

        public frmPocetna()
        {
            InitializeComponent();
        }
        private void btnPretraga_Click(object sender, EventArgs e)
        {
            var forma = new frmStudenti();
            forma.ShowDialog();
        }
        private void btnSkenirajObrok_Click(object sender, EventArgs e)
        {
            var forma = new frmUnesiBrojKartice();
            forma.ShowDialog();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            ResetujAkoJePotrebno();
            lbBr.Text = "Broj studenata u bazi: " + db.Studenti.Count().ToString();
        }
        private void ResetujAkoJePotrebno()
        {
            DateTime danasnjiDatum = DateTime.Now.Date;

            // Provjeri da li je resetovanje već obavljeno za trenutni datum
            var studentiZaReset = db.Studenti.Where(s => s.DatumResetovanja != danasnjiDatum).ToList();

            if (studentiZaReset.Any())
            {
                foreach (var student in studentiZaReset)
                {
                    student.JeoRucak = false;
                    student.JeoVeceru = false;
                    student.DupliRucak = false;
                    student.DuplaVecera = false;
                    student.DatumResetovanja = danasnjiDatum;
                }

                db.SaveChanges();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
