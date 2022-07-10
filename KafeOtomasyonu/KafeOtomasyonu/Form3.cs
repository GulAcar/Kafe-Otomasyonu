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

namespace KafeOtomasyonu
{
    public partial class Form3 : Form
    {
        public string masa_adi = string.Empty;
        public string fiyat;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            basarili_txt.Hide();
            ilerleme_pb.Hide();
            
        }

        private void kkodeme_btn_Click(object sender, EventArgs e)
        {
            basarili_txt.Show();
            ilerleme_pb.Show();
            kkodeme_btn.Hide();
            nakit_btn.Hide();
            giris_lbl.Hide();
            kk_txt.Hide();
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 10;
            ilerleme_pb.Maximum = 300;
            SqlConnection conn = new SqlConnection("server=DESKTOP-8G3QPE9; Initial Catalog=KafeOtomasyonu;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            if (string.IsNullOrWhiteSpace(kk_txt.Text))
            { }
            else
            {
                cmd.CommandText = "insert into musteri (masa_no,kredi_kart,odeme_tarihi,fiyat) values ('" + masa_adi + "','" + kk_txt.Text + "','" + DateTime.Now.ToLongDateString() + "','" + fiyat + "')";
            }
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void nakit_btn_Click(object sender, EventArgs e)
        {
            basarili_txt.Show();
            ilerleme_pb.Show();
            kkodeme_btn.Hide();
            nakit_btn.Hide();
            giris_lbl.Hide();
            kk_txt.Hide();
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 100;
            ilerleme_pb.Maximum = 50;
        }
        int deger = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            deger++;
            ilerleme_pb.Value++ ;
            if (deger == 50)
            {
                timer1.Stop();
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
        }
    }
}
