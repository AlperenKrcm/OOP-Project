namespace KutuphaneTakip
{
    partial class KitapKirala
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
            UyeTC = new Label();
            label2 = new Label();
            txtKiralamaUyeTC = new TextBox();
            CombokitaplariGoster = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // UyeTC
            // 
            UyeTC.AutoSize = true;
            UyeTC.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UyeTC.Location = new Point(175, 72);
            UyeTC.Name = "UyeTC";
            UyeTC.Size = new Size(326, 15);
            UyeTC.TabIndex = 0;
            UyeTC.Text = "Türkiye Cumhuriyeti Kimlik Numaranızı Giriniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(198, 141);
            label2.Name = "label2";
            label2.Size = new Size(208, 16);
            label2.TabIndex = 1;
            label2.Text = "Kiralamak İstediğiniz Kitabı Seçiniz";
            // 
            // txtKiralamaUyeTC
            // 
            txtKiralamaUyeTC.Location = new Point(208, 99);
            txtKiralamaUyeTC.Name = "txtKiralamaUyeTC";
            txtKiralamaUyeTC.Size = new Size(127, 23);
            txtKiralamaUyeTC.TabIndex = 2;
            // 
            // CombokitaplariGoster
            // 
            CombokitaplariGoster.FormattingEnabled = true;
            CombokitaplariGoster.Location = new Point(208, 160);
            CombokitaplariGoster.Name = "CombokitaplariGoster";
            CombokitaplariGoster.Size = new Size(154, 23);
            CombokitaplariGoster.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.PanNE;
            button1.Location = new Point(223, 198);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Kitap Kirala";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // KitapKirala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(CombokitaplariGoster);
            Controls.Add(txtKiralamaUyeTC);
            Controls.Add(label2);
            Controls.Add(UyeTC);
            Name = "KitapKirala";
            Text = "KitapKirala";
            Load += KitapKirala_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UyeTC;
        private Label label2;
        private TextBox txtKiralamaUyeTC;
        private ComboBox CombokitaplariGoster;
        private Button button1;
    }
}