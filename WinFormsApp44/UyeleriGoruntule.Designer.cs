namespace WinFormsApp44
{
    partial class UyeleriGoruntule
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeleriGoruntule));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            UyeDGV = new DataGridView();
            AraUyeTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)UyeDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(454, 70);
            label2.Name = "label2";
            label2.Size = new Size(209, 37);
            label2.TabIndex = 5;
            label2.Text = "Üyeleri Listele";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(441, 18);
            label1.Name = "label1";
            label1.Size = new Size(245, 40);
            label1.TabIndex = 4;
            label1.Text = "Fitness Center";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1061, 9);
            label3.Name = "label3";
            label3.Size = new Size(37, 37);
            label3.TabIndex = 39;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // UyeDGV
            // 
            UyeDGV.AllowUserToAddRows = false;
            UyeDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UyeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UyeDGV.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            UyeDGV.DefaultCellStyle = dataGridViewCellStyle2;
            UyeDGV.Location = new Point(25, 244);
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
            dataGridViewCellStyle4.BackColor = Color.Silver;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle4.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle4.SelectionForeColor = Color.SkyBlue;
            UyeDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            UyeDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UyeDGV.Size = new Size(1050, 513);
            UyeDGV.TabIndex = 41;
            // 
            // AraUyeTb
            // 
            AraUyeTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AraUyeTb.ForeColor = SystemColors.Highlight;
            AraUyeTb.Location = new Point(255, 186);
            AraUyeTb.Name = "AraUyeTb";
            AraUyeTb.Size = new Size(248, 36);
            AraUyeTb.TabIndex = 42;
            AraUyeTb.KeyPress += AraUyeTb_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(527, 168);
            button1.Name = "button1";
            button1.Size = new Size(136, 54);
            button1.TabIndex = 43;
            button1.Text = "Ara";
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
            button2.Location = new Point(681, 168);
            button2.Name = "button2";
            button2.Size = new Size(136, 54);
            button2.TabIndex = 44;
            button2.Text = "Yenile";
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
            button4.Location = new Point(454, 763);
            button4.Name = "button4";
            button4.Size = new Size(177, 63);
            button4.TabIndex = 45;
            button4.Text = "Geri";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // UyeleriGoruntule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1110, 828);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AraUyeTb);
            Controls.Add(UyeDGV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UyeleriGoruntule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UyeleriGoruntule";
            Load += UyeleriGoruntule_Load;
            ((System.ComponentModel.ISupportInitialize)UyeDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView UyeDGV;
        private TextBox AraUyeTb;
        private Button button1;
        private Button button2;
        private Button button4;
        private PictureBox pictureBox2;
    }
}