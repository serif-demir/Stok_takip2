namespace DembirStokTakip
{
    partial class StokKarti
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
            this.txtStokKodu = new System.Windows.Forms.TextBox();
            this.txtStokAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStokKaydet = new System.Windows.Forms.Button();
            this.btnStokVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(87, 88);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(100, 20);
            this.txtStokKodu.TabIndex = 0;
            this.txtStokKodu.Enter += new System.EventHandler(this.txtStokKodu_Enter);
            this.txtStokKodu.Leave += new System.EventHandler(this.txtStokKodu_Leave);
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(303, 88);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(100, 20);
            this.txtStokAdi.TabIndex = 1;
            this.txtStokAdi.TextChanged += new System.EventHandler(this.txtStokAdi_TextChanged);
            this.txtStokAdi.Enter += new System.EventHandler(this.txtStokAdi_Enter);
            this.txtStokAdi.Leave += new System.EventHandler(this.txtStokAdi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stok Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stok Adı:";
            // 
            // btnStokKaydet
            // 
            this.btnStokKaydet.Location = new System.Drawing.Point(112, 27);
            this.btnStokKaydet.Name = "btnStokKaydet";
            this.btnStokKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnStokKaydet.TabIndex = 5;
            this.btnStokKaydet.Text = "Kaydet";
            this.btnStokKaydet.UseVisualStyleBackColor = true;
            this.btnStokKaydet.Click += new System.EventHandler(this.btnStokKaydet_Click);
            this.btnStokKaydet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnStokKaydet_KeyDown);
            // 
            // btnStokVazgec
            // 
            this.btnStokVazgec.Location = new System.Drawing.Point(303, 27);
            this.btnStokVazgec.Name = "btnStokVazgec";
            this.btnStokVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnStokVazgec.TabIndex = 6;
            this.btnStokVazgec.Text = "Vazgeç";
            this.btnStokVazgec.UseVisualStyleBackColor = true;
            this.btnStokVazgec.Click += new System.EventHandler(this.btnStokVazgec_Click);
            // 
            // StokKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 144);
            this.Controls.Add(this.btnStokVazgec);
            this.Controls.Add(this.btnStokKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStokAdi);
            this.Controls.Add(this.txtStokKodu);
            this.KeyPreview = true;
            this.Name = "StokKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokKarti";
            this.Load += new System.EventHandler(this.StokKarti_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StokKarti_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStokKodu;
        private System.Windows.Forms.TextBox txtStokAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStokKaydet;
        private System.Windows.Forms.Button btnStokVazgec;
    }
}