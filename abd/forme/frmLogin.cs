using apk.baza;
using apk.klase;
using Student.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using Student.AO.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student.AO.forme
{
    public partial class frmLogin : Form
    {
        private Studenti student;
        Baza db = new Baza();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (ValidniPodaci())
            {
                string korisnickoIme = tbiME.Text;
                string lozinka = tbPrezime.Text;

                var korisnik = db.Korisnici.FirstOrDefault(k => k.Ime == korisnickoIme && k.Lozinka == lozinka);

                if (korisnik != null)
                {
                    if (korisnik.RoleId == 1)  
                    {
                        this.Hide();
                        MessageBox.Show("Dobrodošli " + korisnik.Ime);
                        var novaForma = new frmForAdmin();  
                        novaForma.ShowDialog();
                        this.Show();
                    }
                    else if (korisnik.RoleId == 2)  
                    {
                        this.Hide();
                        MessageBox.Show("Dobrodošli " + korisnik.Ime);
                        var novaForma = new frmPocetna();     
                            novaForma.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    var student = db.Studenti.FirstOrDefault(s => s.Ime == korisnickoIme && s.BrojKartice.ToString() == lozinka);

                    if (student != null)
                    {
                        this.Hide();
                        MessageBox.Show("Dobrodošli " + student.Ime);
                        var novaForma = new frmForStudents(student);
                        novaForma.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Neispravno korisničko ime ili lozinka.");
                    }
                }
            }
        }

        private bool ValidniPodaci()
        {
            return Helpers.Validator.ProvjeriUnos(tbiME, err, "Obavezna vrijednost") &&
                Helpers.Validator.ProvjeriUnos(sda, err, "Obavezna vrijednost");
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
