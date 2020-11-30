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
    public partial class urunlistesi : Form
    {
        public urunlistesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Program.yonetici == true)
            {
                yonetici r = new yonetici();
                r.ShowDialog();
            }
            else
            {
                garson d = new garson();
                d.ShowDialog();
            }
            this.Hide();
        }
    }
}
