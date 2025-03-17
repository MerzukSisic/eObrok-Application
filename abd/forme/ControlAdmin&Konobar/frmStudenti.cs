using apk.baza;
using apk.klase;
using App.forme.ControlAdmin_Konobar;
using System.Data;

namespace App.forms
{
    public partial class frmStudenti : Form
    {
        Baza db = new Baza();
        List<Studenti> StudentiPodaci = new List<Studenti>();

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }
        private void UcitajPodakte()
        {
            var filter = tbIme.Text.Trim().ToLower();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                // Razdvoji uneseni tekst na dijelove (npr. "student pet" -> ["student", "pet"])
                var filterParts = filter.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                StudentiPodaci = db.Studenti
                    .Where(x => filterParts.All(part =>
                        x.Ime.ToLower().Contains(part) ||
                        x.Prezime.ToLower().Contains(part))
                        && x.Datum >= dtpOd.Value
                        && x.Datum <= dtpDo.Value)
                    .ToList();
            }
            else
            {
                // Ako nema unosa, prikaži sve studente u rasponu datuma
                StudentiPodaci = db.Studenti
                    .Where(x => x.Datum >= dtpOd.Value && x.Datum <= dtpDo.Value)
                    .ToList();
            }

            if (StudentiPodaci.Count > 0)
            {
                var tabela = new DataTable();
                tabela.Columns.Add("Ime");
                tabela.Columns.Add("Prezime");
                tabela.Columns.Add("BrojObrokaRucak");
                tabela.Columns.Add("BrojObrokaVecera");
                tabela.Columns.Add("Datum");
                tabela.Columns.Add("Placeno");
                tabela.Columns.Add("VrijemeZadnjegObroka");

                foreach (var student in StudentiPodaci)
                {
                    var red = tabela.NewRow();
                    bool placeno = (DateTime.Now - student.Datum).TotalDays <= 30;
                    red["Ime"] = student.Ime;
                    red["Prezime"] = student.Prezime;
                    red["BrojObrokaRucak"] = placeno ? student.BrojObrokaRucak : 0;
                    red["BrojObrokaVecera"] = placeno ? student.BrojObrokaVecera : 0;
                    red["Datum"] = student.Datum.ToString("dd/MM/yyyy HH:mm");
                    red["VrijemeZadnjegObroka"] = student.VrijemeZadnjegObroka.ToString();
                    red["Placeno"] = placeno;
                    tabela.Rows.Add(red);
                }

                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tabela;
            }
            else
            {
                dgvStudenti.DataSource = null;
                MessageBox.Show("Nema studenata u bazi");
            }
        }
        private void frmStudenti_Load(object sender, EventArgs e)
        {
            StudentiPodaci = db.Studenti.ToList();
            if (StudentiPodaci.Count > 0)
            {
                var tabela = new DataTable();
                tabela.Columns.Add("Ime");
                tabela.Columns.Add("Prezime");
                tabela.Columns.Add("BrojObrokaRucak");
                tabela.Columns.Add("BrojObrokaVecera");
                tabela.Columns.Add("Datum");
                tabela.Columns.Add("Placeno");
                tabela.Columns.Add("VrijemeZadnjegObroka");
                for (int i = 0; i < StudentiPodaci.Count; i++)
                {
                    var student = StudentiPodaci[i];
                    var red = tabela.NewRow();
                    bool placeno = (DateTime.Now - student.Datum).TotalDays <= 31;
                    red["Ime"] = student.Ime.ToString();
                    red["Prezime"] = student.Prezime.ToString();
                    red["BrojObrokaRucak"] = placeno ? student.BrojObrokaRucak : 0;
                    red["BrojObrokaVecera"] = placeno ? student.BrojObrokaVecera : 0;
                    red["Datum"] = student.Datum.ToString("dd/MM/yyyy HH:mm");
                    DateTime datum = student.Datum;
                    red["VrijemeZadnjegObroka"] = student.VrijemeZadnjegObroka.ToString();
                    DateTime VrijemeZadnjegObroka = student.VrijemeZadnjegObroka;
                    red["Placeno"] = placeno;

                    if (placeno == false) student.BrojObrokaRucak = 0;
                    if (placeno == false) student.BrojObrokaVecera = 0;
                    db.SaveChanges();
                    tabela.Rows.Add(red);

                }

                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tabela;
            }
        }
        private void dgvStudenti_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                Hide();
                var novaForma = new frmNoviStudent(StudentiPodaci[e.RowIndex]);
                novaForma.ShowDialog();
                UcitajPodakte();
            }
        }
        private void tbIme_TextChanged_1(object sender, EventArgs e)
        {
            UcitajPodakte();
        }
        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodakte();
        }
        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajPodakte();
        }
        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            Hide();
            var novaForma = new frmNoviStudent(null);
            novaForma.ShowDialog();
            UcitajPodakte();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}