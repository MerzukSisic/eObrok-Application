using apk.baza;
using apk.klase;
using Student.AO.forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student.AO
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
            lbBr.Text = "Broj studenata u bazi: " + db.Studenti.Count().ToString();
        }
    }
}
