namespace KutuphaneTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            KitapKirala kitapKirala = new KitapKirala();
            kitapKirala.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeListele uyeListele = new UyeListele();
            uyeListele.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RomanEkle romanEkle = new RomanEkle();
            romanEkle.ShowDialog();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            KitapListele kitap = new KitapListele();
            kitap.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KitapTeslimEt kitapTeslimEt = new KitapTeslimEt();
            kitapTeslimEt.ShowDialog();
        }
    }
}