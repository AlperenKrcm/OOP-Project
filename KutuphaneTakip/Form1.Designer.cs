namespace KutuphaneTakip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            button5 = new Button();
            button7 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(30, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 174);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üyelik İşlemleri";
            // 
            // button2
            // 
            button2.Location = new Point(91, 103);
            button2.Name = "button2";
            button2.Size = new Size(109, 50);
            button2.TabIndex = 1;
            button2.Text = "Üye Listeleme";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(91, 45);
            button1.Name = "button1";
            button1.Size = new Size(109, 42);
            button1.TabIndex = 0;
            button1.Text = "Üye Kaydı";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(496, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap İşlemleri";
            // 
            // button4
            // 
            button4.Location = new Point(6, 64);
            button4.Name = "button4";
            button4.Size = new Size(179, 23);
            button4.TabIndex = 3;
            button4.Text = "Kitap Listeleme";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 22);
            button3.Name = "button3";
            button3.Size = new Size(179, 23);
            button3.TabIndex = 2;
            button3.Text = "Kitap Ekleme";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button7);
            groupBox3.Location = new Point(30, 285);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(596, 127);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ödünç Kitap Alma İşlemleri";
            // 
            // button5
            // 
            button5.Location = new Point(6, 22);
            button5.Name = "button5";
            button5.Size = new Size(584, 44);
            button5.TabIndex = 4;
            button5.Text = "Ödünç Kitap Alma İşlemleri";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(6, 85);
            button7.Name = "button7";
            button7.Size = new Size(584, 36);
            button7.TabIndex = 6;
            button7.Text = "Ödünç Kitap Teslim Etme İşlemleri";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button7;
    }
}