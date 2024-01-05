using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneTakip
{
    internal class UyeListesi
    {
        public static List<Uye> uyeListesi = new List<Uye>();

        public static List<Uye> Uyeler
        {
            get { return uyeListesi; }
        }

        public static void UyeEkle(Uye yeniUye)
        {
            uyeListesi.Add(yeniUye);
        }
    }

}
