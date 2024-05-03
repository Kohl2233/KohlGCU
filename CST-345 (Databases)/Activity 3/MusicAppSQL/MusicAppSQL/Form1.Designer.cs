namespace MusicAppSQL
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            lbl_albumName = new Label();
            txt_albumName = new TextBox();
            txt_artist = new TextBox();
            lbl_artist = new Label();
            txt_year = new TextBox();
            label1 = new Label();
            txt_url = new TextBox();
            label2 = new Label();
            txt_description = new TextBox();
            label3 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(211, 13);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(211, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(577, 397);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(340, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(509, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_url);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_year);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_artist);
            groupBox1.Controls.Add(lbl_artist);
            groupBox1.Controls.Add(txt_albumName);
            groupBox1.Controls.Add(lbl_albumName);
            groupBox1.Location = new Point(12, 240);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 198);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Album";
            // 
            // lbl_albumName
            // 
            lbl_albumName.AutoSize = true;
            lbl_albumName.Location = new Point(6, 19);
            lbl_albumName.Name = "lbl_albumName";
            lbl_albumName.Size = new Size(78, 15);
            lbl_albumName.TabIndex = 0;
            lbl_albumName.Text = "Album Name";
            // 
            // txt_albumName
            // 
            txt_albumName.Location = new Point(90, 16);
            txt_albumName.Name = "txt_albumName";
            txt_albumName.Size = new Size(97, 23);
            txt_albumName.TabIndex = 1;
            // 
            // txt_artist
            // 
            txt_artist.Location = new Point(90, 44);
            txt_artist.Name = "txt_artist";
            txt_artist.Size = new Size(97, 23);
            txt_artist.TabIndex = 3;
            // 
            // lbl_artist
            // 
            lbl_artist.AutoSize = true;
            lbl_artist.Location = new Point(6, 47);
            lbl_artist.Name = "lbl_artist";
            lbl_artist.Size = new Size(35, 15);
            lbl_artist.TabIndex = 2;
            lbl_artist.Text = "Artist";
            // 
            // txt_year
            // 
            txt_year.Location = new Point(90, 73);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(97, 23);
            txt_year.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 76);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 4;
            label1.Text = "Year";
            // 
            // txt_url
            // 
            txt_url.Location = new Point(90, 102);
            txt_url.Name = "txt_url";
            txt_url.Size = new Size(97, 23);
            txt_url.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 105);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "Image URL";
            // 
            // txt_description
            // 
            txt_description.Location = new Point(90, 131);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(97, 23);
            txt_description.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 134);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 8;
            label3.Text = "Description";
            // 
            // button3
            // 
            button3.Location = new Point(112, 169);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Create";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label lbl_albumName;
        private Button button3;
        private TextBox txt_description;
        private Label label3;
        private TextBox txt_url;
        private Label label2;
        private TextBox txt_year;
        private Label label1;
        private TextBox txt_artist;
        private Label lbl_artist;
        private TextBox txt_albumName;
    }
}