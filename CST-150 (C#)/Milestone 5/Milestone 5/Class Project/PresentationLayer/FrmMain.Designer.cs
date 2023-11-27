namespace Class_Project
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
            btnDisplayInventory = new Button();
            openFileDialog1 = new OpenFileDialog();
            gvInventoryGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvInventoryGrid).BeginInit();
            SuspendLayout();
            // 
            // btnDisplayInventory
            // 
            btnDisplayInventory.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisplayInventory.Location = new Point(641, 73);
            btnDisplayInventory.Name = "btnDisplayInventory";
            btnDisplayInventory.Size = new Size(147, 33);
            btnDisplayInventory.TabIndex = 0;
            btnDisplayInventory.Text = "Display Inventory";
            btnDisplayInventory.UseVisualStyleBackColor = true;
            btnDisplayInventory.Click += DisplayInvBtnClickEvent;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // gvInventoryGrid
            // 
            gvInventoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInventoryGrid.Location = new Point(12, 73);
            gvInventoryGrid.Name = "gvInventoryGrid";
            gvInventoryGrid.RowTemplate.Height = 25;
            gvInventoryGrid.Size = new Size(623, 365);
            gvInventoryGrid.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(gvInventoryGrid);
            Controls.Add(btnDisplayInventory);
            Name = "FrmMain";
            Text = "Inventory Manager";
            Load += OnFormLoadEventHandler;
            ((System.ComponentModel.ISupportInitialize)gvInventoryGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplayInventory;
        private OpenFileDialog openFileDialog1;
        private DataGridView gvInventoryGrid;
    }
}