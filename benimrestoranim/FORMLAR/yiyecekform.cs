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

namespace restaurantyonetimiss
{
    public partial class yiyecekform : Form
    {
        public yiyecekform()
        {
            InitializeComponent();
        }

        private void btn_yiyecekkaydet_Click(object sender, EventArgs e)
        {

        }

        private void yiyecekform_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_iceckaydet_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_yiyecekaydet_Click(object sender, EventArgs e)
        {
            if(txt_yiyecekisim.Text!="" && txt_yiyecekfiyat.Text!="" && txt_yiyecekadet.Text!="" && cmb_evyemek.Text!="" && cmb_vejyiyecek.Text!="" )
            {
                yiyecek yiyecekler = new yiyecek();
                yiyecekler.Isim = txt_yiyecekisim.Text;
                yiyecekler.Fiyat = (Convert.ToInt32(txt_yiyecekfiyat.Text));
                yiyecekler.Adet = (Convert.ToInt32(txt_yiyecekadet.Text));
                yiyecekler.Evyemekleri = cmb_evyemek.Text;
                yiyecekler.Vejeteryanyiyecekler = cmb_vejyiyecek.Text;
                yiyecekler.Kaydet();

                Listele();
                MessageBox.Show("YİYECEK EKLENDİ");
            }
            else
            {
                MessageBox.Show("TÜM ALANLARI DOLDURUNUZ");
            }
        }

        private void btn_yiyecekliste_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_yiyeceksil_Click(object sender, EventArgs e)
        {
           
            if (dataGridyiyecek.CurrentRow.Cells[0].Value != null)
                dataGridyiyecek.Rows.RemoveAt(dataGridyiyecek.CurrentRow.Index);

            yiyecek yiyecekler = new yiyecek();
            DataTable dt = (DataTable)dataGridyiyecek.DataSource;
            yiyecekler.Kaydet(dt);
            MessageBox.Show("Yiyecek silindi");
        }
        private void Listele()
        {
            yiyecek yiyecekler = new yiyecek();
            DataTable dt = yiyecekler.ListesiGetir();
            dataGridyiyecek.DataSource = dt;
        }

        private void btn_anamenü_Click(object sender, EventArgs e)
        {
            yoneticiform MENU = new yoneticiform();
            MENU.Show();
            this.Hide();
        }

        private void dataGridyiyecek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow =dataGridyiyecek.Rows[index];
            txt_yiyecekisim.Text = selectedRow.Cells[0].Value.ToString();
            txt_yiyecekfiyat.Text = selectedRow.Cells[1].Value.ToString();
            txt_yiyecekadet.Text = selectedRow.Cells[2].Value.ToString();
            cmb_evyemek.Text = selectedRow.Cells[3].Value.ToString();
            cmb_vejyiyecek.Text = selectedRow.Cells[4].Value.ToString();
            
        }

        private void btn_yiyecekguncelle_Click(object sender, EventArgs e)
        {

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            yiyecek Yiyecek = new yiyecek();
            object a = dataGridyiyecek.SelectedRows[0].Index;
            Yiyecek.Sil(a);

            yiyecek yiyecek = new yiyecek();
            txt_yiyecekisim.Text = Convert.ToString(dataGridyiyecek.SelectedRows[0].Cells[0].Value);
            txt_yiyecekfiyat.Text = Convert.ToString(dataGridyiyecek.SelectedRows[0].Cells[1].Value);
            txt_yiyecekadet.Text = Convert.ToString(dataGridyiyecek.SelectedRows[0].Cells[2].Value);
            cmb_evyemek.Text = Convert.ToString(dataGridyiyecek.SelectedRows[0].Cells[3].Value);
            cmb_vejyiyecek.Text = Convert.ToString(dataGridyiyecek.SelectedRows[0].Cells[4].Value);

        }
    }
}
