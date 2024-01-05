namespace KutuphaneTakip
{
    partial class KitapTeslimEt
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
            label1 = new Label();
            label2 = new Label();
            txtIadetcNO = new TextBox();
            CombokitapIade = new ComboBox();
            Button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 45);
            label1.Name = "label1";
            label1.Size = new Size(250, 15);
            label1.TabIndex = 0;
            label1.Text = "Türkiye Cumhuriyeti Kimlik Numaranızı Giriniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 118);
            label2.Name = "label2";
            label2.Size = new Size(191, 15);
            label2.TabIndex = 1;
            label2.Text = "İade etmek istediğiniz kitabı seçiniz";
            // 
            // txtIadetcNO
            // 
            txtIadetcNO.Location = new Point(251, 82);
            txtIadetcNO.Name = "txtIadetcNO";
            txtIadetcNO.Size = new Size(148, 23);
            txtIadetcNO.TabIndex = 2;
            txtIadetcNO.TextChanged += txtIadetcNO_TextChanged;
            // 
            // CombokitapIade
            // 
            CombokitapIade.FormattingEnabled = true;
            CombokitapIade.Location = new Point(251, 146);
            CombokitapIade.Name = "CombokitapIade";
            CombokitapIade.Size = new Size(148, 23);
            CombokitapIade.TabIndex = 3;
            // 
            // Button1
            // 
            Button1.BackColor = Color.Blue;
            Button1.Cursor = Cursors.SizeAll;
            Button1.ForeColor = SystemColors.ButtonHighlight;
            Button1.Location = new Point(251, 187);
            Button1.Name = "Button1";
            Button1.Size = new Size(290, 23);
            Button1.TabIndex = 4;
            Button1.Text = "Ödünç aldığınız kitabi iade etmek için tıklayınız";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += button1_Click;
            // 
            // KitapTeslimEt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(Button1);
            Controls.Add(CombokitapIade);
            Controls.Add(txtIadetcNO);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KitapTeslimEt";
            Text = "KitapTeslimEt";
            Load += KitapTeslimEt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIadetcNO;
        private ComboBox CombokitapIade;
        private Button Button1;
    }
}