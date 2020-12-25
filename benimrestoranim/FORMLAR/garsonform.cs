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
    public partial class garsonform : Form
    {
        public garsonform()
        {
            InitializeComponent();
        }

        private void btn_masaackapat_Click(object sender, EventArgs e)
        {

        }

        private void garsonform_Load(object sender, EventArgs e)
        {

        }

        private void btn_masabilgileri_Click(object sender, EventArgs e)
        {
            masabilgileriform C = new masabilgileriform();
            C.Show();
            this.Hide();

        }

        private void btn_masahesabi_Click(object sender, EventArgs e)
        {
            urunlistesiform u = new urunlistesiform();
            u.Show();
            this.Hide();

        }
    }
}
