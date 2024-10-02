namespace Student.AO.forme
{
    partial class frmNoviStudent
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoviStudent));
            pbSlika = new PictureBox();
            label1 = new Label();
            tbIme = new TextBox();
            label2 = new Label();
            tbPrezime = new TextBox();
            btnSpasi = new Button();
            err = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnIzbrisi = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.BackColor = Color.PaleGreen;
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(200, 220);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 12);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Ime:";
            // 
            // tbIme
            // 
            tbIme.Location = new Point(227, 30);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(228, 23);
            tbIme.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 70);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Prezime:";
            // 
            // tbPrezime
            // 
            tbPrezime.Location = new Point(227, 88);
            tbPrezime.Name = "tbPrezime";
            tbPrezime.Size = new Size(228, 23);
            tbPrezime.TabIndex = 1;
            // 
            // btnSpasi
            // 
            btnSpasi.BackColor = Color.PaleGreen;
            btnSpasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSpasi.Location = new Point(227, 197);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(109, 35);
            btnSpasi.TabIndex = 3;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = false;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 133);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 1;
            label3.Text = "Uplaceno:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(227, 151);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // btnIzbrisi
            // 
            btnIzbrisi.BackColor = Color.Red;
            btnIzbrisi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIzbrisi.Location = new Point(346, 197);
            btnIzbrisi.Name = "btnIzbrisi";
            btnIzbrisi.Size = new Size(109, 35);
            btnIzbrisi.TabIndex = 4;
            btnIzbrisi.Text = "Izbriši";
            btnIzbrisi.UseVisualStyleBackColor = false;
            btnIzbrisi.Click += btnIzbrisi_Click;
            // 
            // frmNoviStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(465, 244);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnIzbrisi);
            Controls.Add(btnSpasi);
            Controls.Add(tbPrezime);
            Controls.Add(tbIme);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbSlika);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNoviStudent";
            Text = "Podaci o studentu";
            Load += frmNoviStudent_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label label1;
        private TextBox tbIme;
        private Label label2;
        private TextBox tbPrezime;
        private Button btnSpasi;
        private ErrorProvider err;
        private OpenFileDialog openFileDialog1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button btnIzbrisi;
    }
}