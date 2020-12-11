using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace benimrestoranim.SINIFLAR
{
    class yonetici
    {
        private string ykAdi;
        private int ysifre;

        public string ad
        {
            get
            {
                return ykAdi;
            }
            set
            {
                ykAdi = value;  
            }

        }
        public int sifre
        {
            get
            {
                return ysifre;
            }
            set
            {
                ysifre = value;
            }
        }
        public static string dosyaYol = "yonetici.xml";
        private DataSet dsyonetici = new DataSet("Liste");
        private DataTable dtyonetici = new DataTable("Yonetici");

        public yonetici() { dtOlustur(); }

        public yonetici (string yoneticiAdi, int yoneticisifre)
        {
            this.ykAdi = yoneticiAdi;
            this.ysifre = yoneticisifre;
        }
        public void dtOlustur()
        {
            if (System.IO.File.Exists(dosyaYol))
            {
                dsyonetici.ReadXml(dosyaYol);
                dtyonetici = dsyonetici.Tables[0];
            }
            else
            {
                dtyonetici.Columns.Add("yoneticiAdi");
                dtyonetici.Columns.Add("sifre");
                dsyonetici.Tables.Add(dtyonetici);
                dsyonetici.WriteXml(dosyaYol, XmlWriteMode.WriteSchema);
            }
        }
    }
}
