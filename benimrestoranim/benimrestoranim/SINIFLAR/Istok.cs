using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace benimrestoranim.SINIFLAR
{
    interface Istok
    {

        void Kaydet();

        DataTable ListesiGetir();

        void Guncelle();

        void Sil(object a);

    }
}
