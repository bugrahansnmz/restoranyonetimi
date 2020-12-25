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
    public partial class icecekform : Form
    {
        public icecekform()
        {
            InitializeComponent();
        }

        private void btn_anamenü_Click(object sender, EventArgs e)
        {
            yoneticiform MENU = new yoneticiform();
            MENU.Show();
            this.Hide();
        }

        private void btn_icecekaydet_Click(object sender, EventArgs e)
        {
            if (txt_icecekisim.Text!="" && txt_icecekfiyat.Text!="" && txt_icecekadet.Text!= "" && cmb_sikma.Text!="" && cmb_sicakicecekler.Text!= "" && cmb_sogukicecekler.Text!= "")
            {
                icecek icecekler = new icecek();

                icecekler.Isim = txt_icecekisim.Text;
                icecekler.Fiyat = (Convert.ToInt32(txt_icecekfiyat.Text));
                icecekler.Adet = (Convert.ToInt32(txt_icecekadet.Text));
                icecekler.Sikmaicecekler = cmb_sikma.Text;
                icecekler.Sicakicecekler = cmb_sicakicecekler.Text;
                icecekler.Sogukicecekler = cmb_sogukicecekler.Text;
                icecekler.Kaydet();

                Listele();
                MessageBox.Show("İÇECEK EKLENDİ");
  }
            else
            {
                MessageBox.Show("TÜM ALANLARI DOLDURUNUZ");
            }
        }

        private void btn_iceceksil_Click(object sender, EventArgs e)
        {
           

            if (dataGridIcecek.CurrentRow.Cells[0].Value != null)
                dataGridIcecek.Rows.RemoveAt(dataGridIcecek.CurrentRow.Index);
           

            icecek icecekler = new icecek();

            DataTable dt = (DataTable)dataGridIcecek.DataSource;
            icecekler.Kaydet(dt);
            MessageBox.Show("İÇECEK SİLİNDİ");
        }
        private void Listele()
        {
            icecek icecekler = new icecek();

            DataTable dt = icecekler.ListesiGetir();
            dataGridIcecek.DataSource = dt;


        }

        private void icecekform_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_icecekliste_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridIcecek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridIcecek.Rows[index];
            txt_icecekisim.Text = selectedRow.Cells[0].Value.ToString();
            txt_icecekfiyat.Text = selectedRow.Cells[1].Value.ToString();
            txt_icecekadet.Text = selectedRow.Cells[2].Value.ToString();
            cmb_sikma.Text = selectedRow.Cells[3].Value.ToString();
            cmb_sicakicecekler.Text = selectedRow.Cells[4].Value.ToString();
            cmb_sogukicecekler.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {

            icecek Icecek = new icecek();
            object a = dataGridIcecek.SelectedRows[0].Index;
            Icecek.Sil(a);

            icecek icecek = new icecek();
            txt_icecekisim.Text = Convert.ToString(dataGridIcecek.SelectedRows[0].Cells[0].Value);
            txt_icecekfiyat.Text = Convert.ToString(dataGridIcecek.SelectedRows[0].Cells[1].Value);
            txt_icecekadet.Text = Convert.ToString(dataGridIcecek.SelectedRows[0].Cells[2].Value);
            cmb_sicakicecekler.Text = Convert.ToString(dataGridIcecek.SelectedRows[0].Cells[3].Value);
            cmb_sikma.Text = Convert.ToString(dataGridIcecek.SelectedRows[0].Cells[4].Value);
            cmb_sogukicecekler.Text = Convert.ToString(dataGridIcecek.SelectedRows[0].Cells[5].Value);




        }

        private void cmb_sogukicecekler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

