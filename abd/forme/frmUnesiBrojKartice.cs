using apk.baza;
using apk.klase;

namespace Student.AO.forme
{
    public partial class frmUnesiBrojKartice : Form
    {
        Baza baza = new Baza();
        private Studenti student;

        public frmUnesiBrojKartice()
        {
            this.student = student;
            InitializeComponent();
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbBrojKartice.Text, out int brojKartice))
            {
                var student = baza.Studenti.FirstOrDefault(s => s.BrojKartice == brojKartice);

                if (student != null)
                {
                    MessageBox.Show($"Student pronađen: {student.Ime} {student.Prezime}", "Pronađen Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var nova = new frmSkeniraj(student);
                    nova.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Student sa unesenim brojem kartice nije pronađen.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Molimo unesite važeći broj kartice.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmUnesiBrojKartice_Load(object sender, EventArgs e)
        {

        }
    }
}
