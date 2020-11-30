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
    public partial class tatlilar : Form
    {
        public tatlilar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            yonetici k = new yonetici();
            k.ShowDialog();
            this.Hide();
        }
    }
}
