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
    public partial class garson : Form
    {
        public garson()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            masabilgileri h = new masabilgileri();
            h.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunlistesi n = new urunlistesi();
            this.Hide();
            n.ShowDialog();
        }
    }
}
