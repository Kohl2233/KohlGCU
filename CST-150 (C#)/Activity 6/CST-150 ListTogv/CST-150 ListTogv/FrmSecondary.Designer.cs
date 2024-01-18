namespace CST_150_ListTogv
{
    partial class FrmSecondary
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
            gvSearchResults = new DataGridView();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)gvSearchResults).BeginInit();
            SuspendLayout();
            // 
            // gvSearchResults
            // 
            gvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvSearchResults.Location = new Point(115, 86);
            gvSearchResults.Name = "gvSearchResults";
            gvSearchResults.RowTemplate.Height = 25;
            gvSearchResults.Size = new Size(572, 196);
            gvSearchResults.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(612, 288);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit ";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_ClickEventHandler;
            // 
            // FrmSecondary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(gvSearchResults);
            Name = "FrmSecondary";
            Text = "FrmSecondary";
            Load += FrmLoad_EventHandler;
            ((System.ComponentModel.ISupportInitialize)gvSearchResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gvSearchResults;
        private Button btnExit;
    }
}