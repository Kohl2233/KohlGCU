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
            btnDelete = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)gvInv).BeginInit();
            SuspendLayout();
            // 
            // gvInv
            // 
            gvInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInv.Location = new Point(12, 49);
            gvInv.Name = "gvInv";
            gvInv.RowTemplate.Height = 25;
            gvInv.Size = new Size(337, 345);
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
            // btnDelete
            // 
            btnDelete.Location = new Point(141, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDeleteItem_ClickEventHandler;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 411);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 4;
            label1.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(75, 409);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(232, 23);
            txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(313, 408);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(36, 24);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Go";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_ClickEventHandler;
            // 
            // FrmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnDelete);
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
        private Button btnDelete;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}