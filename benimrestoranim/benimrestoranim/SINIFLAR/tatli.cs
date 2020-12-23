using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;




namespace benimrestoranim.SINIFLAR
{
    class tatli: stok, Istok
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
        public DataTable dtTatli = new DataTable("tatlilar");

        public tatli() { dtOlustur(); }

        public tatli(string sutlutatlilar, string serbetlitatlilar)
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
                dtTatli = dsTatli.Tables[0];

            }
            else
            {
                dtTatli.Columns.Add("ISIM");
                dtTatli.Columns.Add("FIYAT");
                dtTatli.Columns.Add("ADET");
                dtTatli.Columns.Add("SUTLUTATLILAR");
                dtTatli.Columns.Add("SERBETLITATLILAR");

                dsTatli.Tables.Add(dtTatli);
                dtTatli.WriteXml(dosyayol, XmlWriteMode.WriteSchema);


            }
        }
        public override DataTable ListesiGetir()
        {
            return dtTatli;
        }
        public override void Kaydet()
        {
            DataRow row = dtTatli.NewRow();
            row["İSİM"] = Isim;
            row["FİYAT"] = Fiyat;
            row["ADET"] = Adet;
            row["SÜTLÜ TATLILAR"] = sutlutatlilar;
            row["ŞERBETLİ TATLILAR"] = serbetlitatlilar;
                              
            dtTatli.Rows.Add(row);
            dsTatli.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }
        public void Kaydet(DataTable dt)
        {
            dsTatli.Tables.Clear();
            dtTatli = dt.Copy();
            dsTatli.Tables.Add(dtTatli);
            dsTatli.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }
        public override void Guncelle()
        {
            DataRow row = dtTatli.NewRow();
            row["İSİM"] = Isim;
            row["FİYAT"] = Fiyat;
            row["ADET"] = Adet;
            row["ŞERBETLİ TATLILAR"] = serbetlitatlilar;
            row["SÜTLÜ TATLILAR"] = sutlutatlilar;
            dtTatli.Rows.Add(row);
            dsTatli.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }
        public override void Sil(object a)
        {
            

            dtTatli.Rows.RemoveAt(Convert.ToInt32(a));
            dsTatli.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
            

        }

        
    }

}
