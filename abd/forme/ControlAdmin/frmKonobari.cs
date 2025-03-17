using apk.baza;
using Student.Klase;
using System.Data;

namespace App.forms.ControlAdmin
{
    public partial class frmPretragaKonobara : Form
    {
        Baza db = new Baza();
        List<Uposlenici> UposleniciPodaci = new List<Uposlenici>();
        public frmPretragaKonobara()
        {
            InitializeComponent();
            dgvKonobari.AutoGenerateColumns = false;
        }
        private void frmPretragaKonobara_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            UposleniciPodaci = db.Korisnici.Where(x => x.RoleId == 2).ToList();
            if (UposleniciPodaci.Count > 0)
            {
                var tabela = new DataTable();
                tabela.Columns.Add("Ime");
                tabela.Columns.Add("Datum");
                for (int i = 0; i < UposleniciPodaci.Count; i++)
                {
                    var konobar = UposleniciPodaci[i];
                    var red = tabela.NewRow();
                    red["Ime"] = konobar.Ime.ToString();
                    red["Datum"] = konobar.DatumZaposljenja.ToString();
                    tabela.Rows.Add(red);
                }
                dgvKonobari.DataSource = null;
                dgvKonobari.DataSource = tabela;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            var novaForma = new frmNoviKonobar(null);
            novaForma.ShowDialog();
            this.Show();
            UcitajPodatke();
        }

        private void dgvKonobari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                this.Hide();
                var novaForma = new frmNoviKonobar(UposleniciPodaci[e.RowIndex]);
                novaForma.ShowDialog();
                UcitajPodatke();
                this.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
