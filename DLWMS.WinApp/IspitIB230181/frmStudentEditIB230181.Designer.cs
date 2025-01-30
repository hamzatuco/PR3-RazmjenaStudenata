namespace DLWMS.WinApp.IspitIB230181
{
    partial class frmStudentEditIB230181
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
            pbSlika = new PictureBox();
            lbIme = new Label();
            lblIndeks = new Label();
            btnSlika = new Button();
            btnSave = new Button();
            cmbGradovi = new ComboBox();
            cmbDrzave = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(24, 25);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(210, 201);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lbIme
            // 
            lbIme.Font = new Font("Segoe UI", 27F);
            lbIme.Location = new Point(270, 25);
            lbIme.Name = "lbIme";
            lbIme.Size = new Size(284, 54);
            lbIme.TabIndex = 1;
            lbIme.Text = "label1";
            // 
            // lblIndeks
            // 
            lblIndeks.AutoSize = true;
            lblIndeks.Font = new Font("Segoe UI", 20F);
            lblIndeks.Location = new Point(270, 79);
            lblIndeks.Name = "lblIndeks";
            lblIndeks.Size = new Size(90, 37);
            lblIndeks.TabIndex = 1;
            lblIndeks.Text = "label1";
            // 
            // btnSlika
            // 
            btnSlika.Location = new Point(24, 247);
            btnSlika.Name = "btnSlika";
            btnSlika.Size = new Size(210, 23);
            btnSlika.TabIndex = 2;
            btnSlika.Text = "Ucitaj sliku";
            btnSlika.UseVisualStyleBackColor = true;
            btnSlika.Click += btnSlika_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(434, 247);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(71, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Sacuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbGradovi
            // 
            cmbGradovi.FormattingEnabled = true;
            cmbGradovi.Location = new Point(279, 203);
            cmbGradovi.Name = "cmbGradovi";
            cmbGradovi.Size = new Size(226, 23);
            cmbGradovi.TabIndex = 3;
            // 
            // cmbDrzave
            // 
            cmbDrzave.FormattingEnabled = true;
            cmbDrzave.Location = new Point(279, 150);
            cmbDrzave.Name = "cmbDrzave";
            cmbDrzave.Size = new Size(226, 23);
            cmbDrzave.TabIndex = 4;
            cmbDrzave.SelectedIndexChanged += cmbDrzave_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 185);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 5;
            label1.Text = "Grad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 132);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Drzava";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmStudentEditIB230181
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 298);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbDrzave);
            Controls.Add(cmbGradovi);
            Controls.Add(btnSave);
            Controls.Add(btnSlika);
            Controls.Add(lblIndeks);
            Controls.Add(lbIme);
            Controls.Add(pbSlika);
            Name = "frmStudentEditIB230181";
            Text = "Uredjivanje podataka o studentu";
            Load += frmStudentEditIB230181_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lbIme;
        private Label lblIndeks;
        private Button btnSlika;
        private Button btnSave;
        private ComboBox cmbGradovi;
        private ComboBox cmbDrzave;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}