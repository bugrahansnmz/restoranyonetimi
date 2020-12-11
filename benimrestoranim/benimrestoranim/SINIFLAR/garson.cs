using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace benimrestoranim.SINIFLAR
{
    class garson
    {
        private string gkAdi;
        private int gsifre;

        public string ad
        {
            get
            {
                return gkAdi;
            }
            set
            {
                gkAdi = value;
            }
        }
        public int sifre
        {
            get
            {
                return gsifre;
            }
            set
            {
                gsifre = value;
            }
        }

        public static string dosyaYol = "garson.xml";
        private DataSet dsgarson = new DataSet("Liste");
        private DataTable dtgarson = new DataTable("Garson");

        public garson() { dtOlustur(); }

        public garson(string garsonAdi, int garsonsifre)
        {
            this.gkAdi = garsonAdi;
            this.gsifre = garsonsifre;
        }

        public void dtOlustur()
        {
            if(System.IO.File.Exists(dosyaYol))
            {
                dsgarson.ReadXml(dosyaYol);
                dtgarson = dsgarson.Tables[0];
            }
            else
            {
                dtgarson.Columns.Add("garsonAdi");
                dtgarson.Columns.Add("sifre");
                dsgarson.Tables.Add(dtgarson);
                dsgarson.WriteXml(dosyaYol, XmlWriteMode.WriteSchema);
            }
        }








    }
}
