namespace CST_150_ListTogv
{
    partial class FrmInventory
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
            gvInv = new DataGridView();
            button1 = new Button();
            lblSelectedIndex = new Label();
            ((System.ComponentModel.ISupportInitialize)gvInv).BeginInit();
            SuspendLayout();
            // 
            // gvInv
            // 
            gvInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInv.Location = new Point(12, 49);
            gvInv.Name = "gvInv";
            gvInv.RowTemplate.Height = 25;
            gvInv.Size = new Size(337, 389);
            gvInv.TabIndex = 0;
            gvInv.Click += GridView_ClickEventHandler;
            // 
            // button1
            // 
            button1.Location = new Point(242, 12);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 1;
            button1.Text = "Inc Qty";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnIncQty_ClickEventHandler;
            // 
            // lblSelectedIndex
            // 
            lblSelectedIndex.AutoSize = true;
            lblSelectedIndex.Location = new Point(12, 12);
            lblSelectedIndex.Name = "lblSelectedIndex";
            lblSelectedIndex.Size = new Size(38, 15);
            lblSelectedIndex.TabIndex = 2;
            lblSelectedIndex.Text = "label1";
            // 
            // FrmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSelectedIndex);
            Controls.Add(button1);
            Controls.Add(gvInv);
            Name = "FrmInventory";
            Text = "Form1";
            Load += PopulateGrid_LoadEventHandler;
            ((System.ComponentModel.ISupportInitialize)gvInv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvInv;
        private Button button1;
        private Label lblSelectedIndex;
    }
}