using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace restaurantyonetimiss.SINIFLAR
{

    class icecek : stok, IStok
    {



        private string sikmaicecekler;
        private string sicakicecekler;
        private string sogukicecekler;


        public string Sikmaicecekler
        {
            get
            {
                return sikmaicecekler;
            }
            set
            {
                sikmaicecekler = value;
            }
        }
        public string Sicakicecekler
        {
            get
            {
                return sicakicecekler;
            }
            set
            {
                sicakicecekler = value;
            }
        }
        public string Sogukicecekler
        {
            get
            {
                return sogukicecekler;
            }
            set
            {
                sogukicecekler = value;
            }
        }

        public static string dosyayol = "icecek.xml";
        public DataSet dsIcecek = new DataSet("icecekListesi");
        public DataTable dataTableIcecek = new DataTable("icecekler");

        public icecek() { dtOlustur(); }


        public icecek(string sikmaicecekler, string sicakicecekler, string sogukicecekler)
        {
            this.Isim = Isim;
            this.Fiyat = Fiyat;
            this.Adet = Adet;
            this.sikmaicecekler = sikmaicecekler;
            this.sicakicecekler = sicakicecekler;
            this.sogukicecekler = sogukicecekler;
            
        }
        private void dtOlustur()
        {
            if (System.IO.File.Exists(dosyayol))
            {
                dsIcecek.ReadXml(dosyayol);
                dataTableIcecek = dsIcecek.Tables[0];

            }
            else   
            {
                dataTableIcecek.Columns.Add("ISIM");
                dataTableIcecek.Columns.Add("FIYAT");
                dataTableIcecek.Columns.Add("ADET");
                dataTableIcecek.Columns.Add("SIKMAICECEKLER");
                dataTableIcecek.Columns.Add("SICAKICECEKLER");
                dataTableIcecek.Columns.Add("SOGUKICECEKLER");

                dsIcecek.Tables.Add(dataTableIcecek);
                dsIcecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);

            }
        }
        public override DataTable ListesiGetir()
        {
            return dataTableIcecek;
        }
        public override void Kaydet()
        {
            DataRow row = dataTableIcecek.NewRow();
            row["İSİM"] = Isim;
            row["FİYAT"] = Fiyat;
            row["ADET"] = Adet;
            row["SIKMA İÇECEKLER"] = sikmaicecekler;
            row["SOĞUK İÇECEKLER"] = sogukicecekler;
            row["SICAK İÇECEKLER"] = sicakicecekler;
            dataTableIcecek.Rows.Add(row);
            dsIcecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }
        public void Kaydet(DataTable dt)
        {
            dsIcecek.Tables.Clear();
            dataTableIcecek = dt.Copy();
            dsIcecek.Tables.Add(dataTableIcecek);
            dsIcecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);

        }
        public override void Guncelle()
        {
            DataRow row = dataTableIcecek.NewRow();
            row["İSİM"] = Isim;
            row["FİYAT"] = Fiyat;
            row["ADET"] = Adet;
            row["SIKMA İÇECEKLER"] = sikmaicecekler;
            row["SOĞUK İÇECEKLER"] = sogukicecekler;
            row["SICAK İÇECEKLER"] = sicakicecekler;
            dataTableIcecek.Rows.Add(row);
            dsIcecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }
        public override void Sil(object icecek)
        {
            dataTableIcecek.Rows.RemoveAt(Convert.ToInt32(icecek));
            dsIcecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }


    }

    }



    


