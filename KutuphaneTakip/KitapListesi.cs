using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneTakip
{
    internal class KitapListesi
    {
        public static List<Roman> kitapListesi = new List<Roman>();

        public static List<Roman> Romanlar
        {
            get { return kitapListesi; }
        }

        public static void RomanEkle(Roman yeniRoman)
        {
            kitapListesi.Add(yeniRoman);
        }
    }
}
