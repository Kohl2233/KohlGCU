namespace HelloWorldFormsApp
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
            btnHelloButtonTest = new Button();
            lblHelloWorldLabel = new Label();
            SuspendLayout();
            // 
            // btnHelloButtonTest
            // 
            btnHelloButtonTest.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHelloButtonTest.ForeColor = SystemColors.MenuHighlight;
            btnHelloButtonTest.Location = new Point(332, 239);
            btnHelloButtonTest.Name = "btnHelloButtonTest";
            btnHelloButtonTest.Size = new Size(126, 29);
            btnHelloButtonTest.TabIndex = 0;
            btnHelloButtonTest.Text = "HelloWorldWork";
            btnHelloButtonTest.UseVisualStyleBackColor = true;
            btnHelloButtonTest.Click += ButtonOnClick;
            // 
            // lblHelloWorldLabel
            // 
            lblHelloWorldLabel.AutoSize = true;
            lblHelloWorldLabel.BackColor = SystemColors.ActiveCaption;
            lblHelloWorldLabel.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblHelloWorldLabel.Location = new Point(353, 199);
            lblHelloWorldLabel.Name = "lblHelloWorldLabel";
            lblHelloWorldLabel.Size = new Size(89, 37);
            lblHelloWorldLabel.TabIndex = 1;
            lblHelloWorldLabel.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHelloWorldLabel);
            Controls.Add(btnHelloButtonTest);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHelloButtonTest;
        private Label lblHelloWorldLabel;
    }
}