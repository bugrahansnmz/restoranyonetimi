using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantyonetimiss.SINIFLAR
{
       abstract class  stok 
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

       public abstract void Kaydet();
      
        
        

        public abstract DataTable ListesiGetir();
        
        
       
        public abstract void Guncelle();
        
        public abstract void Sil(object a);
        
    }
}
