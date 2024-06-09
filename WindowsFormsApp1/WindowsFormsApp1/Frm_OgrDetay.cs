using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Frm_OgrDetay : Form
    {
        public Frm_OgrDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BC3LOP2\SELM;Initial Catalog=NotKayıt;Integrated Security=True;");
        //Data Source=DESKTOP-BC3LOP2\SELM;Initial Catalog=NotKayıt;Integrated Security=True;Trust Server Certificate=True
        public string numara;
        private void Frm_OgrDetay_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLDERS where OGRNUMARA =@p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lbladsoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblsınav1.Text = dr[4].ToString();
                lblsınav2.Text= dr[5].ToString();
                lblsınav3.Text = dr[6].ToString();
                lblortalama.Text = dr[7].ToString();
                lbldurum.Text = dr[8].ToString();
            }
            baglanti.Close();
            

        }
    }
}
