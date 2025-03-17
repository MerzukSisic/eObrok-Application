using App.forms.ControlAdmin;

namespace App.forms
{
    public partial class frmForAdmin : Form
    {
        public frmForAdmin()
        {
            InitializeComponent();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            this.Hide();
            var novaForma = new frmStudenti();
            novaForma.ShowDialog();
            this.Show();
        }

        private void btnKonobari_Click(object sender, EventArgs e)
        {
            this.Hide();
            var novaForma = new frmPretragaKonobara();
            novaForma.ShowDialog();
            this.Show();
        }

        private void btnSkenirajObrok_Click(object sender, EventArgs e)
        {
            this.Hide();
            var novaForma = new frmUnesiBrojKartice();
            novaForma.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
