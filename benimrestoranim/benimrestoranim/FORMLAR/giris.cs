using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace benimrestoranim
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kad = "garson";
            int ksifre = 123;
            if (textBox1.Text == kad && textBox2.Text == Convert.ToString(ksifre))
            {
                Program.yonetici = false;
                garson f = new garson();
                this.Hide();
                f.ShowDialog();
            }
            String ad = "yonetici";
            int sifre = 123;
            if(textBox1.Text == ad && textBox2.Text == Convert.ToString(sifre))
            {
                Program.yonetici = true;
                yonetici f = new yonetici();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
