using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakip
{
    public partial class KitapTeslimEt : Form
    {
        public KitapTeslimEt()
        {
            InitializeComponent();
            List<Roman> kitaplar = KitapListesi.Romanlar;

            // ComboBox'ı temizle
            CombokitapIade.Items.Clear();

            // Kitapları ComboBox'a ekle
            foreach (Roman kitap in kitaplar)
            {
                CombokitapIade.Items.Add(kitap.Ad);
            }
        }

        private void KitapTeslimEt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kiralama k = new Kiralama();
            k.KitapIadeEt(CombokitapIade.Text, txtIadetcNO.Text);
        }

        private void txtIadetcNO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
