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
            cBoxSafe = new CheckBox();
            lblMapSize = new Label();
            comBoxSize = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picboxRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxLeft).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Tiktok", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MINE SWEEPER";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Location = new Point(148, 69);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(89, 15);
            lblDifficulty.TabIndex = 1;
            lblDifficulty.Text = "Select Difficulty";
            // 
            // btnStart
            // 
            btnStart.BackgroundImageLayout = ImageLayout.Zoom;
            btnStart.Cursor = Cursors.Hand;
            btnStart.Font = new Font("Tiktok", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(124, 299);
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
            cboxEasy.Location = new Point(148, 125);
            cboxEasy.Name = "cboxEasy";
            cboxEasy.Size = new Size(49, 19);
            cboxEasy.TabIndex = 4;
            cboxEasy.Text = "Easy";
            cboxEasy.TextAlign = ContentAlignment.MiddleCenter;
            cboxEasy.UseVisualStyleBackColor = true;
            cboxEasy.CheckedChanged += CheckBoxEasy_CheckedChangedEventHandler;
            // 
            // cboxModerate
            // 
            cboxModerate.AutoSize = true;
            cboxModerate.Location = new Point(148, 150);
            cboxModerate.Name = "cboxModerate";
            cboxModerate.Size = new Size(77, 19);
            cboxModerate.TabIndex = 5;
            cboxModerate.Text = "Moderate";
            cboxModerate.TextAlign = ContentAlignment.MiddleCenter;
            cboxModerate.UseVisualStyleBackColor = true;
            cboxModerate.CheckedChanged += CheckBoxModerate_CheckedChangedEventHandler;
            // 
            // cboxHard
            // 
            cboxHard.AutoSize = true;
            cboxHard.Location = new Point(148, 175);
            cboxHard.Name = "cboxHard";
            cboxHard.Size = new Size(52, 19);
            cboxHard.TabIndex = 6;
            cboxHard.Text = "Hard";
            cboxHard.TextAlign = ContentAlignment.MiddleCenter;
            cboxHard.UseVisualStyleBackColor = true;
            cboxHard.CheckedChanged += CheckBoxHard_CheckedChangedEventHandler;
            // 
            // cboxNightmare
            // 
            cboxNightmare.AutoSize = true;
            cboxNightmare.Location = new Point(148, 200);
            cboxNightmare.Name = "cboxNightmare";
            cboxNightmare.Size = new Size(158, 19);
            cboxNightmare.TabIndex = 7;
            cboxNightmare.Text = "Nightmare (please don't)";
            cboxNightmare.TextAlign = ContentAlignment.MiddleCenter;
            cboxNightmare.UseVisualStyleBackColor = true;
            cboxNightmare.CheckedChanged += CheckBoxNightmare_CheckedChangedEventHandler;
            // 
            // picboxRight
            // 
            picboxRight.BackgroundImage = Properties.Resources.sprBomb;
            picboxRight.BackgroundImageLayout = ImageLayout.Zoom;
            picboxRight.Location = new Point(319, 8);
            picboxRight.Name = "picboxRight";
            picboxRight.Size = new Size(53, 50);
            picboxRight.TabIndex = 8;
            picboxRight.TabStop = false;
            // 
            // picboxLeft
            // 
            picboxLeft.BackgroundImage = Properties.Resources.sprBomb;
            picboxLeft.BackgroundImageLayout = ImageLayout.Zoom;
            picboxLeft.Location = new Point(12, 8);
            picboxLeft.Name = "picboxLeft";
            picboxLeft.Size = new Size(53, 50);
            picboxLeft.TabIndex = 10;
            picboxLeft.TabStop = false;
            // 
            // cBoxSafe
            // 
            cBoxSafe.AutoSize = true;
            cBoxSafe.Location = new Point(148, 100);
            cBoxSafe.Name = "cBoxSafe";
            cBoxSafe.Size = new Size(95, 19);
            cBoxSafe.TabIndex = 11;
            cBoxSafe.Text = "Safe (testing)";
            cBoxSafe.UseVisualStyleBackColor = true;
            cBoxSafe.CheckedChanged += CheckBoxSafe_CheckedChangedEventHandler;
            // 
            // lblMapSize
            // 
            lblMapSize.AutoSize = true;
            lblMapSize.Location = new Point(102, 259);
            lblMapSize.Name = "lblMapSize";
            lblMapSize.Size = new Size(54, 15);
            lblMapSize.TabIndex = 12;
            lblMapSize.Text = "Map Size";
            // 
            // comBoxSize
            // 
            comBoxSize.FormattingEnabled = true;
            comBoxSize.Items.AddRange(new object[] { "Small", "Large", "Huge", "Gigantic" });
            comBoxSize.Location = new Point(162, 256);
            comBoxSize.Name = "comBoxSize";
            comBoxSize.Size = new Size(121, 23);
            comBoxSize.TabIndex = 13;
            // 
            // FrmDifficulty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(comBoxSize);
            Controls.Add(lblMapSize);
            Controls.Add(cBoxSafe);
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
        private CheckBox cBoxSafe;
        private Label lblMapSize;
        private ComboBox comBoxSize;
    }
}