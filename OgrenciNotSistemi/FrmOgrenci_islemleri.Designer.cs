namespace OgrenciNotSistemi
{
    partial class FrmOgrenci_islemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenci_islemleri));
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.lbl_Numara = new System.Windows.Forms.Label();
            this.lbl_Sınıf = new System.Windows.Forms.Label();
            this.lbl_Fakülte = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtFakulte = new System.Windows.Forms.TextBox();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.btn_ÖğrenciEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AdSoyad.Location = new System.Drawing.Point(53, 36);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(89, 18);
            this.lbl_AdSoyad.TabIndex = 0;
            this.lbl_AdSoyad.Text = "Ad Soyad: ";
            this.lbl_AdSoyad.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Numara
            // 
            this.lbl_Numara.AutoSize = true;
            this.lbl_Numara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Numara.Location = new System.Drawing.Point(53, 97);
            this.lbl_Numara.Name = "lbl_Numara";
            this.lbl_Numara.Size = new System.Drawing.Size(72, 18);
            this.lbl_Numara.TabIndex = 1;
            this.lbl_Numara.Text = "Numara:";
            this.lbl_Numara.Click += new System.EventHandler(this.lbl_Numara_Click);
            // 
            // lbl_Sınıf
            // 
            this.lbl_Sınıf.AutoSize = true;
            this.lbl_Sınıf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sınıf.Location = new System.Drawing.Point(53, 162);
            this.lbl_Sınıf.Name = "lbl_Sınıf";
            this.lbl_Sınıf.Size = new System.Drawing.Size(46, 18);
            this.lbl_Sınıf.TabIndex = 2;
            this.lbl_Sınıf.Text = "Sınıf:";
            this.lbl_Sınıf.Click += new System.EventHandler(this.lbl_Sınıf_Click);
            // 
            // lbl_Fakülte
            // 
            this.lbl_Fakülte.AutoSize = true;
            this.lbl_Fakülte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Fakülte.Location = new System.Drawing.Point(53, 220);
            this.lbl_Fakülte.Name = "lbl_Fakülte";
            this.lbl_Fakülte.Size = new System.Drawing.Size(68, 18);
            this.lbl_Fakülte.TabIndex = 3;
            this.lbl_Fakülte.Text = "Fakülte:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.White;
            this.txtAdSoyad.Location = new System.Drawing.Point(176, 32);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(169, 22);
            this.txtAdSoyad.TabIndex = 4;
            this.txtAdSoyad.Tag = "";
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFakulte
            // 
            this.txtFakulte.BackColor = System.Drawing.Color.White;
            this.txtFakulte.Location = new System.Drawing.Point(176, 218);
            this.txtFakulte.Name = "txtFakulte";
            this.txtFakulte.Size = new System.Drawing.Size(169, 22);
            this.txtFakulte.TabIndex = 6;
            this.txtFakulte.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSinif
            // 
            this.txtSinif.BackColor = System.Drawing.Color.White;
            this.txtSinif.Location = new System.Drawing.Point(176, 158);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(169, 22);
            this.txtSinif.TabIndex = 8;
            this.txtSinif.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNumara
            // 
            this.txtNumara.BackColor = System.Drawing.Color.White;
            this.txtNumara.Location = new System.Drawing.Point(176, 93);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(169, 22);
            this.txtNumara.TabIndex = 10;
            this.txtNumara.TextChanged += new System.EventHandler(this.txtNumara_TextChanged);
            // 
            // btn_ÖğrenciEkle
            // 
            this.btn_ÖğrenciEkle.BackColor = System.Drawing.Color.White;
            this.btn_ÖğrenciEkle.Location = new System.Drawing.Point(471, 32);
            this.btn_ÖğrenciEkle.Name = "btn_ÖğrenciEkle";
            this.btn_ÖğrenciEkle.Size = new System.Drawing.Size(122, 33);
            this.btn_ÖğrenciEkle.TabIndex = 11;
            this.btn_ÖğrenciEkle.Text = "Öğrenci Ekle";
            this.btn_ÖğrenciEkle.UseVisualStyleBackColor = false;
            this.btn_ÖğrenciEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 153);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(471, 115);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(122, 37);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Öğrenci Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(471, 193);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(122, 45);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Öğrenci Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FrmOgrenci_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ÖğrenciEkle);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtSinif);
            this.Controls.Add(this.txtFakulte);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lbl_Fakülte);
            this.Controls.Add(this.lbl_Sınıf);
            this.Controls.Add(this.lbl_Numara);
            this.Controls.Add(this.lbl_AdSoyad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgrenci_islemleri";
            this.Text = "Öğrenci İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.Label lbl_Numara;
        private System.Windows.Forms.Label lbl_Sınıf;
        private System.Windows.Forms.Label lbl_Fakülte;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtFakulte;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Button btn_ÖğrenciEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

