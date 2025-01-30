namespace DLWMS.WinApp.IspitIB230181
{
    partial class frmPretragaIB230181
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
            tbIme = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbDrzava = new ComboBox();
            label3 = new Label();
            cmbSpol = new ComboBox();
            dgvPodaci = new DataGridView();
            ImePrezime = new DataGridViewTextBoxColumn();
            Drzava = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnRazmjena = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // tbIme
            // 
            tbIme.Location = new Point(12, 44);
            tbIme.Name = "tbIme";
            tbIme.Size = new Size(199, 23);
            tbIme.TabIndex = 0;
            tbIme.TextChanged += tbIme_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Ime i prezime: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 26);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Drzava:";
            // 
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(218, 44);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(192, 23);
            cmbDrzava.TabIndex = 3;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 26);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Spol:";
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(416, 44);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(121, 23);
            cmbSpol.TabIndex = 3;
            cmbSpol.SelectedIndexChanged += cmbSpol_SelectedIndexChanged;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { ImePrezime, Drzava, Grad, Spol, Aktivan, btnRazmjena });
            dgvPodaci.Location = new Point(12, 86);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.Size = new Size(776, 352);
            dgvPodaci.TabIndex = 4;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            dgvPodaci.CellContentDoubleClick += dgvPodaci_CellContentDoubleClick;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.FillWeight = 152.284271F;
            ImePrezime.HeaderText = "Indeks, ime i prezime";
            ImePrezime.Name = "ImePrezime";
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Drzava";
            Drzava.FillWeight = 89.54315F;
            Drzava.HeaderText = "Drzava";
            Drzava.Name = "Drzava";
            // 
            // Grad
            // 
            Grad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grad.DataPropertyName = "Grad";
            Grad.FillWeight = 89.54315F;
            Grad.HeaderText = "Grad";
            Grad.Name = "Grad";
            // 
            // Spol
            // 
            Spol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Spol.DataPropertyName = "Spol";
            Spol.FillWeight = 89.54315F;
            Spol.HeaderText = "Spol";
            Spol.Name = "Spol";
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.FillWeight = 89.54315F;
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            // 
            // btnRazmjena
            // 
            btnRazmjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnRazmjena.DataPropertyName = "btnRazmjena";
            btnRazmjena.FillWeight = 89.54315F;
            btnRazmjena.HeaderText = "";
            btnRazmjena.Name = "btnRazmjena";
            btnRazmjena.Text = "Razmjena";
            btnRazmjena.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB230181
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPodaci);
            Controls.Add(cmbSpol);
            Controls.Add(label3);
            Controls.Add(cmbDrzava);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbIme);
            Name = "frmPretragaIB230181";
            Text = "frmPretragaIB230181";
            Load += frmPretragaIB230181_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbIme;
        private Label label1;
        private Label label2;
        private ComboBox cmbDrzava;
        private Label label3;
        private ComboBox cmbSpol;
        private DataGridView dgvPodaci;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnRazmjena;
    }
}