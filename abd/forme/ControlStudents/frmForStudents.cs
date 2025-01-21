using apk.klase;
using App.Helpers;
using Student.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.forms
{
    public partial class frmForStudents : Form
    {
        private Studenti student;

        public frmForStudents(Studenti student)
        {
            InitializeComponent();
            this.student = student;
        }
        private void frmForStudents_Load(object sender, EventArgs e)
        {
            tbBrojKartice.Text = student.BrojKartice.ToString();
            tbIme.Text = student.Ime;
            tbPrezime.Text = student.Prezime;
            pbSlika.Image = Ekstenzije.ToImage(student.Slika);
            dtpUplaceno.Value = student.Datum;
            tbBrojObrokaRucak.Text = student.BrojObrokaRucak.ToString();
            tbBrojObrokaVecera.Text = student.BrojObrokaVecera.ToString();

            CheckStatus();

        }
        private void CheckStatus()
        {
            int brojObroka = student.BrojObrokaRucak + student.BrojObrokaVecera; // Broj obroka iz objekta student
            DateTime datumUplate = student.Datum; // Datum uplate iz objekta student
            DateTime danasnjiDatum = DateTime.Now;

            // Izračunaj broj dana do isteka
            int preostaloDana = (datumUplate.AddDays(30) - danasnjiDatum).Days;

            // Provjera stanja obroka
            if (brojObroka > 20 && preostaloDana > 10)
            {
                lblStatus.Text = "Sve je u redu. Stanje je zadovoljavajuće.";
                lblStatus.ForeColor = Color.Green;
            }
            else if (brojObroka <= 20 && preostaloDana <= 10 && preostaloDana > 0)
            {
                lblStatus.Text = "Upozorenje: Pri kraju ste s obrocima.";
                lblStatus.ForeColor = Color.Orange;
            }
            else if (preostaloDana <= 10 || brojObroka <= 10)
            {
                lblStatus.Text = "Vrijeme je za obnovu uplate!";
                lblStatus.ForeColor = Color.Red;
            }

            // Prikazivanje statusa na formi
            lblStatus.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
