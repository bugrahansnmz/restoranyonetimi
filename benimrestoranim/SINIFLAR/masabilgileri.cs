using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantyonetimiss.SINIFLAR
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


        public string Masano {
            get {
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
        public DataTable dataTableMasabilgileri = new DataTable("Masa Bilgileri");

        public masabilgileri()
        {
            DataSetOlustur();

        }
        public masabilgileri ( int toplamfiyat, string masano, int kisisayisi, string masakonumu)
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
                dataTableMasabilgileri = dsMasabilgileri.Tables[0];

            }
            else
            {
                
                dataTableMasabilgileri.Columns.Add("TOPLAM FİYAT");
                dataTableMasabilgileri.Columns.Add("MASA NUMARASI");
                dataTableMasabilgileri.Columns.Add("KİŞİ SAYISI");
                dataTableMasabilgileri.Columns.Add("MASA KONUMU");
                dsMasabilgileri.Tables.Add(dataTableMasabilgileri);
                dsMasabilgileri.WriteXml(dosyaMasabilgileri, XmlWriteMode.WriteSchema);

            }
        }
        public DataTable MasaBilgileriListesiGetir()
        {
            return dataTableMasabilgileri;
        }
        public void MasaBilgileriKaydet()
        {
            DataRow row = dataTableMasabilgileri.NewRow();

            row["TOPLAM FİYAT"] = toplamfiyat;
            row["MASA NUMARASI"] = masano;
            row["KİŞİ SAYISI"] = kisisayisi;
            row["MASA KONUMU"] = masakonumu;
            dataTableMasabilgileri.Rows.Add(row);
            dsMasabilgileri.WriteXml(dosyaMasabilgileri, XmlWriteMode.WriteSchema);
               }
        public void MasaBilgileriKaydet(DataTable dt)
        {
            dsMasabilgileri.Tables.Clear();
            dataTableMasabilgileri = dt.Copy();
            dsMasabilgileri.Tables.Add(dataTableMasabilgileri);
            dsMasabilgileri.WriteXml(dosyaMasabilgileri, XmlWriteMode.WriteSchema);
        }
        


        //Sadece masa numarasının  adına göre arama yapan metod:
        public DataTable MasaArama(string masano)
        {
           

            var sonuc = from masabilgileri in dataTableMasabilgileri.AsEnumerable()
                        where masabilgileri.Field<string>("MASA NUMARASI").ToUpper().Contains(masano.ToUpper())    //Büyük-küçük harf ayrımı yapmadan araması için ToUpper() kullanıldı.İçinde arama yapmak için Contains() kullanıldı.
                        orderby masabilgileri.Field<string>("MASA NUMARASI") //Masa Numarasına göre küçükten büyüğe sıralaması için bu satır eklendi. 
                        select masabilgileri;

            if (sonuc.Count() > 0)
            {
                DataTable dtSonuc = sonuc.CopyToDataTable(); //var tipindeki sonuçlar DataTable tipine aktarılıp döndürülüyor
                return dtSonuc;
            }
            else
                return null;

        }

    }
}
