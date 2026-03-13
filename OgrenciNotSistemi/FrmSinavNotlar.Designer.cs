namespace OgrenciNotSistemi
{
    partial class FrmSinavNotlar
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
            this.lblOgrenciEkle = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOgrenciEkle
            // 
            this.lblOgrenciEkle.AutoSize = true;
            this.lblOgrenciEkle.Location = new System.Drawing.Point(29, 31);
            this.lblOgrenciEkle.Name = "lblOgrenciEkle";
            this.lblOgrenciEkle.Size = new System.Drawing.Size(102, 16);
            this.lblOgrenciEkle.TabIndex = 0;
            this.lblOgrenciEkle.Text = "ÖĞRENCİ ARA:";
            this.lblOgrenciEkle.Click += new System.EventHandler(this.lblOgrenciEkle_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(148, 25);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(215, 22);
            this.txtAra.TabIndex = 1;
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.Location = new System.Drawing.Point(560, 12);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(207, 55);
            this.btnNotEkle.TabIndex = 2;
            this.btnNotEkle.Text = "Not Ekle";
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 354);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // FrmSinavNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNotEkle);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblOgrenciEkle);
            this.Name = "FrmSinavNotlar";
            this.Text = "Notlar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrenciEkle;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnNotEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}