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
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            masabilgileri h = new masabilgileri();
            this.Hide();
            h.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunlistesi n = new urunlistesi();
            this.Hide();
            n.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yiyecek n = new yiyecek();
            this.Hide();
            n.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            icecek i = new icecek();
            this.Hide();
            i.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tatlilar t = new tatlilar();
            this.Hide();
            t.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            yiyecek y = new yiyecek();
            this.Hide();
            y.ShowDialog();

        }
    }
}
