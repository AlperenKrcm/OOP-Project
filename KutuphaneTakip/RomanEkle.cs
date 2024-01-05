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
    public partial class RomanEkle : Form
    {
        public RomanEkle()
        {
            Roman roman = new Roman();
            
            roman.Ekle("Kibar Hırsız", "Leblanc", 300, "Polisiye",1,100);
            KitapListesi.RomanEkle(roman);
          

            InitializeComponent();
        }

        private void RomanEkle_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roman roman=new Roman();
            roman.Ekle(txtRomanAdi.Text, txtRomanYazar.Text, Convert.ToInt32(txtRomanSayfa.Text), comboKitapTuru.Text,Convert.ToInt32(txtKitapId.Text),12);
            KitapListesi roman1 = new KitapListesi();
            KitapListesi.RomanEkle(roman);
        }
    }
}
