using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace restaurantyonetimiss.SINIFLAR
{
    
    class yiyecek : stok,IStok
    {
      
        private string vejeteryanyiyecekler;
        private string evyemekleri;

        public string Vejeteryanyiyecekler
        {
            get
            {
                return vejeteryanyiyecekler;
            }
            set
            {
                vejeteryanyiyecekler = value;
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
        public DataTable dataTableYiyecek = new DataTable("Yiyecekler");

        public yiyecek() { dtOlustur(); }

        public yiyecek(string vejeteryanyiyecekler, string evyemekleri)
        {
            this.Isim = Isim;
            this.Fiyat = Fiyat;
            this.Adet = Adet;
            this.vejeteryanyiyecekler = vejeteryanyiyecekler;
            this.evyemekleri = evyemekleri;
        }
    
        public void dtOlustur()
        {
            if (System.IO.File.Exists(dosyayol))
            {
                dsYiyecek.ReadXml(dosyayol);
                dataTableYiyecek = dsYiyecek.Tables[0];
            }
            else
            {
                dataTableYiyecek.Columns.Add("ISIM");
                dataTableYiyecek.Columns.Add("FIYAT"); 
                dataTableYiyecek.Columns.Add("ADET");
                dataTableYiyecek.Columns.Add("EVYEMEKLERI"); 
                dataTableYiyecek.Columns.Add("VEJETERYANYIYECEKLER");

                dsYiyecek.Tables.Add(dataTableYiyecek);
                dataTableYiyecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
                }

        }
        public override  DataTable ListesiGetir()
        {
            return dataTableYiyecek; 
        }
        public  override void Kaydet()
        {

            DataRow row = dataTableYiyecek.NewRow();
            row["İSİM"] = Isim;
            row["FİYAT"] = Fiyat;
            row["ADET"] = Adet;
            row["VEJETERYAN YİYECEKLER"] = vejeteryanyiyecekler;
            row["EV YEMEKLERİ"] = evyemekleri;

            dataTableYiyecek.Rows.Add(row);
            dsYiyecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);

        }
public void Kaydet(DataTable dt)
        {
            dsYiyecek.Tables.Clear();
            dataTableYiyecek = dt.Copy();
            dsYiyecek.Tables.Add(dataTableYiyecek);
            dsYiyecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);

        }
        public override void Guncelle()
        {
            DataRow row = dataTableYiyecek.NewRow();
            row["İSİM"] = Isim;
            row["FİYAT"] = Fiyat;
            row["ADET"] = Adet;
            row["VEJETERYAN YİYECEKLER"] = vejeteryanyiyecekler;
            row["EV YEMEKLERİ"] = evyemekleri;
           dataTableYiyecek.Rows.Add(row);
            dsYiyecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }

        public override void Sil(object a)
        {

            dataTableYiyecek.Rows.RemoveAt(Convert.ToInt32(a));
            dsYiyecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }



    }
}