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
            tbIme.Text = student.Ime;
            tbPrezime.Text = student.Prezime;
            tbBrojObroka.Text = student.BrojObroka.ToString();
            tbBrojKartice.Text = student.BrojKartice.ToString();
        }

        private void btnSkeniraj_Click(object sender, EventArgs e)
        {
            DateTime trenutnoVrijeme = DateTime.Now;
            if (student.BrojObroka > 0)
            {
                student.BrojObroka--;
                MessageBox.Show($"Broj obroka smanjen. Preostalo: {student.BrojObroka}", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                student.VrijemeZadnjegObroka = trenutnoVrijeme;
                db.Studenti.Update(student);
                db.SaveChanges();
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
