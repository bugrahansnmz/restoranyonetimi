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
using System.Xml.Linq;

namespace restaurantyonetimiss.FORMLAR
{
    public partial class tatlilarform : Form
    {
        public tatlilarform()
        {
            InitializeComponent();
        }

        private void btn_anamenü_Click(object sender, EventArgs e)
        {
            yoneticiform MENU = new yoneticiform();
            MENU.Show();
            this.Hide();
        }

        private void btn_tatlisil_Click(object sender, EventArgs e)
        {
           

            if (dataGridtatli.CurrentRow.Cells[0].Value != null)
                dataGridtatli.Rows.RemoveAt(dataGridtatli.CurrentRow.Index);

            tatli tatlilar = new tatli();
            DataTable dt = (DataTable)dataGridtatli.DataSource;
            tatlilar.Kaydet(dt);
            MessageBox.Show("Tatli silindi");
        }
        private void Listele()
        {
            tatli tatli = new tatli();
            DataTable dt = tatli.ListesiGetir();
            dataGridtatli.DataSource = dt;
        }

        private void btn_tatlikaydet_Click(object sender, EventArgs e)
        {

            if (txt_tatliisim.Text != "" && txt_tatlifiyat.Text != "" && txt_tatliadet.Text != "" && cmb_serbetlitatli.Text != "" && cmb_sutlutatli.Text != "")
            {
                tatli tatlilar = new tatli();

                tatlilar.Isim = txt_tatliisim.Text;
                tatlilar.Fiyat = (Convert.ToInt32(txt_tatlifiyat.Text));
                tatlilar.Adet = (Convert.ToInt32(txt_tatliadet.Text));
                tatlilar.Serbetlitatlilar = cmb_serbetlitatli.Text;
                tatlilar.Sutlutatlilar = cmb_sutlutatli.Text;

                tatlilar.Kaydet();

                Listele();
                MessageBox.Show("TATLI EKLENDİ");
            }
            else
            {
                MessageBox.Show("TÜM ALANLARI DOLDURUNUZ");
            }
        }

        private void btn_tatliguncelle_Click(object sender, EventArgs e)
        {



        }

        private void btn_tatlilistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridtatli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridtatli.Rows[index];
            txt_tatliisim.Text = selectedRow.Cells[0].Value.ToString();
            txt_tatlifiyat.Text = selectedRow.Cells[1].Value.ToString();
            txt_tatliadet.Text = selectedRow.Cells[2].Value.ToString();
            cmb_serbetlitatli.Text = selectedRow.Cells[3].Value.ToString();
            cmb_sutlutatli.Text = selectedRow.Cells[4].Value.ToString();
        }

        private void tatlilarform_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            tatli Tatli = new tatli();
            object a = dataGridtatli.SelectedRows[0].Index;
            Tatli.Sil(a);

            tatli tatli = new tatli();
            txt_tatliisim.Text = Convert.ToString(dataGridtatli.SelectedRows[0].Cells[0].Value);
            txt_tatlifiyat.Text = Convert.ToString(dataGridtatli.SelectedRows[0].Cells[1].Value);
           txt_tatliadet.Text = Convert.ToString(dataGridtatli.SelectedRows[0].Cells[2].Value);
            cmb_serbetlitatli.Text = Convert.ToString(dataGridtatli.SelectedRows[0].Cells[3].Value);
            cmb_sutlutatli.Text = Convert.ToString(dataGridtatli.SelectedRows[0].Cells[4].Value);
            
        }
    }

}

