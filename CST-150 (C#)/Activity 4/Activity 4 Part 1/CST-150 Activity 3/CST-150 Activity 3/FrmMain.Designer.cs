namespace CST_150_Activity_3
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
            btnReadFile = new Button();
            lblSelectedFile = new Label();
            lblResults = new Label();
            openFileDialog1 = new OpenFileDialog();
            lblSelectRow = new Label();
            cmbSelectRow = new ComboBox();
            SuspendLayout();
            // 
            // btnReadFile
            // 
            btnReadFile.BackColor = Color.ForestGreen;
            btnReadFile.Cursor = Cursors.Hand;
            btnReadFile.FlatAppearance.BorderColor = Color.Black;
            btnReadFile.FlatAppearance.MouseDownBackColor = Color.DarkOliveGreen;
            btnReadFile.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnReadFile.FlatStyle = FlatStyle.Flat;
            btnReadFile.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReadFile.ForeColor = Color.WhiteSmoke;
            btnReadFile.Location = new Point(330, 44);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(137, 48);
            btnReadFile.TabIndex = 0;
            btnReadFile.Text = "Read File";
            btnReadFile.UseVisualStyleBackColor = false;
            btnReadFile.Click += BtnReadFileClickEvent;
            // 
            // lblSelectedFile
            // 
            lblSelectedFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectedFile.ForeColor = Color.Firebrick;
            lblSelectedFile.Location = new Point(12, 105);
            lblSelectedFile.Name = "lblSelectedFile";
            lblSelectedFile.Size = new Size(776, 23);
            lblSelectedFile.TabIndex = 1;
            lblSelectedFile.Text = "lblSelectedFile";
            lblSelectedFile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResults.Location = new Point(212, 165);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(107, 16);
            lblResults.TabIndex = 2;
            lblResults.Text = "lblResults";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblSelectRow
            // 
            lblSelectRow.AutoSize = true;
            lblSelectRow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectRow.Location = new Point(171, 45);
            lblSelectRow.Name = "lblSelectRow";
            lblSelectRow.Size = new Size(86, 21);
            lblSelectRow.TabIndex = 3;
            lblSelectRow.Text = "Select Row";
            // 
            // cmbSelectRow
            // 
            cmbSelectRow.FormattingEnabled = true;
            cmbSelectRow.Location = new Point(155, 69);
            cmbSelectRow.Name = "cmbSelectRow";
            cmbSelectRow.Size = new Size(121, 23);
            cmbSelectRow.TabIndex = 4;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbSelectRow);
            Controls.Add(lblSelectRow);
            Controls.Add(lblResults);
            Controls.Add(lblSelectedFile);
            Controls.Add(btnReadFile);
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReadFile;
        private Label lblSelectedFile;
        private Label lblResults;
        private OpenFileDialog openFileDialog1;
        private Label lblSelectRow;
        private ComboBox cmbSelectRow;
    }
}