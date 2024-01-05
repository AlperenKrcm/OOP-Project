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
    public partial class UyeListele : Form
    {
        public UyeListele()
        // uye ekle formuna gitmeden önce buraya tıkla neden üye gelmediğini anlat 

        {
            InitializeComponent();
            UyeleriListeleFunction();
        }
        private void UyeleriListeleFunction()
        {
            List<Uye> uyeler = UyeListesi.Uyeler;

            // ListBox'ın DataSource özelliğine uyeler listesini ata
            listBox1.DataSource = uyeler;

            // ListBox'ta gösterilecek üye özelliğini belirt (örneğin, adSoyad)
            listBox1.DisplayMember = "adSoyad";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UyeListele_Load(object sender, EventArgs e)
        {

        }
    }
}
