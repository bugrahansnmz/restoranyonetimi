using restaurantyonetimiss.FORMLAR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantyonetimiss
{
    public partial class yoneticiform : Form
    {
        public yoneticiform()
        {
            InitializeComponent();
        }

        private void yoneticiform_Load(object sender, EventArgs e)
        {

        }

        private void btn_yiyecek_Click(object sender, EventArgs e)
        {
            yiyecekform Y = new yiyecekform();
            Y.Show();
            this.Hide();



        }

        private void btn_icecek_Click(object sender, EventArgs e)
        {
            icecekform I = new icecekform();
            I.Show();
            this.Hide();

        }

        private void btn_tatli_Click(object sender, EventArgs e)
        {
            tatlilarform T = new tatlilarform();
            T.Show();
            this.Hide();
        }

        private void btn_masahesabi_Click(object sender, EventArgs e)
        {

            urunlistesiform u = new urunlistesiform();
            u.Show();
            this.Hide();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_tatlilar_Click(object sender, EventArgs e)
        {

        }

        private void btn_masabilgileri_Click(object sender, EventArgs e)
        {

            masabilgileriform C = new masabilgileriform();
            C.Show();
            this.Hide();


            
        }

        private void btn_masahesabi_Click_1(object sender, EventArgs e)
        {
            urunlistesiform u = new urunlistesiform();
            u.Show();
            this.Hide();
        }

        private void btn_masabilgileri_Click_1(object sender, EventArgs e)
        {
            masabilgileriform C = new masabilgileriform();
            C.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

