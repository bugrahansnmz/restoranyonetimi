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
    public partial class masabilgileri : Form
    {
        public masabilgileri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Program.yonetici == true)
            {
                yonetici m = new yonetici();
                m.ShowDialog();
            }
            else
            {
                garson m = new garson();
                m.ShowDialog();
            }
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
