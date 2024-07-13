namespace DembirStokTakip
{
    partial class StokForm
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
            this.btnStokYeni = new System.Windows.Forms.Button();
            this.btnStokDuzelt = new System.Windows.Forms.Button();
            this.btnStokSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStokYeni
            // 
            this.btnStokYeni.Location = new System.Drawing.Point(13, 12);
            this.btnStokYeni.Name = "btnStokYeni";
            this.btnStokYeni.Size = new System.Drawing.Size(133, 40);
            this.btnStokYeni.TabIndex = 0;
            this.btnStokYeni.Text = "Yeni";
            this.btnStokYeni.UseVisualStyleBackColor = true;
            this.btnStokYeni.Click += new System.EventHandler(this.btnStokYeni_Click);
            // 
            // btnStokDuzelt
            // 
            this.btnStokDuzelt.Location = new System.Drawing.Point(152, 12);
            this.btnStokDuzelt.Name = "btnStokDuzelt";
            this.btnStokDuzelt.Size = new System.Drawing.Size(133, 40);
            this.btnStokDuzelt.TabIndex = 1;
            this.btnStokDuzelt.Text = "Düzelt";
            this.btnStokDuzelt.UseVisualStyleBackColor = true;
            this.btnStokDuzelt.Click += new System.EventHandler(this.btnStokDuzelt_Click);
            // 
            // btnStokSil
            // 
            this.btnStokSil.Location = new System.Drawing.Point(291, 12);
            this.btnStokSil.Name = "btnStokSil";
            this.btnStokSil.Size = new System.Drawing.Size(133, 40);
            this.btnStokSil.TabIndex = 2;
            this.btnStokSil.Text = "Sil";
            this.btnStokSil.UseVisualStyleBackColor = true;
            this.btnStokSil.Click += new System.EventHandler(this.btnStokSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 453);
            this.dataGridView1.TabIndex = 3;
            // 
            // StokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 534);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStokSil);
            this.Controls.Add(this.btnStokDuzelt);
            this.Controls.Add(this.btnStokYeni);
            this.Name = "StokForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok İşlemleri";
            this.Load += new System.EventHandler(this.StokForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStokYeni;
        private System.Windows.Forms.Button btnStokDuzelt;
        private System.Windows.Forms.Button btnStokSil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}