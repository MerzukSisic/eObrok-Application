namespace Student.AO.forme
{
    partial class frmSkeniraj
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
            pbSlika = new PictureBox();
            label1 = new Label();
            btnUzmiObrok = new Button();
            label2 = new Label();
            lblIme = new Label();
            lblPrezime = new Label();
            label3 = new Label();
            lblBrojKartice = new Label();
            label4 = new Label();
            lblBrojObroka = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(230, 249);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(248, 12);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 1;
            label1.Text = "Ime:";
            // 
            // btnUzmiObrok
            // 
            btnUzmiObrok.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUzmiObrok.Location = new Point(293, 200);
            btnUzmiObrok.Name = "btnUzmiObrok";
            btnUzmiObrok.Size = new Size(194, 59);
            btnUzmiObrok.TabIndex = 2;
            btnUzmiObrok.Text = "Skeniraj obrok";
            btnUzmiObrok.UseVisualStyleBackColor = true;
            btnUzmiObrok.Click += btnUzmiObrok_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(248, 44);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Prezime:";
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Segoe UI", 12F);
            lblIme.Location = new Point(293, 12);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(0, 21);
            lblIme.TabIndex = 1;
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Font = new Font("Segoe UI", 12F);
            lblPrezime.Location = new Point(327, 44);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(0, 21);
            lblPrezime.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(248, 113);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 1;
            label3.Text = "Broj kartice";
            // 
            // lblBrojKartice
            // 
            lblBrojKartice.AutoSize = true;
            lblBrojKartice.Font = new Font("Segoe UI", 12F);
            lblBrojKartice.Location = new Point(342, 113);
            lblBrojKartice.Name = "lblBrojKartice";
            lblBrojKartice.Size = new Size(0, 21);
            lblBrojKartice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(248, 79);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 1;
            label4.Text = "Broj obroka";
            // 
            // lblBrojObroka
            // 
            lblBrojObroka.AutoSize = true;
            lblBrojObroka.Font = new Font("Segoe UI", 12F);
            lblBrojObroka.Location = new Point(342, 79);
            lblBrojObroka.Name = "lblBrojObroka";
            lblBrojObroka.Size = new Size(0, 21);
            lblBrojObroka.TabIndex = 1;
            // 
            // frmSkeniraj
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 271);
            Controls.Add(btnUzmiObrok);
            Controls.Add(lblBrojObroka);
            Controls.Add(lblBrojKartice);
            Controls.Add(lblPrezime);
            Controls.Add(lblIme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbSlika);
            Name = "frmSkeniraj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Skeniraj";
            Load += frmSkeniraj_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label label1;
        private Button btnUzmiObrok;
        private Label label2;
        private Label lblIme;
        private Label lblPrezime;
        private Label label3;
        private Label lblBrojKartice;
        private Label label4;
        private Label lblBrojObroka;
    }
}