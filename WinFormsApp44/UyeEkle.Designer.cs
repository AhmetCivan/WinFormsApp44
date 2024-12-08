namespace WinFormsApp44
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeEkle));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AdSoyadTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TelefonTb = new TextBox();
            label6 = new Label();
            YasTb = new TextBox();
            label7 = new Label();
            CinsiyetCb = new ComboBox();
            label8 = new Label();
            OdemeTb = new TextBox();
            ZamanlamaCb = new ComboBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(419, 30);
            label1.Name = "label1";
            label1.Size = new Size(245, 40);
            label1.TabIndex = 2;
            label1.Text = "Fitness Center";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(432, 82);
            label2.Name = "label2";
            label2.Size = new Size(207, 37);
            label2.TabIndex = 3;
            label2.Text = "Yeni Üye Ekle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1061, 9);
            label3.Name = "label3";
            label3.Size = new Size(37, 37);
            label3.TabIndex = 4;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // AdSoyadTb
            // 
            AdSoyadTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AdSoyadTb.ForeColor = SystemColors.Highlight;
            AdSoyadTb.Location = new Point(37, 221);
            AdSoyadTb.Name = "AdSoyadTb";
            AdSoyadTb.Size = new Size(248, 36);
            AdSoyadTb.TabIndex = 5;
            AdSoyadTb.KeyPress += AdSoyadTb_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(37, 172);
            label4.Name = "label4";
            label4.Size = new Size(218, 34);
            label4.TabIndex = 6;
            label4.Text = "Üye Adı Soyadı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(408, 172);
            label5.Name = "label5";
            label5.Size = new Size(247, 34);
            label5.TabIndex = 8;
            label5.Text = "Telefon Numarası";
            // 
            // TelefonTb
            // 
            TelefonTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TelefonTb.ForeColor = SystemColors.Highlight;
            TelefonTb.Location = new Point(408, 221);
            TelefonTb.Name = "TelefonTb";
            TelefonTb.Size = new Size(256, 36);
            TelefonTb.TabIndex = 7;
            TelefonTb.KeyPress += TelefonTb_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(762, 172);
            label6.Name = "label6";
            label6.Size = new Size(63, 34);
            label6.TabIndex = 10;
            label6.Text = "Yaş";
            // 
            // YasTb
            // 
            YasTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            YasTb.ForeColor = SystemColors.Highlight;
            YasTb.Location = new Point(753, 221);
            YasTb.Name = "YasTb";
            YasTb.Size = new Size(252, 36);
            YasTb.TabIndex = 9;
            YasTb.KeyPress += YasTb_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(37, 327);
            label7.Name = "label7";
            label7.Size = new Size(123, 34);
            label7.TabIndex = 12;
            label7.Text = "Cinsiyet";
            // 
            // CinsiyetCb
            // 
            CinsiyetCb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            CinsiyetCb.ForeColor = SystemColors.Highlight;
            CinsiyetCb.FormattingEnabled = true;
            CinsiyetCb.Items.AddRange(new object[] { "Erkek", "Kadın" });
            CinsiyetCb.Location = new Point(37, 376);
            CinsiyetCb.Name = "CinsiyetCb";
            CinsiyetCb.Size = new Size(248, 35);
            CinsiyetCb.TabIndex = 13;
            CinsiyetCb.KeyPress += CinsiyetCb_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(408, 327);
            label8.Name = "label8";
            label8.Size = new Size(150, 34);
            label8.TabIndex = 15;
            label8.Text = "Aylık Tutar";
            // 
            // OdemeTb
            // 
            OdemeTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            OdemeTb.ForeColor = SystemColors.Highlight;
            OdemeTb.Location = new Point(408, 376);
            OdemeTb.Name = "OdemeTb";
            OdemeTb.Size = new Size(256, 36);
            OdemeTb.TabIndex = 14;
            OdemeTb.KeyPress += OdemeTb_KeyPress;
            // 
            // ZamanlamaCb
            // 
            ZamanlamaCb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ZamanlamaCb.ForeColor = SystemColors.Highlight;
            ZamanlamaCb.FormattingEnabled = true;
            ZamanlamaCb.Items.AddRange(new object[] { "08.00-10.00", "10.00-12.00", "14.00-16.00", "16.00-18.00", "18.00-20.00", "20.00-22.00", "22.00-00.00" });
            ZamanlamaCb.Location = new Point(753, 376);
            ZamanlamaCb.Name = "ZamanlamaCb";
            ZamanlamaCb.Size = new Size(248, 35);
            ZamanlamaCb.TabIndex = 17;
            ZamanlamaCb.KeyPress += ZamanlamaCb_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(753, 327);
            label9.Name = "label9";
            label9.Size = new Size(179, 34);
            label9.TabIndex = 16;
            label9.Text = "Zamanlama";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(238, 477);
            button1.Name = "button1";
            button1.Size = new Size(136, 63);
            button1.TabIndex = 18;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(457, 477);
            button2.Name = "button2";
            button2.Size = new Size(136, 63);
            button2.TabIndex = 19;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(677, 477);
            button4.Name = "button4";
            button4.Size = new Size(136, 63);
            button4.TabIndex = 21;
            button4.Text = "Geri";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // UyeEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1110, 593);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ZamanlamaCb);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(OdemeTb);
            Controls.Add(CinsiyetCb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(YasTb);
            Controls.Add(label5);
            Controls.Add(TelefonTb);
            Controls.Add(label4);
            Controls.Add(AdSoyadTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UyeEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UyeEkle";
           
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox AdSoyadTb;
        private Label label4;
        private Label label5;
        private TextBox TelefonTb;
        private Label label6;
        private TextBox YasTb;
        private Label label7;
        private ComboBox CinsiyetCb;
        private Label label8;
        private TextBox OdemeTb;
        private ComboBox ZamanlamaCb;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button4;
        private PictureBox pictureBox2;
    }
}