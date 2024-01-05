using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneTakip
{
    internal class Roman : Kitap
    {
        public string Tur {  get; set; }    

     
        public override void Ekle(string a, string b, int c, string d,int e,int q)
        {
            Ad = a;
            Yazar = b;
            SayfaSayisi = c;
            Tur = d;
            KitapId = e;
            AlinanKopyaSayisi = 0;
            KopyaSayisi= q;
        }

        public override void Goster()
        {
            throw new NotImplementedException();
        }
    }
}
