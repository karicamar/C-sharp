namespace DLWMS.WinForms.IB180072
{
    partial class frmPoruke
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
            this.dgvPoruke = new System.Windows.Forms.DataGridView();
            this.lbltekst = new System.Windows.Forms.Label();
            this.btnNovaPoruka = new System.Windows.Forms.Button();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPoruke
            // 
            this.dgvPoruke.AllowUserToAddRows = false;
            this.dgvPoruke.AllowUserToDeleteRows = false;
            this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Vrijeme,
            this.Sadrzaj,
            this.Slika,
            this.Brisi});
            this.dgvPoruke.Location = new System.Drawing.Point(141, 185);
            this.dgvPoruke.Name = "dgvPoruke";
            this.dgvPoruke.ReadOnly = true;
            this.dgvPoruke.RowHeadersWidth = 51;
            this.dgvPoruke.RowTemplate.Height = 24;
            this.dgvPoruke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoruke.Size = new System.Drawing.Size(817, 301);
            this.dgvPoruke.TabIndex = 0;
            this.dgvPoruke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoruke_CellContentClick);
            // 
            // lbltekst
            // 
            this.lbltekst.Location = new System.Drawing.Point(104, 47);
            this.lbltekst.Name = "lbltekst";
            this.lbltekst.Size = new System.Drawing.Size(398, 23);
            this.lbltekst.TabIndex = 1;
            // 
            // btnNovaPoruka
            // 
            this.btnNovaPoruka.Location = new System.Drawing.Point(796, 60);
            this.btnNovaPoruka.Name = "btnNovaPoruka";
            this.btnNovaPoruka.Size = new System.Drawing.Size(150, 23);
            this.btnNovaPoruka.TabIndex = 2;
            this.btnNovaPoruka.Text = "Nova Poruka";
            this.btnNovaPoruka.UseVisualStyleBackColor = true;
            this.btnNovaPoruka.Click += new System.EventHandler(this.btnNovaPoruka_Click);
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            this.Predmet.Width = 125;
            // 
            // Vrijeme
            // 
            this.Vrijeme.DataPropertyName = "Vrijeme";
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.MinimumWidth = 6;
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.ReadOnly = true;
            this.Vrijeme.Width = 125;
            // 
            // Sadrzaj
            // 
            this.Sadrzaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sadrzaj.DataPropertyName = "Sadrzaj";
            this.Sadrzaj.HeaderText = "Sadrzaj";
            this.Sadrzaj.MinimumWidth = 6;
            this.Sadrzaj.Name = "Sadrzaj";
            this.Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.MinimumWidth = 6;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Width = 125;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Brisi";
            this.Brisi.UseColumnTextForButtonValue = true;
            this.Brisi.Width = 125;
            // 
            // frmPoruke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 564);
            this.Controls.Add(this.btnNovaPoruka);
            this.Controls.Add(this.lbltekst);
            this.Controls.Add(this.dgvPoruke);
            this.Name = "frmPoruke";
            this.Text = "frmPoruke";
            this.Load += new System.EventHandler(this.frmPoruke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPoruke;
        private System.Windows.Forms.Label lbltekst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slika;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
        private System.Windows.Forms.Button btnNovaPoruka;
    }
}