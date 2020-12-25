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
    public partial class masabilgileriform : Form
    {
        public masabilgileriform()
        {
            InitializeComponent();
        }

        private void btn_listelemasa_Click(object sender, EventArgs e)
        {
                Listele();
        }

        private void masaacform_Load(object sender, EventArgs e)
        {

        }

        public void dataGridView_masaac_kapat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_msac_Click(object sender, EventArgs e)
        {
            if(  txt_toplamfiyat.Text!=""&& txt_kisisayisi.Text!=""&& cmb_masano.Text!=""&& cmb_masakonum.Text != "")
            {
                masabilgileri MasaBilgiler = new masabilgileri();
               
                MasaBilgiler.Toplamfiyat = (Convert.ToInt32(txt_toplamfiyat.Text));
                MasaBilgiler.Kisisayisi = (Convert.ToInt32(txt_kisisayisi.Text));
                MasaBilgiler.Masano = cmb_masano.Text;
                MasaBilgiler.Masakonumu = cmb_masakonum.Text;

                MasaBilgiler.MasaBilgileriKaydet();
                Listele();
                MessageBox.Show("MASA AÇILDI");

            }
            else
            {
                MessageBox.Show("TÜM ALANLARI DOLDURUNUZ");
            }
        }

        private void btn_masakapat_Click(object sender, EventArgs e)
        {
            if (dataGridView_masaac_kapat.CurrentRow.Cells[0].Value != null)
                dataGridView_masaac_kapat.Rows.RemoveAt(dataGridView_masaac_kapat.CurrentRow.Index);

            masabilgileri MasaBilgileri = new masabilgileri();
            DataTable dt = (DataTable)dataGridView_masaac_kapat.DataSource;

            MasaBilgileri.MasaBilgileriKaydet(dt);

            MessageBox.Show("MASA KAPATILDI");
        }
        private void Listele()
        {
            masabilgileri MasaBilgileri = new masabilgileri();
            DataTable dt = MasaBilgileri.MasaBilgileriListesiGetir();
            dataGridView_masaac_kapat.DataSource = dt;
        }

        private void txt_urunad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_anamenü_Click(object sender, EventArgs e)
        {
            if (Program.yonetici == true)
            {
                yoneticiform m = new yoneticiform();
                m.ShowDialog();
            }
            else
            {
                garsonform m = new garsonform();
                m.ShowDialog();
            }

            this.Hide();
        }
    }
}
