using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace benimrestoranim.SINIFLAR
{
    class yiyecek : stok, Istok
    {

        private string vejeteryanyiyecekeler;
        private string evyemekleri;

        public string Vejeteryanyiyecekler
        {
            get
            {
                return vejeteryanyiyecekeler;
            }
            set
            {
                vejeteryanyiyecekeler = value;
            }
        }
        public string Evyemekleri
        {
            get
            {
                return evyemekleri;
            }
            set
            {
                evyemekleri = value;
            }
        }
        public static string dosyayol = "yiyecek.xml";

        public DataSet dsYiyecek = new DataSet("YiyecekListesi");
        public DataTable dtYiyecek = new DataTable("Yiyecekler");

        public yiyecek() { dtOlustur(); }

        public yiyecek(string vejeteryanyiyecekler, string evyemekleri)
        {
            this.Isim = Isim;
            this.Fiyat = Fiyat;
            this.Adet = Adet;
            this.vejeteryanyiyecekeler = vejeteryanyiyecekler;
            this.evyemekleri = evyemekleri;
        }

        public void dtOlustur()
        {
            if (System.IO.File.Exists(dosyayol))
            {
                dsYiyecek.ReadXml(dosyayol);
                dtYiyecek = dsYiyecek.Tables[0];
            }
            else
            {
                dtYiyecek.Columns.Add("ISIM");
                dtYiyecek.Columns.Add("FIYAT");
                dtYiyecek.Columns.Add("ADET");
                dtYiyecek.Columns.Add("EVYEMEKLERI");
                dtYiyecek.Columns.Add("VEJETERYANYIYECEKLER");

                dsYiyecek.Tables.Add(dtYiyecek);
                dtYiyecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
            }

        }
        public override DataTable ListesiGetir()
        {
            return dtYiyecek;
        }
        public override void Kaydet()
        {
            DataRow row = dtYiyecek.NewRow();
            row["İSİM"] = Isim;
            row["FİYAT"] = Fiyat;
            row["ADET"] = Adet;
            row["VEJETERYAN YİYECEKLER"] = vejeteryanyiyecekeler;
            row["EV YEMEKLERİ"] = evyemekleri;

            dtYiyecek.Rows.Add(row);
            dsYiyecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }
        public void Kaydet(DataTable dt)
        {
            dsYiyecek.Tables.Clear();
            dtYiyecek = dt.Copy();
            dsYiyecek.Tables.Add(dtYiyecek);
            dsYiyecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }
        public override void Guncelle()
        {
            DataRow row = dtYiyecek.NewRow();
            row["İSİM"] = Isim;
            row["FİYAT"] = Fiyat;
            row["ADET"] = Adet;
            row["VEJETERYAN YİYECEKLER"] = vejeteryanyiyecekeler;
            row["EV YEMEKLERİ"] = evyemekleri;
            dtYiyecek.Rows.Add(row);
            dsYiyecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }
        public override void Sil(object a)
        {
            dtYiyecek.Rows.RemoveAt(Convert.ToInt32(a));
            dsYiyecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }





    }
}
