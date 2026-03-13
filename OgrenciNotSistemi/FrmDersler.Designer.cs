namespace OgrenciNotSistemi
{
    partial class FrmDersler
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
            this.lbl_dersid = new System.Windows.Forms.Label();
            this.txtDersID = new System.Windows.Forms.TextBox();
            this.lbl_deradi = new System.Windows.Forms.Label();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dersid
            // 
            this.lbl_dersid.AutoSize = true;
            this.lbl_dersid.Location = new System.Drawing.Point(57, 53);
            this.lbl_dersid.Name = "lbl_dersid";
            this.lbl_dersid.Size = new System.Drawing.Size(64, 16);
            this.lbl_dersid.TabIndex = 0;
            this.lbl_dersid.Text = "DERS ID:";
            // 
            // txtDersID
            // 
            this.txtDersID.Enabled = false;
            this.txtDersID.Location = new System.Drawing.Point(157, 53);
            this.txtDersID.Name = "txtDersID";
            this.txtDersID.Size = new System.Drawing.Size(190, 22);
            this.txtDersID.TabIndex = 1;
            // 
            // lbl_deradi
            // 
            this.lbl_deradi.AutoSize = true;
            this.lbl_deradi.Location = new System.Drawing.Point(57, 139);
            this.lbl_deradi.Name = "lbl_deradi";
            this.lbl_deradi.Size = new System.Drawing.Size(73, 16);
            this.lbl_deradi.TabIndex = 2;
            this.lbl_deradi.Text = "DERS ADI:";
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(157, 139);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(190, 22);
            this.txtDersAd.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(45, 234);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(133, 60);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ders Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(243, 234);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(133, 60);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Ders Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(45, 329);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(133, 60);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Ders Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(243, 329);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(133, 60);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Ders Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(442, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(346, 426);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmDersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtDersAd);
            this.Controls.Add(this.lbl_deradi);
            this.Controls.Add(this.txtDersID);
            this.Controls.Add(this.lbl_dersid);
            this.Name = "FrmDersler";
            this.Text = "⁬Ders İşlemleri";
            this.Load += new System.EventHandler(this.FrmDersler_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dersid;
        private System.Windows.Forms.TextBox txtDersID;
        private System.Windows.Forms.Label lbl_deradi;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}