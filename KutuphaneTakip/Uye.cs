using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneTakip
{
    internal class Uye
    {
        public string tc { get; set; }
        public string adSoyad { get; set; }
        public int yas { get; set; }
        public string cinsiyet { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public string eMail { get; set; }
        public int okunanKitapSayisi { get; set; }

        public Uye() { }    
        public Uye(string a, string b, int c, string d, string e, string f, string g)
        {
            tc = a;
            adSoyad = b;
            yas = c;
            cinsiyet = d;
            telefon = e;
            adres = f;
            eMail = g;
            okunanKitapSayisi = 0;
        }

    }
}
