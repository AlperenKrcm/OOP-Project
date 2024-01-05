using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneTakip
{
    public interface IKiralama
    {
        public void KitapIadeEt(string kitapAdi, string uyeTc);
        public void KitapKiralaFunc(string kitapAdi, string uyeTc);
        public void KitaplariComboBoxaEkle();

    }
}
