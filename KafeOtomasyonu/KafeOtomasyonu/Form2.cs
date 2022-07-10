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
    public partial class Form2 : Form
    {
        public string masa_adi = string.Empty;
        int tutar;
        public Form2()
        {
            InitializeComponent();
            label1.Text = masa_adi;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            label1.Text = masa_adi;
            tutar = 0;
        }
        
        private void sandvic_cb_CheckedChanged(object sender, EventArgs e)
        {
            if(sandvic_cb.Checked)
            {
                tutar = tutar + 10;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else 
            {
                tutar = tutar - 10;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void hamburger_cb_CheckedChanged(object sender, EventArgs e)
        {
            if(hamburger_cb.Checked)
            {
                tutar = tutar + 12;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            { 
                tutar = tutar - 12;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void pizza_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (pizza_cb.Checked)
            {
                tutar = tutar + 25;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 25;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void tost_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (tost_cb.Checked)
            {
                tutar = tutar + 6;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 6;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void patates_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (patates_cb.Checked)
            {
                tutar = tutar + 8;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 8;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void makarna_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (makarna_cb.Checked)
            {
                tutar = tutar + 5;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 5;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void cay_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cay_cb.Checked)
            {
                tutar = tutar + 2;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 2;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void nescafe_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (nescafe_cb.Checked)
            {
                tutar = tutar + 2;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 2;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void ihlamur_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (ihlamur_cb.Checked)
            {
                tutar = tutar + 4;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 4;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void kusburnu_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (kusburnu_cb.Checked)
            {
                tutar = tutar + 4;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 4;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void cappuccino_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cappuccino_cb.Checked)
            {
                tutar = tutar + 13;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 13;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void kola_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (kola_cb.Checked)
            {
                tutar = tutar + 10;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 10;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void fanta_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (fanta_cb.Checked)
            {
                tutar = tutar + 7;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 7;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void gazoz_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (gazoz_cb.Checked)
            {
                tutar = tutar + 6;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 6;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void soda_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (soda_cb.Checked)
            {
                tutar = tutar + 3;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 3;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void ayran_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (ayran_cb.Checked)
            {
                tutar = tutar + 5;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 5;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void supangle_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (supangle_cb.Checked)
            {
                tutar = tutar + 12;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 12;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void waffle_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (waffle_cb.Checked)
            {
                tutar = tutar + 18;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 18;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void pasta_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (pasta_cb.Checked)
            {
                tutar = tutar + 22;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 22;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void kek_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (kek_cb.Checked)
            {
                tutar = tutar + 14;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 14;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void fondu_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (fondu_cb.Checked)
            {
                tutar = tutar + 27;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 27;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void ekler_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (ekler_cb.Checked)
            {
                tutar = tutar + 2;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 2;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void browni_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (browni_cb.Checked)
            {
                tutar = tutar + 7;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 7;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void baklava_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (baklava_cb.Checked)
            {
                tutar = tutar + 16;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 16;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void kadayif_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (kadayif_cb.Checked)
            {
                tutar = tutar + 16;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
            else
            {
                tutar = tutar - 16;
                tutar_lbl.Text = Convert.ToString(tutar);
            }
        }

        private void odeme_btn_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            string masa_sayisi = masa_adi;
            frm3.masa_adi = masa_sayisi;
            frm3.fiyat = Convert.ToString (tutar);
            frm3.Show();
            this.Hide();
        }
    }
}
