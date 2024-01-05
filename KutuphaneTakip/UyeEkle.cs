using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneTakip
{

    public partial class UyeEkle : Form
    {

       

        
        public UyeEkle()
        {
            Uye a =new Uye("21488082586", "alperen karacam", 22, "erkek", "5434806735", "sivas", "aslankral1905@outlook.com");
            Uye b = new Uye("12345678910", "alp karacam", 21, "erkek", "5434806734", "kocaeli", "aslankral190548@outlook.com");
            Uye c = new Uye("21488082586", "alper karacam", 23, "erkek", "5434806732", "muğla", "aslankral190549@outlook.com");
            UyeListesi.UyeEkle(a);
            UyeListesi.UyeEkle(b);
            UyeListesi.UyeEkle(c);
            // kısayolunu sunumda ver.
          // UyeListesi.UyeEkle(new Uye("21488082586", "alperen karacam", 22, "erkek", "5434806735", "sivas", "aslankral1905@outlook.com"));
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {

            Uye yeniUye = new Uye(txtUyeTc.Text, txtUyeIsımSoyisim.Text, Convert.ToInt32(txtUyeYas.Text), comboUyeCinsiyet.Text, txtUyeTelefon.Text, txtUyeAdres.Text, txtUyeEposta.Text);
            UyeListesi.UyeEkle(yeniUye);
        }
    }
}
