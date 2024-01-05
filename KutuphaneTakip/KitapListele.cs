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
    public partial class KitapListele : Form
    {
        public KitapListele()
        {

            InitializeComponent();
            KitapListeleFunction();
        }
        private void KitapListeleFunction()
        {
            List<Roman> roman = KitapListesi.Romanlar;

            // ListBox'ın DataSource özelliğine uyeler listesini ata
            listBox1.DataSource = roman;

            // ListBox'ta gösterilecek üye özelliğini belirt (örneğin, adSoyad)
            listBox1.DisplayMember = "Ad";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
