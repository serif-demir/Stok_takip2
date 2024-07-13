using DembirStokTakip;

namespace DembirStokTakip
{
    partial class DembirStokTakip
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DembirStokTakip));
            this.btnCari = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCariListesi = new System.Windows.Forms.TabPage();
            this.btnAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnCloseTabControl = new System.Windows.Forms.Button();
            this.dgvCariListesi = new System.Windows.Forms.DataGridView();
            this.btnCariSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeniCari = new System.Windows.Forms.Button();
            this.tabPageCariHesabi = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniİşlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokÇıkışıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemiDüzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipDatabaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblSelectedCariAd = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageCariListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariListesi)).BeginInit();
            this.tabPageCariHesabi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDatabaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cariBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCari
            // 
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCari.Location = new System.Drawing.Point(12, 174);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(133, 90);
            this.btnCari.TabIndex = 0;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnStok
            // 
            this.btnStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.Location = new System.Drawing.Point(12, 285);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(133, 90);
            this.btnStok.TabIndex = 1;
            this.btnStok.Text = "Stok";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.tabPageCariListesi);
            this.tabControl1.Controls.Add(this.tabPageCariHesabi);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.tabControl1.Location = new System.Drawing.Point(170, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1156, 746);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Visible = false;
            // 
            // tabPageCariListesi
            // 
            this.tabPageCariListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPageCariListesi.Controls.Add(this.btnAra);
            this.tabPageCariListesi.Controls.Add(this.label1);
            this.tabPageCariListesi.Controls.Add(this.txtArama);
            this.tabPageCariListesi.Controls.Add(this.btnCloseTabControl);
            this.tabPageCariListesi.Controls.Add(this.dgvCariListesi);
            this.tabPageCariListesi.Controls.Add(this.btnCariSil);
            this.tabPageCariListesi.Controls.Add(this.btnDuzenle);
            this.tabPageCariListesi.Controls.Add(this.btnYeniCari);
            this.tabPageCariListesi.Location = new System.Drawing.Point(4, 30);
            this.tabPageCariListesi.Name = "tabPageCariListesi";
            this.tabPageCariListesi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCariListesi.Size = new System.Drawing.Size(1148, 712);
            this.tabPageCariListesi.TabIndex = 0;
            this.tabPageCariListesi.Text = "Cari Listesi";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(184, 683);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(47, 27);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 686);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(78, 683);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(100, 26);
            this.txtArama.TabIndex = 5;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged_1);
            // 
            // btnCloseTabControl
            // 
            this.btnCloseTabControl.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseTabControl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCloseTabControl.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseTabControl.Image")));
            this.btnCloseTabControl.Location = new System.Drawing.Point(1094, 18);
            this.btnCloseTabControl.Name = "btnCloseTabControl";
            this.btnCloseTabControl.Size = new System.Drawing.Size(36, 34);
            this.btnCloseTabControl.TabIndex = 4;
            this.btnCloseTabControl.UseVisualStyleBackColor = false;
            this.btnCloseTabControl.Click += new System.EventHandler(this.btnCloseTabControl_Click);
            // 
            // dgvCariListesi
            // 
            this.dgvCariListesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCariListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariListesi.Location = new System.Drawing.Point(6, 55);
            this.dgvCariListesi.Name = "dgvCariListesi";
            this.dgvCariListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCariListesi.Size = new System.Drawing.Size(1124, 621);
            this.dgvCariListesi.TabIndex = 3;
            this.dgvCariListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCariListesi_CellContentClick);
            this.dgvCariListesi.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCariListesi_CellContentDoubleClick);
            // 
            // btnCariSil
            // 
            this.btnCariSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.btnCariSil.Location = new System.Drawing.Point(168, 18);
            this.btnCariSil.Name = "btnCariSil";
            this.btnCariSil.Size = new System.Drawing.Size(75, 31);
            this.btnCariSil.TabIndex = 2;
            this.btnCariSil.Text = "Cari Sil";
            this.btnCariSil.UseVisualStyleBackColor = true;
            this.btnCariSil.Click += new System.EventHandler(this.btnCariSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.btnDuzenle.Location = new System.Drawing.Point(87, 18);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 31);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeniCari
            // 
            this.btnYeniCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.btnYeniCari.Location = new System.Drawing.Point(6, 18);
            this.btnYeniCari.Name = "btnYeniCari";
            this.btnYeniCari.Size = new System.Drawing.Size(75, 31);
            this.btnYeniCari.TabIndex = 0;
            this.btnYeniCari.Text = "Yeni Cari";
            this.btnYeniCari.UseVisualStyleBackColor = true;
            this.btnYeniCari.Click += new System.EventHandler(this.btnYeniCari_Click);
            // 
            // tabPageCariHesabi
            // 
            this.tabPageCariHesabi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPageCariHesabi.Controls.Add(this.lblSelectedCariAd);
            this.tabPageCariHesabi.Controls.Add(this.dataGridView1);
            this.tabPageCariHesabi.Controls.Add(this.menuStrip1);
            this.tabPageCariHesabi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPageCariHesabi.Location = new System.Drawing.Point(4, 30);
            this.tabPageCariHesabi.Name = "tabPageCariHesabi";
            this.tabPageCariHesabi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCariHesabi.Size = new System.Drawing.Size(1148, 712);
            this.tabPageCariHesabi.TabIndex = 1;
            this.tabPageCariHesabi.Text = "Cari Hesabı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1135, 636);
            this.dataGridView1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniİşlemToolStripMenuItem,
            this.işlemiDüzeltToolStripMenuItem,
            this.işlemiSilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1142, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniİşlemToolStripMenuItem
            // 
            this.yeniİşlemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokGirişiToolStripMenuItem,
            this.stokÇıkışıToolStripMenuItem});
            this.yeniİşlemToolStripMenuItem.Name = "yeniİşlemToolStripMenuItem";
            this.yeniİşlemToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.yeniİşlemToolStripMenuItem.Text = "Yeni İşlem";
            // 
            // stokGirişiToolStripMenuItem
            // 
            this.stokGirişiToolStripMenuItem.Name = "stokGirişiToolStripMenuItem";
            this.stokGirişiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stokGirişiToolStripMenuItem.Text = "Stok Girişi";
            this.stokGirişiToolStripMenuItem.Click += new System.EventHandler(this.stokGirişiToolStripMenuItem_Click);
            // 
            // stokÇıkışıToolStripMenuItem
            // 
            this.stokÇıkışıToolStripMenuItem.Name = "stokÇıkışıToolStripMenuItem";
            this.stokÇıkışıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stokÇıkışıToolStripMenuItem.Text = "Stok Çıkışı";
            // 
            // işlemiDüzeltToolStripMenuItem
            // 
            this.işlemiDüzeltToolStripMenuItem.Name = "işlemiDüzeltToolStripMenuItem";
            this.işlemiDüzeltToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.işlemiDüzeltToolStripMenuItem.Text = "İşlemi Düzelt";
            // 
            // işlemiSilToolStripMenuItem
            // 
            this.işlemiSilToolStripMenuItem.Name = "işlemiSilToolStripMenuItem";
            this.işlemiSilToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.işlemiSilToolStripMenuItem.Text = "İşlemi Sil";
            // 
            // cariBindingSource
            // 
            this.cariBindingSource.DataMember = "cari";
            // 
            // cariBindingSource1
            // 
            this.cariBindingSource1.DataMember = "cari";
            this.cariBindingSource1.DataSource = this.stokTakipDatabaseDataSet1BindingSource;
            // 
            // lblSelectedCariAd
            // 
            this.lblSelectedCariAd.AutoSize = true;
            this.lblSelectedCariAd.Location = new System.Drawing.Point(513, 31);
            this.lblSelectedCariAd.Name = "lblSelectedCariAd";
            this.lblSelectedCariAd.Size = new System.Drawing.Size(0, 20);
            this.lblSelectedCariAd.TabIndex = 8;
            // 
            // DembirStokTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1342, 771);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnCari);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DembirStokTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DembirStokTakip";
            this.Load += new System.EventHandler(this.DembirStokTakip_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCariListesi.ResumeLayout(false);
            this.tabPageCariListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariListesi)).EndInit();
            this.tabPageCariHesabi.ResumeLayout(false);
            this.tabPageCariHesabi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipDatabaseDataSet1BindingSource)).EndInit();
         //   ((System.ComponentModel.ISupportInitialize)(this.cariBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.TabPage tabPageCariHesabi;
        private System.Windows.Forms.TabControl tabControl1;
//        private DembirStokTakip.StokTakipDatabaseDataSet stokTakipDatabaseDataSet;
        private System.Windows.Forms.BindingSource cariBindingSource;
        //        private DembirStokTakip.StokTakipDatabaseDataSetTableAdapters.cariTableAdapter cariTableAdapter;
        /*        private System.Windows.Forms.DataGridViewTextBoxColumn carikoduDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
                private System.Windows.Forms.DataGridViewTextBoxColumn kimliknoDataGridViewTextBoxColumn;
         //       private DembirStokTakip.StokTakipDatabaseDataSet stokTakipDatabaseDataSet1;
         //       private DembirStokTakip.StokTakipDatabaseDataSet stokTakipDatabaseDataSet2;*/
        private System.Windows.Forms.BindingSource stokTakipDatabaseDataSet1BindingSource;
                private System.Windows.Forms.BindingSource cariBindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniİşlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokÇıkışıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemiDüzeltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemiSilToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageCariListesi;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnCloseTabControl;
        private System.Windows.Forms.DataGridView dgvCariListesi;
        private System.Windows.Forms.Button btnCariSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYeniCari;
        private System.Windows.Forms.Label lblSelectedCariAd;
        //       private DembirStokTakip.StokTakipDatabaseDataSetTableAdapters.cariTableAdapter cariTableAdapter;
    }
}