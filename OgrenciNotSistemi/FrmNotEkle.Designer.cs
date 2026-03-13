namespace OgrenciNotSistemi
{
    partial class FrmNotEkle
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
            this.cmbOgrenci = new System.Windows.Forms.ComboBox();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOgrenci
            // 
            this.cmbOgrenci.FormattingEnabled = true;
            this.cmbOgrenci.Location = new System.Drawing.Point(161, 149);
            this.cmbOgrenci.Name = "cmbOgrenci";
            this.cmbOgrenci.Size = new System.Drawing.Size(235, 24);
            this.cmbOgrenci.TabIndex = 0;
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(161, 269);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(235, 24);
            this.cmbDers.TabIndex = 1;
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(593, 84);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(126, 22);
            this.txtVize.TabIndex = 2;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(593, 149);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(126, 22);
            this.txtFinal.TabIndex = 3;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(619, 269);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(100, 22);
            this.txtDurum.TabIndex = 4;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(619, 219);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 22);
            this.txtOrtalama.TabIndex = 5;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(449, 333);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(114, 52);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(619, 333);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(114, 52);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ÖĞRENCİ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "DERS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "VİZE NOTU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "ORTALAMA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "FİNAL NOTU:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "DURUM:";
            // 
            // FrmNotEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.cmbOgrenci);
            this.Name = "FrmNotEkle";
            this.Text = "Not Girişi";
            this.Load += new System.EventHandler(this.FrmNotEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOgrenci;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}