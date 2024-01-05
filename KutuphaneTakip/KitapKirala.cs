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
    public partial class KitapKirala : Form
    {
        public KitapKirala()
        {
            
            InitializeComponent();
            List<Roman> kitaplar = KitapListesi.Romanlar;

            // ComboBox'ı temizle
            CombokitaplariGoster.Items.Clear();


            // Kitapları ComboBox'a ekle
            foreach (Roman kitap in kitaplar)
            {
                CombokitaplariGoster.Items.Add(kitap.Ad);
            }

        }

        private void KitapKirala_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kiralama k = new Kiralama();
           k.KitapKiralaFunc(CombokitaplariGoster.Text, txtKiralamaUyeTC.Text);
        }
    }
}
