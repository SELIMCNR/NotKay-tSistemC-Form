using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_Giris : Form
    {
        public Frm_Giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ogr_giris(object sender, EventArgs e)
        {
            if (mskNumara.Text != null)
            {
                Frm_OgrDetay frm = new Frm_OgrDetay();
                frm.numara = mskNumara.Text;
                frm.Show();
            }
        ;

        }

        private void msk_ogretmensifre_TextChanged(object sender, EventArgs e)
        {
           if(msk_ogretmensifre.Text == "1111")
            {
                Frm_ogretmen frm = new Frm_ogretmen();
              
                frm.Show();
            }
        }
    }
}
