using restaurantyonetimiss.SINIFLAR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
namespace restaurantyonetimiss
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();

        }





        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            garson g = new garson();
            g.ad = "garson";
            g.sifre = 123;
            if (txt_kullaniciadi.Text == g.ad && txt_sifre.Text == Convert.ToString(g.sifre))
            {
                Program.yonetici = false;
                garsonform f = new garsonform();
                this.Hide();
                f.ShowDialog();
            }
            yonetici y = new yonetici();
            y.ad = "yonetici";
            y.sifre = 123;
            if (txt_kullaniciadi.Text == y.ad && txt_sifre.Text == Convert.ToString(y.sifre))
            {
                Program.yonetici = true;
                yoneticiform f = new yoneticiform();
                this.Hide();
                f.ShowDialog();


            }
            
           

        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void txt_kullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }
    }










    }




      

