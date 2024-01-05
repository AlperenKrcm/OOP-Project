namespace KutuphaneTakip
{
    partial class UyeEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUyeTc = new TextBox();
            txtUyeIsımSoyisim = new TextBox();
            txtUyeYas = new TextBox();
            txtUyeTelefon = new TextBox();
            txtUyeAdres = new TextBox();
            txtUyeEposta = new TextBox();
            txtUyeOKS = new TextBox();
            comboUyeCinsiyet = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnUyeEkle = new Button();
            btnUyeIptal = new Button();
            SuspendLayout();
            // 
            // txtUyeTc
            // 
            txtUyeTc.Location = new Point(148, 41);
            txtUyeTc.Name = "txtUyeTc";
            txtUyeTc.Size = new Size(222, 23);
            txtUyeTc.TabIndex = 0;
            txtUyeTc.TextChanged += textBox1_TextChanged;
            // 
            // txtUyeIsımSoyisim
            // 
            txtUyeIsımSoyisim.Location = new Point(148, 70);
            txtUyeIsımSoyisim.Name = "txtUyeIsımSoyisim";
            txtUyeIsımSoyisim.Size = new Size(222, 23);
            txtUyeIsımSoyisim.TabIndex = 1;
            txtUyeIsımSoyisim.TextChanged += textBox2_TextChanged;
            // 
            // txtUyeYas
            // 
            txtUyeYas.Location = new Point(148, 99);
            txtUyeYas.Name = "txtUyeYas";
            txtUyeYas.Size = new Size(222, 23);
            txtUyeYas.TabIndex = 2;
            txtUyeYas.TextChanged += textBox3_TextChanged;
            // 
            // txtUyeTelefon
            // 
            txtUyeTelefon.Location = new Point(148, 157);
            txtUyeTelefon.Name = "txtUyeTelefon";
            txtUyeTelefon.Size = new Size(222, 23);
            txtUyeTelefon.TabIndex = 3;
            txtUyeTelefon.TextChanged += textBox4_TextChanged;
            // 
            // txtUyeAdres
            // 
            txtUyeAdres.Location = new Point(148, 186);
            txtUyeAdres.Name = "txtUyeAdres";
            txtUyeAdres.Size = new Size(222, 23);
            txtUyeAdres.TabIndex = 4;
            txtUyeAdres.TextChanged += textBox5_TextChanged;
            // 
            // txtUyeEposta
            // 
            txtUyeEposta.Location = new Point(148, 215);
            txtUyeEposta.Name = "txtUyeEposta";
            txtUyeEposta.Size = new Size(222, 23);
            txtUyeEposta.TabIndex = 5;
            txtUyeEposta.TextChanged += textBox6_TextChanged;
            // 
            // txtUyeOKS
            // 
            txtUyeOKS.Location = new Point(148, 244);
            txtUyeOKS.Name = "txtUyeOKS";
            txtUyeOKS.Size = new Size(222, 23);
            txtUyeOKS.TabIndex = 6;
            txtUyeOKS.Text = "0";
            txtUyeOKS.TextChanged += textBox7_TextChanged;
            // 
            // comboUyeCinsiyet
            // 
            comboUyeCinsiyet.FormattingEnabled = true;
            comboUyeCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboUyeCinsiyet.Location = new Point(148, 128);
            comboUyeCinsiyet.Name = "comboUyeCinsiyet";
            comboUyeCinsiyet.Size = new Size(222, 23);
            comboUyeCinsiyet.TabIndex = 7;
            comboUyeCinsiyet.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 44);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 8;
            label1.Text = "TC";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 107);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 8;
            label2.Text = "Yaş";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 136);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 8;
            label3.Text = "Cinsiyet";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 165);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 8;
            label4.Text = "Telefon";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 194);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 8;
            label5.Text = "Adres";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 223);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 8;
            label6.Text = "E-Posta";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 252);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 8;
            label7.Text = "Okunan Kitap Sayısı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 78);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 8;
            label8.Text = "İsim Soyisim";
            label8.Click += label8_Click;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Location = new Point(148, 306);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(75, 23);
            btnUyeEkle.TabIndex = 9;
            btnUyeEkle.Text = "Ekle";
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // btnUyeIptal
            // 
            btnUyeIptal.Location = new Point(295, 306);
            btnUyeIptal.Name = "btnUyeIptal";
            btnUyeIptal.Size = new Size(75, 23);
            btnUyeIptal.TabIndex = 10;
            btnUyeIptal.Text = "İptal";
            btnUyeIptal.UseVisualStyleBackColor = true;
            // 
            // UyeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUyeIptal);
            Controls.Add(btnUyeEkle);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(comboUyeCinsiyet);
            Controls.Add(txtUyeOKS);
            Controls.Add(txtUyeEposta);
            Controls.Add(txtUyeAdres);
            Controls.Add(txtUyeTelefon);
            Controls.Add(txtUyeYas);
            Controls.Add(txtUyeIsımSoyisim);
            Controls.Add(txtUyeTc);
            Name = "UyeEkle";
            Text = "Üye Kaydı";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUyeTc;
        private TextBox txtUyeIsımSoyisim;
        private TextBox txtUyeYas;
        private TextBox txtUyeTelefon;
        private TextBox txtUyeAdres;
        private TextBox txtUyeEposta;
        private TextBox txtUyeOKS;
        private ComboBox comboUyeCinsiyet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnUyeEkle;
        private Button btnUyeIptal;
    }
}