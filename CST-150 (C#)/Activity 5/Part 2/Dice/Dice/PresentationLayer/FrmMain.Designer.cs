namespace Dice
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            button1 = new Button();
            pbDieImage = new PictureBox();
            lblRollResult = new Label();
            ((System.ComponentModel.ISupportInitialize)pbDieImage).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(441, 319);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(96, 28);
            button1.TabIndex = 0;
            button1.Text = "Roll Die!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnRollDieClickEventHandler;
            // 
            // pbDieImage
            // 
            pbDieImage.Image = (Image)resources.GetObject("pbDieImage.Image");
            pbDieImage.InitialImage = (Image)resources.GetObject("pbDieImage.InitialImage");
            pbDieImage.Location = new Point(306, 69);
            pbDieImage.Name = "pbDieImage";
            pbDieImage.Size = new Size(366, 243);
            pbDieImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDieImage.TabIndex = 1;
            pbDieImage.TabStop = false;
            // 
            // lblRollResult
            // 
            lblRollResult.AutoSize = true;
            lblRollResult.Location = new Point(461, 370);
            lblRollResult.Name = "lblRollResult";
            lblRollResult.Size = new Size(50, 18);
            lblRollResult.TabIndex = 2;
            lblRollResult.Text = "label1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 540);
            Controls.Add(lblRollResult);
            Controls.Add(pbDieImage);
            Controls.Add(button1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmMain";
            Text = "Dice";
            ((System.ComponentModel.ISupportInitialize)pbDieImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pbDieImage;
        private Label lblRollResult;
    }
}
