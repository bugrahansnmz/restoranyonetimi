using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace benimrestoranim.SINIFLAR
{
    class icecek :  stok , Istok
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
        public DataSet dsIcecek = new DataSet("İcecekListesi");
        public DataTable dtIcecek = new DataTable("İcecekler");

        public icecek () { dtOlustur();  }

        public icecek(string sikmaicecekler, string sicakicecekler , string sogukicecekler)
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
            if(System.IO.File.Exists(dosyayol))
            {
                dsIcecek.ReadXml(dosyayol);
                dtIcecek = dsIcecek.Tables[0];
            }
            else
            {
                dtIcecek.Columns.Add("ISIM");
                dtIcecek.Columns.Add("FIYAT");
                dtIcecek.Columns.Add("ADET");
                dtIcecek.Columns.Add("SIKMAICECEKLER");
                dtIcecek.Columns.Add("SICAKICECEKLER");
                dtIcecek.Columns.Add("SOGUKICECEKLER");

                dsIcecek.Tables.Add(dtIcecek);
                dsIcecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
            }
        }
        public override DataTable ListesiGetir()
        {
            return dtIcecek;
        }
        public override void Kaydet()
        {
            DataRow row = dtIcecek.NewRow();
            row["İSİM"] = Isim;
            row["FİYAT"] = Fiyat;
            row["ADET"] = Adet;
            row["SIKMA İÇECEKLER"] = sikmaicecekler;
            row["SICAK İÇECEKLER"] = sicakicecekler;
            row["SOĞUK İÇECEKLER"] = sogukicecekler;
            dtIcecek.Rows.Add(row);
            dsIcecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }

        public void Kaydet(DataTable dt)
        {
            dsIcecek.Tables.Clear();
            dtIcecek = dt.Copy();
            dsIcecek.Tables.Add(dtIcecek);
            dsIcecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }
        public override void Guncelle()
        {
            DataRow row = dtIcecek.NewRow();
            row["İSİM"] = Isim;
            row["FİYAT"] = Fiyat;
            row["ADET"] = Adet;
            row["SIKMA İÇECEKLER"] = sikmaicecekler;
            row["SOĞUK İÇECEKLER"] = sogukicecekler;
            row["SICAK İÇECEKLER"] = sicakicecekler;
            dtIcecek.Rows.Add(row);
            dsIcecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }
        public override void Sil(object icecek)
        {
            dtIcecek.Rows.RemoveAt(Convert.ToInt32(icecek));
            dsIcecek.WriteXml(dosyayol, XmlWriteMode.WriteSchema);
        }







    }
}
