namespace MineSweeper
{
    partial class FrmDifficulty
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
            lblTitle = new Label();
            lblDifficulty = new Label();
            btnStart = new Button();
            cboxEasy = new CheckBox();
            cboxModerate = new CheckBox();
            cboxHard = new CheckBox();
            cboxNightmare = new CheckBox();
            picboxRight = new PictureBox();
            picboxLeft = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picboxRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxLeft).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Tiktok", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MINE SWEEPER";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Location = new Point(148, 99);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(89, 15);
            lblDifficulty.TabIndex = 1;
            lblDifficulty.Text = "Select Difficulty";
            // 
            // btnStart
            // 
            btnStart.Cursor = Cursors.Hand;
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(124, 266);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(136, 32);
            btnStart.TabIndex = 3;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_ClickEventHandler;
            // 
            // cboxEasy
            // 
            cboxEasy.AutoSize = true;
            cboxEasy.Location = new Point(151, 136);
            cboxEasy.Name = "cboxEasy";
            cboxEasy.Size = new Size(49, 19);
            cboxEasy.TabIndex = 4;
            cboxEasy.Text = "Easy";
            cboxEasy.UseVisualStyleBackColor = true;
            cboxEasy.CheckedChanged += CheckBoxEasy_CheckedChangedEventHandler;
            // 
            // cboxModerate
            // 
            cboxModerate.AutoSize = true;
            cboxModerate.Location = new Point(151, 161);
            cboxModerate.Name = "cboxModerate";
            cboxModerate.Size = new Size(77, 19);
            cboxModerate.TabIndex = 5;
            cboxModerate.Text = "Moderate";
            cboxModerate.UseVisualStyleBackColor = true;
            cboxModerate.CheckedChanged += CheckBoxModerate_CheckedChangedEventHandler;
            // 
            // cboxHard
            // 
            cboxHard.AutoSize = true;
            cboxHard.Location = new Point(151, 186);
            cboxHard.Name = "cboxHard";
            cboxHard.Size = new Size(52, 19);
            cboxHard.TabIndex = 6;
            cboxHard.Text = "Hard";
            cboxHard.UseVisualStyleBackColor = true;
            cboxHard.CheckedChanged += CheckBoxHard_CheckedChangedEventHandler;
            // 
            // cboxNightmare
            // 
            cboxNightmare.AutoSize = true;
            cboxNightmare.Location = new Point(151, 211);
            cboxNightmare.Name = "cboxNightmare";
            cboxNightmare.Size = new Size(158, 19);
            cboxNightmare.TabIndex = 7;
            cboxNightmare.Text = "Nightmare (please don't)";
            cboxNightmare.UseVisualStyleBackColor = true;
            cboxNightmare.CheckedChanged += CheckBoxNightmare_CheckedChangedEventHandler;
            // 
            // picboxRight
            // 
            picboxRight.Location = new Point(319, 33);
            picboxRight.Name = "picboxRight";
            picboxRight.Size = new Size(53, 50);
            picboxRight.TabIndex = 8;
            picboxRight.TabStop = false;
            // 
            // picboxLeft
            // 
            picboxLeft.Location = new Point(12, 33);
            picboxLeft.Name = "picboxLeft";
            picboxLeft.Size = new Size(53, 50);
            picboxLeft.TabIndex = 10;
            picboxLeft.TabStop = false;
            // 
            // FrmDifficulty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(picboxLeft);
            Controls.Add(picboxRight);
            Controls.Add(cboxNightmare);
            Controls.Add(cboxHard);
            Controls.Add(cboxModerate);
            Controls.Add(cboxEasy);
            Controls.Add(btnStart);
            Controls.Add(lblDifficulty);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDifficulty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select Difficulty";
            ((System.ComponentModel.ISupportInitialize)picboxRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxLeft).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDifficulty;
        private Button btnStart;
        private CheckBox cboxEasy;
        private CheckBox cboxModerate;
        private CheckBox cboxHard;
        private CheckBox cboxNightmare;
        private PictureBox picboxRight;
        private PictureBox picboxLeft;
    }
}