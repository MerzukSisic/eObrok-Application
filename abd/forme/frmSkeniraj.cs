using apk.baza;
using apk.klase;
using Student.AO.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student.AO.forme
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
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            pbSlika.Image = Ekstenzije.ToImage(student.Slika);
            lblIme.Text = student.Ime;
            lblPrezime.Text = student.Prezime;
            lblBrojObroka.Text = student.BrojObroka.ToString();
            lblBrojKartice.Text = student.BrojKartice.ToString();
        }

        private void btnUzmiObrok_Click(object sender, EventArgs e)
        {
            if (student.BrojObroka > 0)
            {
                student.BrojObroka--; 
                MessageBox.Show($"Broj obroka smanjen. Preostalo: {student.BrojObroka}", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.Studenti.Update(student);
                db.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Student nema više obroka na raspolaganju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
