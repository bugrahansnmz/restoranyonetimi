using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace restaurantyonetimiss.SINIFLAR
{
   

        class tatli : stok, IStok
    {
        private string sutlutatlilar;
        private string serbetlitatlilar;

        public string Sutlutatlilar
        {
            get
            {
                return sutlutatlilar;
            }
            set
            {
                sutlutatlilar = value;
            }
        }
        public string Serbetlitatlilar
        {
            get
            {
                return serbetlitatlilar;
            }
            set
            {
                serbetlitatlilar = value;
            }
        }
        public static string dosyayol = "tatli.xml";
        public DataSet dsTatli = new DataSet("tatliListesi");
        public DataTable dataTableTatli = new DataTable("tatlilar");
        public tatli () { dtOlustur(); } 
            
        public tatli (string sutlutatlilar, string serbetlitatlilar)
        {
            this.Isim = Isim;
            this.Fiyat = Fiyat;
            this.Adet = Adet;
            this.sutlutatlilar = sutlutatlilar;
            this.serbetlitatlilar = serbetlitatlilar;
        }
        public void dtOlustur()
        {
            if (System.IO.File.Exists(dosyayol))
            {
                dsTatli.ReadXml(dosyayol);
                dataTableTatli = dsTatli.Tables[0];

            }
            else
            {
                dataTableTatli.Columns.Add("ISIM");
                dataTableTatli.Columns.Add("FIYAT");
                dataTableTatli.Columns.Add("ADET");
                dataTableTatli.Columns.Add("SUTLUTATLILAR");
                dataTableTatli.Columns.Add("SERBETLITATLILAR");

                dsTatli.Tables.Add(dataTableTatli);
                dataTableTatli.WriteXml(dosyayol, XmlWriteMode.WriteSchema);

                
            }
        }
        public  override DataTable ListesiGetir()
        {
            return dataTableTatli;
        }
        public override void Kaydet()
        {
            DataRow row = dataTableTatli.NewRow();
            row["İSİM"] = Isim;
            row["FİYAT"] = Fiyat;
            row["ADET"] = Adet;
            row["SÜTLÜ TATLILAR"] = sutlutatlilar;
            row["ŞERBETLİ TATLILAR"] = serbetlitatlilar;

            dataTableTatli.Rows.Add(row);
            dsTatli.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }

        public void Kaydet(DataTable dt)
        {
            dsTatli.Tables.Clear();
            dataTableTatli = dt.Copy();
            dsTatli.Tables.Add(dataTableTatli);
            dsTatli.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }

        public override void Guncelle()
        {
            DataRow row = dataTableTatli.NewRow();
            row["İSİM"] = Isim;
            row["FİYAT"] = Fiyat;
            row["ADET"] = Adet;
          row["ŞERBETLİ TATLILAR"] = serbetlitatlilar;
            row["SÜTLÜ TATLILAR"] = sutlutatlilar;
            dataTableTatli.Rows.Add(row);
            dsTatli.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }
        public override void Sil(object a)
        {
            {

                dataTableTatli.Rows.RemoveAt(Convert.ToInt32(a));
                dsTatli.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
            }

        }

    }
}
