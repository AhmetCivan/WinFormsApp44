namespace WinFormsApp44
{
    partial class Odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odeme));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            OdemeTb = new TextBox();
            label4 = new Label();
            Periyot = new DateTimePicker();
            label10 = new Label();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            AdSoyadCb = new ComboBox();
            OdemeDGV = new DataGridView();
            button3 = new Button();
            button5 = new Button();
            AraTb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OdemeDGV).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1046, 9);
            label3.Name = "label3";
            label3.Size = new Size(37, 37);
            label3.TabIndex = 42;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(473, 49);
            label2.Name = "label2";
            label2.Size = new Size(164, 37);
            label2.TabIndex = 41;
            label2.Text = "Ödemeler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(442, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 40);
            label1.TabIndex = 40;
            label1.Text = "Fitness Center";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(20, 429);
            label5.Name = "label5";
            label5.Size = new Size(80, 34);
            label5.TabIndex = 46;
            label5.Text = "Tutar";
            // 
            // OdemeTb
            // 
            OdemeTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            OdemeTb.ForeColor = SystemColors.Highlight;
            OdemeTb.Location = new Point(20, 478);
            OdemeTb.Name = "OdemeTb";
            OdemeTb.Size = new Size(247, 36);
            OdemeTb.TabIndex = 45;
            OdemeTb.KeyPress += OdemeTb_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(20, 341);
            label4.Name = "label4";
            label4.Size = new Size(218, 34);
            label4.TabIndex = 44;
            label4.Text = "Üye Adı Soyadı";
            // 
            // Periyot
            // 
            Periyot.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Periyot.Format = DateTimePickerFormat.Short;
            Periyot.Location = new Point(21, 283);
            Periyot.Name = "Periyot";
            Periyot.Size = new Size(246, 36);
            Periyot.TabIndex = 55;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(20, 234);
            label10.Name = "label10";
            label10.Size = new Size(170, 34);
            label10.TabIndex = 56;
            label10.Text = "Ödeme Ayı";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(165, 545);
            button2.Name = "button2";
            button2.Size = new Size(136, 63);
            button2.TabIndex = 58;
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
            button1.Location = new Point(8, 545);
            button1.Name = "button1";
            button1.Size = new Size(136, 63);
            button1.TabIndex = 57;
            button1.Text = "Ödeme";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(84, 623);
            button4.Name = "button4";
            button4.Size = new Size(136, 63);
            button4.TabIndex = 59;
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
            pictureBox2.TabIndex = 61;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(504, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // AdSoyadCb
            // 
            AdSoyadCb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AdSoyadCb.ForeColor = SystemColors.Highlight;
            AdSoyadCb.FormattingEnabled = true;
            AdSoyadCb.Items.AddRange(new object[] { "Erkek", "Kadın" });
            AdSoyadCb.Location = new Point(21, 391);
            AdSoyadCb.Name = "AdSoyadCb";
            AdSoyadCb.Size = new Size(248, 35);
            AdSoyadCb.TabIndex = 63;
            AdSoyadCb.KeyPress += AdSoyadCb_KeyPress;
            // 
            // OdemeDGV
            // 
            OdemeDGV.AllowUserToAddRows = false;
            OdemeDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            OdemeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            OdemeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            OdemeDGV.DefaultCellStyle = dataGridViewCellStyle2;
            OdemeDGV.Location = new Point(328, 233);
            OdemeDGV.Name = "OdemeDGV";
            OdemeDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            OdemeDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            OdemeDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle4.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = Color.SkyBlue;
            OdemeDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            OdemeDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OdemeDGV.Size = new Size(757, 513);
            OdemeDGV.TabIndex = 64;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(852, 173);
            button3.Name = "button3";
            button3.Size = new Size(136, 54);
            button3.TabIndex = 68;
            button3.Text = "Yenile";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Highlight;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.ForeColor = Color.White;
            button5.Location = new Point(698, 173);
            button5.Name = "button5";
            button5.Size = new Size(136, 54);
            button5.TabIndex = 67;
            button5.Text = "Ara";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // AraTb
            // 
            AraTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AraTb.ForeColor = SystemColors.Highlight;
            AraTb.Location = new Point(426, 191);
            AraTb.Name = "AraTb";
            AraTb.Size = new Size(248, 36);
            AraTb.TabIndex = 66;
            AraTb.KeyPress += AraTb_KeyPress;
            // 
            // Odeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1095, 790);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(AraTb);
            Controls.Add(OdemeDGV);
            Controls.Add(AdSoyadCb);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(Periyot);
            Controls.Add(label5);
            Controls.Add(OdemeTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Odeme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Odeme";
            Load += Odeme_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)OdemeDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox OdemeTb;
        private Label label4;
        private DateTimePicker Periyot;
        private Label label10;
        private Button button2;
        private Button button1;
        private Button button4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox AdSoyadCb;
        private DataGridView OdemeDGV;
        private Button button3;
        private Button button5;
        private TextBox AraTb;
    }
}