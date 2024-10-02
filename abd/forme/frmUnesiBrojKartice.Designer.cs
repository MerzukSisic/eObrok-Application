namespace Student.AO.forme
{
    partial class frmUnesiBrojKartice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnesiBrojKartice));
            tbBrojKartice = new TextBox();
            label1 = new Label();
            btnNastavi = new Button();
            SuspendLayout();
            // 
            // tbBrojKartice
            // 
            tbBrojKartice.Font = new Font("Segoe UI", 12F);
            tbBrojKartice.Location = new Point(12, 61);
            tbBrojKartice.Name = "tbBrojKartice";
            tbBrojKartice.Size = new Size(345, 29);
            tbBrojKartice.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 1;
            label1.Text = "Broj kartice:";
            // 
            // btnNastavi
            // 
            btnNastavi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNastavi.Location = new Point(193, 147);
            btnNastavi.Name = "btnNastavi";
            btnNastavi.Size = new Size(164, 36);
            btnNastavi.TabIndex = 1;
            btnNastavi.Text = "Nastavi dalje";
            btnNastavi.UseVisualStyleBackColor = true;
            btnNastavi.Click += btnNastavi_Click;
            // 
            // frmUnesiBrojKartice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 195);
            Controls.Add(btnNastavi);
            Controls.Add(label1);
            Controls.Add(tbBrojKartice);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUnesiBrojKartice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Broj kartice";
            Load += frmUnesiBrojKartice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbBrojKartice;
        private Label label1;
        private Button btnNastavi;
    }
}