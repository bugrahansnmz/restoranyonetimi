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
      
        public virtual void icecekKaydet()
        {

        }
        public virtual void tatliKaydet()
        {
            
        }
        public virtual void yiyecekKaydet()
        {

        }

        public abstract DataTable ListesiGetir();
        
        public virtual void YiyecekListesiGetir()
        {
           
        }
        public virtual void IcecekListesiGetir()
        {

        }
        public virtual void TatliListesiGetir()
        {

        }
        public abstract void Guncelle();
        public virtual void icecekGuncelle()
        {

        }
        public virtual void yiyecekGuncelle()
        {

        }
        public virtual void tatliGuncelle()
        {

        }
        public abstract void Sil(object a);
        public virtual void icecekSil()
        {

        }
        public virtual void yiyecekSil()
        {

        }
        public virtual void tatliSil()
        {

        }
    }
}
