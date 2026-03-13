namespace OgrenciNotSistemi
{
    partial class FrmAnaMenu
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
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnNotlar = new System.Windows.Forms.Button();
            this.btnDersler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(80, 23);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(249, 177);
            this.btnOgrenci.TabIndex = 0;
            this.btnOgrenci.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Location = new System.Drawing.Point(436, 241);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(232, 177);
            this.btnRaporlar.TabIndex = 1;
            this.btnRaporlar.Text = "RAPORLAR";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnNotlar
            // 
            this.btnNotlar.Location = new System.Drawing.Point(80, 241);
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.Size = new System.Drawing.Size(247, 177);
            this.btnNotlar.TabIndex = 2;
            this.btnNotlar.Text = "NOTLAR";
            this.btnNotlar.UseVisualStyleBackColor = true;
            this.btnNotlar.Click += new System.EventHandler(this.btnNotlar_Click);
            // 
            // btnDersler
            // 
            this.btnDersler.Location = new System.Drawing.Point(436, 23);
            this.btnDersler.Name = "btnDersler";
            this.btnDersler.Size = new System.Drawing.Size(232, 177);
            this.btnDersler.TabIndex = 3;
            this.btnDersler.Text = "DERS İŞLEMLERİ";
            this.btnDersler.UseVisualStyleBackColor = true;
            this.btnDersler.Click += new System.EventHandler(this.btnDersler_Click);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 448);
            this.Controls.Add(this.btnDersler);
            this.Controls.Add(this.btnNotlar);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnOgrenci);
            this.Name = "FrmAnaMenu";
            this.Text = "Öğrenci Not Takip Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnNotlar;
        private System.Windows.Forms.Button btnDersler;
    }
}