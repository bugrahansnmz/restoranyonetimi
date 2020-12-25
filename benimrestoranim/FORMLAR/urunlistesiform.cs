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

namespace restaurantyonetimiss.FORMLAR
{
    public partial class urunlistesiform : Form
    {
        public urunlistesiform()

        {
            InitializeComponent();
        }


       
    
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void urunlistesiform_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.yonetici == true)
            {
                yoneticiform MENU = new yoneticiform();
                MENU.Show();
            }
            else
            {
                garsonform MENU = new garsonform();
                MENU.Show();
            }

            this.Hide();
        }
    

        private void txtbtnara_Click(object sender, EventArgs e)
        {
           masabilgileri masabilgileri= new masabilgileri();
          DataTable dt = masabilgileri.MasaArama(cmbmasanosec.Text);
            dataGridView1.DataSource = dt;

            if (dt == null)
            {
                MessageBox.Show("MASA NUMARASI BULUNAMADI", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            masabilgileri masabilgileri = new masabilgileri();
            DataTable dt = (DataTable)dataGridView1.DataSource;
            masabilgileri.MasaBilgileriKaydet(dt);
            MessageBox.Show("MASA BİLGİLERİ SİLİNDİ");
        }

        private void cmbmasanosec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

