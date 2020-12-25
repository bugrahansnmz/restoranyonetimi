using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantyonetimiss.SINIFLAR
{
    class tatlilar : stok
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
       

    }
}
