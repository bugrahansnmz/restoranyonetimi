using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace benimrestoranim.SINIFLAR
{
    abstract class stok
    {
        private string isim;
        private int fiyat;
        private int adet;

        public string Isim
        {
            get
            {
                return isim;
            }
            set
            {
                isim = value;
            }
        }
        public int Fiyat
        {
            get
            {
                return fiyat;
            }
            set
            {
                fiyat = value;
            }
        }
        public int Adet
        {
            get
            {
                return adet;
            }
            set
            {
                adet = value;
            }
        }

    }
}
