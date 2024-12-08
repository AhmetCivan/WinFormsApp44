namespace WinFormsApp44
{
    partial class GuncelleSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuncelleSil));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            ZamanlamaCb = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            OdemeTb = new TextBox();
            CinsiyetCb = new ComboBox();
            label6 = new Label();
            YasTb = new TextBox();
            label5 = new Label();
            TelefonTb = new TextBox();
            label4 = new Label();
            AdSoyadTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label7 = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            UyeDGV = new DataGridView();
            buttob3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UyeDGV).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(128, 743);
            button4.Name = "button4";
            button4.Size = new Size(188, 63);
            button4.TabIndex = 37;
            button4.Text = "Geri";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(293, 664);
            button2.Name = "button2";
            button2.Size = new Size(132, 63);
            button2.TabIndex = 36;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(17, 664);
            button1.Name = "button1";
            button1.Size = new Size(132, 63);
            button1.TabIndex = 35;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ZamanlamaCb
            // 
            ZamanlamaCb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ZamanlamaCb.ForeColor = SystemColors.Highlight;
            ZamanlamaCb.FormattingEnabled = true;
            ZamanlamaCb.Items.AddRange(new object[] { "08.00-10.00", "10.00-12.00", "14.00-16.00", "16.00-18.00", "18.00-20.00", "20.00-22.00", "22.00-00.00" });
            ZamanlamaCb.Location = new Point(27, 618);
            ZamanlamaCb.Name = "ZamanlamaCb";
            ZamanlamaCb.Size = new Size(248, 35);
            ZamanlamaCb.TabIndex = 34;
            ZamanlamaCb.KeyPress += ZamanlamaCb_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(27, 569);
            label9.Name = "label9";
            label9.Size = new Size(179, 34);
            label9.TabIndex = 33;
            label9.Text = "Zamanlama";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(27, 481);
            label8.Name = "label8";
            label8.Size = new Size(150, 34);
            label8.TabIndex = 32;
            label8.Text = "Aylık Tutar";
            // 
            // OdemeTb
            // 
            OdemeTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            OdemeTb.ForeColor = SystemColors.Highlight;
            OdemeTb.Location = new Point(27, 530);
            OdemeTb.Name = "OdemeTb";
            OdemeTb.Size = new Size(247, 36);
            OdemeTb.TabIndex = 31;
            OdemeTb.KeyPress += OdemeTb_KeyPress;
            // 
            // CinsiyetCb
            // 
            CinsiyetCb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            CinsiyetCb.ForeColor = SystemColors.Highlight;
            CinsiyetCb.FormattingEnabled = true;
            CinsiyetCb.Items.AddRange(new object[] { "Erkek", "Kadın" });
            CinsiyetCb.Location = new Point(26, 354);
            CinsiyetCb.Name = "CinsiyetCb";
            CinsiyetCb.Size = new Size(248, 35);
            CinsiyetCb.TabIndex = 30;
            CinsiyetCb.KeyPress += CinsiyetCb_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(27, 392);
            label6.Name = "label6";
            label6.Size = new Size(63, 34);
            label6.TabIndex = 29;
            label6.Text = "Yaş";
            // 
            // YasTb
            // 
            YasTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            YasTb.ForeColor = SystemColors.Highlight;
            YasTb.Location = new Point(26, 442);
            YasTb.Name = "YasTb";
            YasTb.Size = new Size(248, 36);
            YasTb.TabIndex = 28;
            YasTb.KeyPress += YasTb_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(26, 217);
            label5.Name = "label5";
            label5.Size = new Size(247, 34);
            label5.TabIndex = 27;
            label5.Text = "Telefon Numarası";
            // 
            // TelefonTb
            // 
            TelefonTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TelefonTb.ForeColor = SystemColors.Highlight;
            TelefonTb.Location = new Point(26, 266);
            TelefonTb.Name = "TelefonTb";
            TelefonTb.Size = new Size(247, 36);
            TelefonTb.TabIndex = 26;
            TelefonTb.KeyPress += TelefonTb_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(26, 129);
            label4.Name = "label4";
            label4.Size = new Size(218, 34);
            label4.TabIndex = 25;
            label4.Text = "Üye Adı Soyadı";
            // 
            // AdSoyadTb
            // 
            AdSoyadTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AdSoyadTb.ForeColor = SystemColors.Highlight;
            AdSoyadTb.Location = new Point(26, 178);
            AdSoyadTb.Name = "AdSoyadTb";
            AdSoyadTb.Size = new Size(248, 36);
            AdSoyadTb.TabIndex = 24;
            AdSoyadTb.KeyPress += AdSoyadTb_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(405, 59);
            label2.Name = "label2";
            label2.Size = new Size(253, 37);
            label2.TabIndex = 23;
            label2.Text = "Üye Güncelle/Sil";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(413, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 40);
            label1.TabIndex = 22;
            label1.Text = "Fitness Center";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1169, 9);
            label3.Name = "label3";
            label3.Size = new Size(37, 37);
            label3.TabIndex = 38;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(26, 305);
            label7.Name = "label7";
            label7.Size = new Size(123, 34);
            label7.TabIndex = 39;
            label7.Text = "Cinsiyet";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(700, 125);
            label10.Name = "label10";
            label10.Size = new Size(236, 34);
            label10.TabIndex = 41;
            label10.Text = "Üye Güncelle/Sil";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // UyeDGV
            // 
            UyeDGV.AllowUserToAddRows = false;
            UyeDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SkyBlue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UyeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UyeDGV.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            UyeDGV.DefaultCellStyle = dataGridViewCellStyle2;
            UyeDGV.GridColor = SystemColors.Window;
            UyeDGV.Location = new Point(437, 174);
            UyeDGV.Name = "UyeDGV";
            UyeDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            UyeDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            UyeDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle4.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = Color.SkyBlue;
            UyeDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            UyeDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UyeDGV.Size = new Size(757, 513);
            UyeDGV.TabIndex = 43;
            UyeDGV.CellContentClick += UyeDGV_CellContentClick;
            // 
            // buttob3
            // 
            buttob3.BackColor = SystemColors.Highlight;
            buttob3.FlatAppearance.BorderSize = 0;
            buttob3.FlatStyle = FlatStyle.Flat;
            buttob3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttob3.ForeColor = Color.White;
            buttob3.Location = new Point(155, 664);
            buttob3.Name = "buttob3";
            buttob3.Size = new Size(132, 63);
            buttob3.TabIndex = 44;
            buttob3.Text = "Sil";
            buttob3.UseVisualStyleBackColor = false;
            buttob3.Click += buttob3_Click;
            // 
            // GuncelleSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1218, 818);
            Controls.Add(buttob3);
            Controls.Add(UyeDGV);
            Controls.Add(pictureBox2);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ZamanlamaCb);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(OdemeTb);
            Controls.Add(CinsiyetCb);
            Controls.Add(label6);
            Controls.Add(YasTb);
            Controls.Add(label5);
            Controls.Add(TelefonTb);
            Controls.Add(label4);
            Controls.Add(AdSoyadTb);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GuncelleSil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuncelleSil";
            Load += GuncelleSil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)UyeDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button2;
        private Button button1;
        private ComboBox ZamanlamaCb;
        private Label label9;
        private Label label8;
        private TextBox OdemeTb;
        private ComboBox CinsiyetCb;
        private Label label6;
        private TextBox YasTb;
        private Label label5;
        private TextBox TelefonTb;
        private Label label4;
        private TextBox AdSoyadTb;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label7;
        private Label label10;
        private PictureBox pictureBox2;
        private DataGridView UyeDGV;
        private Button buttob3;
    }
}