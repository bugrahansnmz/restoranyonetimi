using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantyonetimiss.SINIFLAR
{
    interface IStok
    {
        void Kaydet();

        DataTable ListesiGetir();

        void Guncelle();

        void Sil(object a);
    }
}
