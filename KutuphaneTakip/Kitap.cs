using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneTakip
{
    public abstract class Kitap:IKitap
    {
        // 2. Kapsülleme: Özellikleri(properties) private olarak tanımla ve dışarıdan erişimi kısıtla.
        private string ad;
        private string yazar;
        private int sayfaSayisi;
        private int kitapId;
        private int alinanKopyaSayisi;
        private int kopyaSayisi;

        // 3. Kapsülleme: Public getter ve setter metotları kullanarak özelliklere erişimi sağla.
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Yazar
        {
            get { return yazar; }
            set { yazar = value; }
        }

        public int SayfaSayisi
        {
            get { return sayfaSayisi; }
            set { sayfaSayisi = value; }
        }
        public int KitapId
        {
            get { return kitapId; }
            set { kitapId = value; }
        }

        public int KopyaSayisi { get => kopyaSayisi; set => kopyaSayisi = value; }
        public int AlinanKopyaSayisi { get => alinanKopyaSayisi; set => alinanKopyaSayisi = value; }

        public abstract void Ekle(string a, string b, int c, string d, int e, int f);
        public abstract void Goster();
    }
}
