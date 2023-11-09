namespace CST_150_Activity_2
{
    partial class FrmSeconds
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
            label1 = new Label();
            txtUserEntry = new TextBox();
            label2 = new Label();
            btnRun = new Button();
            lblResults = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(109, 81);
            label1.Name = "label1";
            label1.Size = new Size(264, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Number of Seconds:";
            // 
            // txtUserEntry
            // 
            txtUserEntry.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserEntry.Location = new Point(370, 75);
            txtUserEntry.Name = "txtUserEntry";
            txtUserEntry.Size = new Size(161, 31);
            txtUserEntry.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(537, 81);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Seconds";
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRun.Location = new Point(404, 112);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(127, 28);
            btnRun.TabIndex = 3;
            btnRun.Text = "Apply Seconds";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += ManageSecondsEventHandler;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblResults.Location = new Point(109, 213);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(76, 25);
            lblResults.TabIndex = 4;
            lblResults.Text = "results";
            // 
            // FrmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResults);
            Controls.Add(btnRun);
            Controls.Add(label2);
            Controls.Add(txtUserEntry);
            Controls.Add(label1);
            Name = "FrmTest";
            Text = "Activity 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserEntry;
        private Label label2;
        private Button btnRun;
        private Label lblResults;
    }
}