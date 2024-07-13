namespace DembirStokTakip
{
    partial class frmYeniCari
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.carikodutxt = new System.Windows.Forms.TextBox();
            this.aditxt = new System.Windows.Forms.TextBox();
            this.soyaditxt = new System.Windows.Forms.TextBox();
            this.telefontxt = new System.Windows.Forms.TextBox();
            this.adrestxt = new System.Windows.Forms.TextBox();
            this.kimliknotxt = new System.Windows.Forms.TextBox();
            this.btnCariKaydet = new System.Windows.Forms.Button();
            this.btnCariSil = new System.Windows.Forms.Button();
            this.btnCariVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kimlik Numarası :";
            // 
            // carikodutxt
            // 
            this.carikodutxt.Location = new System.Drawing.Point(164, 256);
            this.carikodutxt.Name = "carikodutxt";
            this.carikodutxt.Size = new System.Drawing.Size(100, 20);
            this.carikodutxt.TabIndex = 6;
            // 
            // aditxt
            // 
            this.aditxt.Location = new System.Drawing.Point(164, 66);
            this.aditxt.Name = "aditxt";
            this.aditxt.Size = new System.Drawing.Size(100, 20);
            this.aditxt.TabIndex = 7;
            this.aditxt.TextChanged += new System.EventHandler(this.aditxt_TextChanged);
            // 
            // soyaditxt
            // 
            this.soyaditxt.Location = new System.Drawing.Point(164, 104);
            this.soyaditxt.Name = "soyaditxt";
            this.soyaditxt.Size = new System.Drawing.Size(100, 20);
            this.soyaditxt.TabIndex = 8;
            this.soyaditxt.TextChanged += new System.EventHandler(this.soyaditxt_TextChanged);
            // 
            // telefontxt
            // 
            this.telefontxt.Location = new System.Drawing.Point(164, 142);
            this.telefontxt.Name = "telefontxt";
            this.telefontxt.Size = new System.Drawing.Size(100, 20);
            this.telefontxt.TabIndex = 9;
            // 
            // adrestxt
            // 
            this.adrestxt.Location = new System.Drawing.Point(164, 180);
            this.adrestxt.Name = "adrestxt";
            this.adrestxt.Size = new System.Drawing.Size(100, 20);
            this.adrestxt.TabIndex = 10;
            this.adrestxt.TextChanged += new System.EventHandler(this.adrestxt_TextChanged);
            // 
            // kimliknotxt
            // 
            this.kimliknotxt.Location = new System.Drawing.Point(164, 218);
            this.kimliknotxt.Name = "kimliknotxt";
            this.kimliknotxt.Size = new System.Drawing.Size(100, 20);
            this.kimliknotxt.TabIndex = 11;
            // 
            // btnCariKaydet
            // 
            this.btnCariKaydet.Location = new System.Drawing.Point(75, 12);
            this.btnCariKaydet.Name = "btnCariKaydet";
            this.btnCariKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnCariKaydet.TabIndex = 12;
            this.btnCariKaydet.Text = "Kaydet";
            this.btnCariKaydet.UseVisualStyleBackColor = true;
            this.btnCariKaydet.Click += new System.EventHandler(this.btnCariKaydet_Click);
            // 
            // btnCariSil
            // 
            this.btnCariSil.Location = new System.Drawing.Point(164, 12);
            this.btnCariSil.Name = "btnCariSil";
            this.btnCariSil.Size = new System.Drawing.Size(75, 23);
            this.btnCariSil.TabIndex = 13;
            this.btnCariSil.Text = "Sil";
            this.btnCariSil.UseVisualStyleBackColor = true;
            this.btnCariSil.Click += new System.EventHandler(this.btnCariSil_Click);
            // 
            // btnCariVazgec
            // 
            this.btnCariVazgec.Location = new System.Drawing.Point(253, 12);
            this.btnCariVazgec.Name = "btnCariVazgec";
            this.btnCariVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnCariVazgec.TabIndex = 14;
            this.btnCariVazgec.Text = "Vazgeç";
            this.btnCariVazgec.UseVisualStyleBackColor = true;
            this.btnCariVazgec.Click += new System.EventHandler(this.btnCariVazgec_Click);
            // 
            // frmYeniCari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(390, 389);
            this.Controls.Add(this.btnCariVazgec);
            this.Controls.Add(this.btnCariSil);
            this.Controls.Add(this.btnCariKaydet);
            this.Controls.Add(this.kimliknotxt);
            this.Controls.Add(this.adrestxt);
            this.Controls.Add(this.telefontxt);
            this.Controls.Add(this.soyaditxt);
            this.Controls.Add(this.aditxt);
            this.Controls.Add(this.carikodutxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmYeniCari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Kartı";
            this.Load += new System.EventHandler(this.frmYeniCari_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmYeniCari_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox carikodutxt;
        private System.Windows.Forms.TextBox aditxt;
        private System.Windows.Forms.TextBox soyaditxt;
        private System.Windows.Forms.TextBox telefontxt;
        private System.Windows.Forms.TextBox adrestxt;
        private System.Windows.Forms.TextBox kimliknotxt;
        private System.Windows.Forms.Button btnCariKaydet;
        private System.Windows.Forms.Button btnCariSil;
        private System.Windows.Forms.Button btnCariVazgec;
    }
}