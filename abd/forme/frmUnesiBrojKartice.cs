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
        private void frmUnesiBrojKartice_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbBrojKartice.Text, out int brojKartice))
            {
                var student = baza.Studenti.FirstOrDefault(s => s.BrojKartice == brojKartice);

                if (student != null)
                {
                    DateTime trenutnoVrijeme = DateTime.Now;

                    // Provjera da li student ima prethodno vrijeme obroka i da li je prošlo manje od jednog sata
                    if (student.VrijemeZadnjegObroka != DateTime.MinValue && (trenutnoVrijeme - student.VrijemeZadnjegObroka).TotalHours < 2)
                    {
                        DialogResult result = MessageBox.Show(
                            "Ne možete koristiti više od jednog obroka za ručak/večeru. Da li ste sigurni da želite iskoristiti još jedan obrok?",
                            "Ograničenje obroka",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                    student.VrijemeZadnjegObroka = trenutnoVrijeme;
                    baza.SaveChanges();

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
