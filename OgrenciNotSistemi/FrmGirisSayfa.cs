using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotSistemi
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenci_islemleri fr = new FrmOgrenci_islemleri();

            this.Hide();      
            fr.ShowDialog();  
            this.Show();      
        }

        private void btnNotlar_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar fr = new FrmSinavNotlar();
            fr.Show();
        }

        private void btnDersler_Click(object sender, EventArgs e)
        {
            FrmDersler fr = new FrmDersler();
            fr.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            FrmRaporlar fr = new FrmRaporlar();
            fr.Show();
        }
    }
}
