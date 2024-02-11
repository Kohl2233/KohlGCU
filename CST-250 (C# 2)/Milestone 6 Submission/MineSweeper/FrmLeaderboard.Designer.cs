namespace MineSweeper
{
    partial class FrmLeaderboard
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panelScores = new Panel();
            lblFilePath = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tiktok", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(78, 23);
            label1.Name = "label1";
            label1.Size = new Size(152, 24);
            label1.TabIndex = 0;
            label1.Text = "LEADERBOARD";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.sprFlag;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(23, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.sprFlag;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(236, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panelScores
            // 
            panelScores.BackColor = Color.Black;
            panelScores.BorderStyle = BorderStyle.FixedSingle;
            panelScores.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panelScores.ForeColor = SystemColors.ActiveCaptionText;
            panelScores.Location = new Point(23, 82);
            panelScores.Name = "panelScores";
            panelScores.Size = new Size(262, 267);
            panelScores.TabIndex = 3;
            // 
            // lblFilePath
            // 
            lblFilePath.Location = new Point(23, 352);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(262, 89);
            lblFilePath.TabIndex = 4;
            lblFilePath.Text = "label2";
            // 
            // FrmLeaderboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(309, 450);
            Controls.Add(lblFilePath);
            Controls.Add(panelScores);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmLeaderboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leaderboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panelScores;
        private Label lblFilePath;
    }
}