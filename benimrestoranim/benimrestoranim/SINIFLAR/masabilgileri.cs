using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace benimrestoranim.SINIFLAR
{
    class masabilgileri
    {
        private int toplamfiyat;
        private string masano;
        private int kisisayisi;
        private string masakonumu;

        public int Toplamfiyat
        {
            get
            {
                return toplamfiyat;
            }
            set
            {
                toplamfiyat = value;
            }
        }
        public string Masano
        {
            get
            {
                return masano;
            }
            set
            {
                masano = value;
            }
        }

        public int Kisisayisi
        {
            get
            {
                return kisisayisi;
            }
            set
            {
                kisisayisi = value;
            }
        }

        public string Masakonumu
        {
            get
            {
                return masakonumu;
            }
            set
            {
                masakonumu = value;
            }
        }

        public static string dosyaMasabilgileri = "masabilgileri.xml";
        public DataSet dsMasabilgileri = new DataSet("MasaBilgileriListesi");
        public DataTable dtMasabilgileri = new DataTable("Masa Bilgileri");

        public masabilgileri() { DataSetOlustur(); }

        public masabilgileri(int toplamfiyat, string masano, int kisisayisi, string masakonumu)
        {
            this.toplamfiyat = toplamfiyat;
            this.masano = masano;
            this.kisisayisi = kisisayisi;
            this.masakonumu = masakonumu;
            DataSetOlustur();
        }
        private void DataSetOlustur()
        {
            if (System.IO.File.Exists(dosyaMasabilgileri))
            {
                dsMasabilgileri.ReadXml(dosyaMasabilgileri);
                dtMasabilgileri = dsMasabilgileri.Tables[0];
            }
            else
            {
                dtMasabilgileri.Columns.Add("TOPLAM FİYAT");
                dtMasabilgileri.Columns.Add("MASA NUMARASI");
                dtMasabilgileri.Columns.Add("KİŞİ SAYISI");
                dtMasabilgileri.Columns.Add("MASA KONUMU");
                dsMasabilgileri.Tables.Add(dtMasabilgileri);
                dsMasabilgileri.WriteXml(dosyaMasabilgileri, XmlWriteMode.WriteSchema);
            }
        }
        public DataTable MasaBilgileriListesiGetir()
        {
            return dtMasabilgileri;
        }
        public void MasaBilgileriKaydet()
        {
            DataRow row = dtMasabilgileri.NewRow();

            row["TOPLAM FİYAT"] = toplamfiyat;
            row["MASA NUMARASI"] = masano;
            row["KİŞİ SAYISI"] = kisisayisi;
            row["MASA KONUMU"] = masakonumu;
            dtMasabilgileri.Rows.Add(row);
            dsMasabilgileri.WriteXml(dosyaMasabilgileri, XmlWriteMode.WriteSchema);
        }
        public void MasaBilgileriKaydet(DataTable dt)
        {
            dsMasabilgileri.Tables.Clear();
            dtMasabilgileri = dt.Copy();
            dsMasabilgileri.Tables.Add(dtMasabilgileri);
            dsMasabilgileri.WriteXml(dosyaMasabilgileri, XmlWriteMode.WriteSchema);
        }










































    }
}
