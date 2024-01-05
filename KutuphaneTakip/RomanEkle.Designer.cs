namespace KutuphaneTakip
{
    partial class RomanEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RomanEkle));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboKitapTuru = new ComboBox();
            label4 = new Label();
            txtRomanAdi = new TextBox();
            txtRomanYazar = new TextBox();
            txtRomanSayfa = new TextBox();
            button1 = new Button();
            txtKitapId = new TextBox();
            KitapID = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(572, 71);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Roman Adı=";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 98);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Yazar=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(572, 128);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Sayfa Sayısı=";
            // 
            // comboKitapTuru
            // 
            comboKitapTuru.FormattingEnabled = true;
            comboKitapTuru.Items.AddRange(new object[] { "Aksiyon", "Macera", "Polisiye", "Dram", "Tarih" });
            comboKitapTuru.Location = new Point(648, 156);
            comboKitapTuru.Name = "comboKitapTuru";
            comboKitapTuru.Size = new Size(121, 23);
            comboKitapTuru.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(572, 157);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Türü=";
            // 
            // txtRomanAdi
            // 
            txtRomanAdi.Location = new Point(648, 68);
            txtRomanAdi.Name = "txtRomanAdi";
            txtRomanAdi.Size = new Size(121, 23);
            txtRomanAdi.TabIndex = 5;
            // 
            // txtRomanYazar
            // 
            txtRomanYazar.Location = new Point(648, 97);
            txtRomanYazar.Name = "txtRomanYazar";
            txtRomanYazar.Size = new Size(121, 23);
            txtRomanYazar.TabIndex = 6;
            // 
            // txtRomanSayfa
            // 
            txtRomanSayfa.Location = new Point(648, 127);
            txtRomanSayfa.Name = "txtRomanSayfa";
            txtRomanSayfa.Size = new Size(121, 23);
            txtRomanSayfa.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(648, 230);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 8;
            button1.Text = "Roman Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtKitapId
            // 
            txtKitapId.Location = new Point(648, 39);
            txtKitapId.Name = "txtKitapId";
            txtKitapId.Size = new Size(121, 23);
            txtKitapId.TabIndex = 9;
            // 
            // KitapID
            // 
            KitapID.AutoSize = true;
            KitapID.BackColor = SystemColors.ActiveCaptionText;
            KitapID.ForeColor = SystemColors.ButtonHighlight;
            KitapID.Location = new Point(572, 47);
            KitapID.Name = "KitapID";
            KitapID.Size = new Size(53, 15);
            KitapID.TabIndex = 10;
            KitapID.Text = "KitapID=";
            // 
            // RomanEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(KitapID);
            Controls.Add(txtKitapId);
            Controls.Add(button1);
            Controls.Add(txtRomanSayfa);
            Controls.Add(txtRomanYazar);
            Controls.Add(txtRomanAdi);
            Controls.Add(label4);
            Controls.Add(comboKitapTuru);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RomanEkle";
            ShowIcon = false;
            Text = "RomanEkle";
            Load += RomanEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboKitapTuru;
        private Label label4;
        private TextBox txtRomanAdi;
        private TextBox txtRomanYazar;
        private TextBox txtRomanSayfa;
        private Button button1;
        private TextBox txtKitapId;
        private Label KitapID;
    }
}