namespace Student.AO.forme
{
    partial class frmStudenti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudenti));
            label1 = new Label();
            tbIme = new TextBox();
            label2 = new Label();
            dtpOd = new DateTimePicker();
            label3 = new Label();
            dtpDo = new DateTimePicker();
            btnDodaj = new Button();
            dgvStudenti = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            BrojObroka = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Placeno = new DataGridViewCheckBoxColumn();
            Uredi = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = "Ime i prezime:";
            // 
            // tbIme
            // 
            tbIme.Location = new Point(125, 7);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(435, 23);
            tbIme.TabIndex = 1;
            tbIme.TextChanged += tbIme_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 0;
            label2.Text = "za period od:";
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(117, 39);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(200, 23);
            dtpOd.TabIndex = 2;
            dtpOd.Value = new DateTime(2024, 10, 1, 0, 0, 0, 0);
            dtpOd.ValueChanged += dtpOd_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(323, 40);
            label3.Name = "label3";
            label3.Size = new Size(31, 21);
            label3.TabIndex = 0;
            label3.Text = "do:";
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(360, 39);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(200, 23);
            dtpDo.TabIndex = 2;
            dtpDo.Value = new DateTime(2024, 11, 1, 0, 0, 0, 0);
            dtpDo.ValueChanged += dtpDo_ValueChanged;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.PaleGreen;
            btnDodaj.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDodaj.Location = new Point(606, 5);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(178, 56);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj studenta";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, BrojObroka, Datum, Placeno, Uredi });
            dgvStudenti.Location = new Point(12, 68);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.Size = new Size(803, 378);
            dgvStudenti.TabIndex = 4;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // BrojObroka
            // 
            BrojObroka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojObroka.DataPropertyName = "BrojObroka";
            BrojObroka.HeaderText = "Broj obroka";
            BrojObroka.Name = "BrojObroka";
            BrojObroka.ReadOnly = true;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum uplate";
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Placeno
            // 
            Placeno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Placeno.DataPropertyName = "Placeno";
            Placeno.HeaderText = "Placeno";
            Placeno.Name = "Placeno";
            Placeno.ReadOnly = true;
            // 
            // Uredi
            // 
            Uredi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uredi.DataPropertyName = "Uredi";
            Uredi.HeaderText = "";
            Uredi.Name = "Uredi";
            Uredi.ReadOnly = true;
            Uredi.Text = "Uredi";
            Uredi.UseColumnTextForButtonValue = true;
            // 
            // frmStudenti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(830, 458);
            Controls.Add(dgvStudenti);
            Controls.Add(btnDodaj);
            Controls.Add(dtpDo);
            Controls.Add(dtpOd);
            Controls.Add(tbIme);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmStudenti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Studenti";
            Load += frmStudenti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbIme;
        private Label label2;
        private DateTimePicker dtpOd;
        private Label label3;
        private DateTimePicker dtpDo;
        private Button btnDodaj;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn BrojObroka;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewCheckBoxColumn Placeno;
        private DataGridViewButtonColumn Uredi;
    }
}