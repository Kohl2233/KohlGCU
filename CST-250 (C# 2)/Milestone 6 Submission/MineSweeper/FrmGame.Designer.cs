namespace MineSweeper
{
    partial class FrmGame
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
            components = new System.ComponentModel.Container();
            panelButtons = new Panel();
            lblHeader = new Label();
            timerHeader = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelButtons.AutoSize = true;
            panelButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelButtons.BackColor = SystemColors.Control;
            panelButtons.Location = new Point(42, 50);
            panelButtons.Margin = new Padding(50);
            panelButtons.MinimumSize = new Size(700, 700);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(700, 700);
            panelButtons.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(378, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(364, 31);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "label1";
            lblHeader.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timerHeader
            // 
            timerHeader.Enabled = true;
            timerHeader.Tick += TimerHeader_Tick;
            // 
            // FrmGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(lblHeader);
            Controls.Add(panelButtons);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mine Sweeper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelButtons;
        private Label lblHeader;
        private System.Windows.Forms.Timer timerHeader;
    }
}