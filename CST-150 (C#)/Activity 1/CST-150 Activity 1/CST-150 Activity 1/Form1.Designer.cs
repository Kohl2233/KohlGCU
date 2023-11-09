namespace CST_150_Activity_1
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
            lblEarth = new Label();
            txtEarthWeight = new TextBox();
            lblMars = new Label();
            lblMarsWeight = new Label();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // lblEarth
            // 
            lblEarth.AutoSize = true;
            lblEarth.Location = new Point(116, 57);
            lblEarth.Name = "lblEarth";
            lblEarth.Size = new Size(279, 15);
            lblEarth.TabIndex = 0;
            lblEarth.Text = "Enter your weight on Earth:                                      lbs";
            // 
            // txtEarthWeight
            // 
            txtEarthWeight.Location = new Point(272, 49);
            txtEarthWeight.Name = "txtEarthWeight";
            txtEarthWeight.Size = new Size(100, 23);
            txtEarthWeight.TabIndex = 1;
            // 
            // lblMars
            // 
            lblMars.AutoSize = true;
            lblMars.Location = new Point(116, 101);
            lblMars.Name = "lblMars";
            lblMars.Size = new Size(119, 15);
            lblMars.TabIndex = 2;
            lblMars.Text = "Your weight on Mars:";
            lblMars.TextAlign = ContentAlignment.TopRight;
            // 
            // lblMarsWeight
            // 
            lblMarsWeight.AutoSize = true;
            lblMarsWeight.BackColor = SystemColors.ControlLight;
            lblMarsWeight.ForeColor = SystemColors.ActiveCaptionText;
            lblMarsWeight.Location = new Point(272, 101);
            lblMarsWeight.Name = "lblMarsWeight";
            lblMarsWeight.Size = new Size(32, 15);
            lblMarsWeight.TabIndex = 3;
            lblMarsWeight.Text = "label";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(213, 157);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += ConvertButtonClickEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConvert);
            Controls.Add(lblMarsWeight);
            Controls.Add(lblMars);
            Controls.Add(txtEarthWeight);
            Controls.Add(lblEarth);
            Name = "Form1";
            Text = "Your Weight on Mars";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEarth;
        private TextBox txtEarthWeight;
        private Label lblMars;
        private Label lblMarsWeight;
        private Button btnConvert;
    }
}