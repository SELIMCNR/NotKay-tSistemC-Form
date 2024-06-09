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
    public partial class Frm_ogretmen : Form
    {
        public Frm_ogretmen()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BC3LOP2\SELM;Initial Catalog=NotKayıt;Integrated Security=True;");
        private void Frm_ogretmen_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'notKayıtDataSet.TBLDERS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLDERSTableAdapter.Fill(this.notKayıtDataSet.TBLDERS);
            baglanti.Open();
            SqlCommand gecenkomut = new SqlCommand("Select Count(*) From TBLDERS Where DURUM=1", baglanti);

            SqlCommand kalankomut = new SqlCommand("Select Count(*) From TBLDERS Where DURUM=0", baglanti);

            int gecen = (int)gecenkomut.ExecuteScalar();

            int kalan = (int)kalankomut.ExecuteScalar();
            baglanti.Close();
            Lbl_derstengeçen.Text = gecen.ToString();

            Lbl_derstenkalan.Text = kalan.ToString();
        }

        private void Btn_ogrKaydet_Click(object sender, EventArgs e)
        {
            if(mskOgrNumara.Text!=null && Txt_Ad.Text!=null && Txt_Soyad.Text != null)
            {

                s1 = Convert.ToDouble(Txt_sınav1.Text);
                s2 = Convert.ToDouble(Txt_sınav2.Text);
                s3 = Convert.ToDouble(Txt_sınav3.Text);

                ortalama = (s1 + s2 + s3) / 3;
                if (ortalama >= 50)
                {
                    durum = "True";

                }
                else
                {
                    durum = "False";
                }
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLDERS(OGRNUMARA,OGRAD,OGRSOYAD,OGRS1,OGRS2,OGRS3,ORTALAMA,DURUM) values" +
                    "(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", baglanti);
                komut.Parameters.AddWithValue("@P1", mskOgrNumara.Text);
                komut.Parameters.AddWithValue("@P2", Txt_Ad.Text);
                komut.Parameters.AddWithValue("@P3", Txt_Soyad.Text);
                komut.Parameters.AddWithValue("@P4", Txt_sınav1.Text);
                komut.Parameters.AddWithValue("@P5", Txt_sınav2.Text);
                komut.Parameters.AddWithValue("@P6", Txt_sınav3.Text);
                komut.Parameters.AddWithValue("@P7", ortalama.ToString());
                komut.Parameters.AddWithValue("@P8", durum);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci sisteme eklendi");
                this.tBLDERSTableAdapter.Fill(this.notKayıtDataSet.TBLDERS);
            }
          

        }
        double ortalama, s1, s2, s3;
        string durum;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            mskOgrNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Txt_Ad.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Txt_Soyad.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Txt_sınav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();   
            Txt_sınav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString(); 
            Txt_sınav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString() ;
        


            s1 = Convert.ToDouble(Txt_sınav1.Text);
            s2 = Convert.ToDouble(Txt_sınav2.Text);
            s3 = Convert.ToDouble(Txt_sınav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            Lbl_ortalama.Text = ortalama.ToString();
          
        }

       
        private void Btn_güncelle_Click(object sender, EventArgs e)
        {
        

            if (ortalama >= 50)
            {
                durum = "True";
                
            }
            else
            {
                durum = "False";
            }
          
    
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1=@P1,OGRS2=@P2,OGRS3=@P3,ORTALAMA=@P4,DURUM=@P5  " +
                "WHERE OGRNUMARA =@P6",baglanti);
            komut.Parameters.AddWithValue("@P1", Txt_sınav1.Text);
            komut.Parameters.AddWithValue("@P2", Txt_sınav2.Text);
            komut.Parameters.AddWithValue("@P3", Txt_sınav3.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse( ortalama.ToString()));
            komut.Parameters.AddWithValue("@P5", durum);
            komut.Parameters.AddWithValue("@P6", mskOgrNumara.Text);
            komut.ExecuteNonQuery();
          
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları güncellendi");
            this.tBLDERSTableAdapter.Fill(this.notKayıtDataSet.TBLDERS);

        }
    }
}
