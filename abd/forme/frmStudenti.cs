using apk.baza;
using apk.klase;
using System.Data;

namespace Student.AO.forme
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
            var filter = tbIme.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                StudentiPodaci = db.Studenti.Where(x => x.Ime.ToLower().Contains(filter) && x.Datum >= dtpOd.Value && x.Datum <= dtpDo.Value).ToList();
            }
            else
            {
                StudentiPodaci = db.Studenti.ToList();
            }
            if (StudentiPodaci.Count > 0)
            {
                var tabela = new DataTable();
                tabela.Columns.Add("Ime");
                tabela.Columns.Add("Prezime");
                tabela.Columns.Add("BrojObroka");
                tabela.Columns.Add("Datum");
                tabela.Columns.Add("Placeno");
                for (int i = 0; i < StudentiPodaci.Count; i++)
                {
                    var student = StudentiPodaci[i];
                    var red = tabela.NewRow();
                    bool placeno = student.Datum.Year == DateTime.Now.Year && student.Datum.Month == DateTime.Now.Month;
                    red["Ime"] = student.Ime.ToString();
                    red["Prezime"] = student.Prezime.ToString();
                    red["BrojObroka"] = placeno ? student.BrojObroka : 0;
                    red["Datum"] = student.Datum.ToString();
                    DateTime datum = student.Datum;
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
                tabela.Columns.Add("BrojObroka");
                tabela.Columns.Add("Datum");
                tabela.Columns.Add("Placeno");
                for (int i = 0; i < StudentiPodaci.Count; i++)
                {
                    var student = StudentiPodaci[i];
                    var red = tabela.NewRow();
                    bool placeno = student.Datum.Year == DateTime.Now.Year && student.Datum.Month == DateTime.Now.Month;
                    red["Ime"] = student.Ime.ToString();
                    red["Prezime"] = student.Prezime.ToString();
                    red["BrojObroka"] = placeno ? student.BrojObroka : 0;
                    red["Datum"] = student.Datum.ToString();
                    DateTime datum = student.Datum;
                    red["Placeno"] = placeno;
                    tabela.Rows.Add(red);
                }
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tabela;
            }
        }

        private void tbIme_TextChanged(object sender, EventArgs e)
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var novaForma = new frmNoviStudent(null);
            novaForma.ShowDialog();
            UcitajPodakte();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var novaForma = new frmNoviStudent(StudentiPodaci[e.RowIndex]);
                novaForma.ShowDialog();
                UcitajPodakte();
            }
        }
    }
}
