using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneTakip
{
    public class Kiralama : IKiralama
    {
    
        public void KitapKiralaFunc(string kitapAdi, string uyeTc)
        {
            Roman kitap = KitapListesi.Romanlar.Find(k => k.Ad == kitapAdi);
            Uye uye = UyeListesi.Uyeler.Find(u => u.tc == uyeTc);


            if (kitap != null && uye != null)
            {
                if (kitap.AlinanKopyaSayisi < kitap.KopyaSayisi)
                {
                    kitap.AlinanKopyaSayisi++;
                    uye.okunanKitapSayisi++;
                    MessageBox.Show($"{kitap.Ad} adlı kitap {uye.adSoyad} adlı üyeye ödünç verildi.");
                }
                else
                {
                    MessageBox.Show($"{kitap.Ad} adlı kitap stokta kalmadığı için ödünç alınamıyor.");
                }
            }
            else
            {
                MessageBox.Show("Kitap veya üye bulunamadı.");
            }
        }

        public void KitapIadeEt(string kitapAdi, string uyeTc)
        {
            Roman kitap = KitapListesi.Romanlar.Find(k => k.Ad == kitapAdi);
            Uye uye = UyeListesi.Uyeler.Find(u => u.tc == uyeTc);

            if (kitap != null && uye != null)
            {
                if (kitap.AlinanKopyaSayisi > 0)
                {
                    kitap.AlinanKopyaSayisi--;
                    uye.okunanKitapSayisi--;
                    MessageBox.Show($"{kitap.Ad} adlı kitap {uye.adSoyad} adlı üyeden iade alındı.");
                }
                else
                {
                    MessageBox.Show($"{kitap.Ad} adlı kitap zaten iade edilmiş durumda.");
                }
            }
            else
            {
                MessageBox.Show("Kitap veya üye bulunamadı.");
            }
        }

        void IKiralama.KitaplariComboBoxaEkle()
        {
            throw new NotImplementedException();
        }
    }
}
