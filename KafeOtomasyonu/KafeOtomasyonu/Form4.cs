using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeOtomasyonu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void giris_btn_Click(object sender, EventArgs e)
        {Form5 frm5 = new Form5();
            if(kullanici_txt.Text=="admin"&&sifre_txt.Text=="admin")
            {
                
                frm5.Show();
                this.Hide();
            }
            
            frm5.Show();
            this.Hide();
        }
    }
}
