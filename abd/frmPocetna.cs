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
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var forma = new frmStudenti();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var forma = new frmUnesiBrojKartice();
            forma.ShowDialog();
        }
    }
}
