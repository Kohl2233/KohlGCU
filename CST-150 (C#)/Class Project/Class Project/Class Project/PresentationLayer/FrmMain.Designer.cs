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
            btnReloadInventory = new Button();
            gvInventoryGrid = new DataGridView();
            label1 = new Label();
            btnCreateMovie = new Button();
            btnInspectMovie = new Button();
            btnIncreaseQty = new Button();
            btnDecreaseQty = new Button();
            lblSelectedMovie = new Label();
            btnRemoveMovie = new Button();
            ((System.ComponentModel.ISupportInitialize)gvInventoryGrid).BeginInit();
            SuspendLayout();
            // 
            // btnReloadInventory
            // 
            btnReloadInventory.Cursor = Cursors.Hand;
            btnReloadInventory.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReloadInventory.Location = new Point(733, 68);
            btnReloadInventory.Name = "btnReloadInventory";
            btnReloadInventory.Size = new Size(168, 31);
            btnReloadInventory.TabIndex = 0;
            btnReloadInventory.Text = "Reload Inventory";
            btnReloadInventory.UseVisualStyleBackColor = true;
            btnReloadInventory.Click += btnReloadInventory_ClickEventHandler;
            // 
            // gvInventoryGrid
            // 
            gvInventoryGrid.AllowUserToAddRows = false;
            gvInventoryGrid.AllowUserToDeleteRows = false;
            gvInventoryGrid.AllowUserToResizeColumns = false;
            gvInventoryGrid.AllowUserToResizeRows = false;
            gvInventoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvInventoryGrid.BackgroundColor = SystemColors.ControlDarkDark;
            gvInventoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInventoryGrid.Location = new Point(14, 68);
            gvInventoryGrid.Name = "gvInventoryGrid";
            gvInventoryGrid.RowTemplate.Height = 25;
            gvInventoryGrid.ScrollBars = ScrollBars.Vertical;
            gvInventoryGrid.Size = new Size(712, 341);
            gvInventoryGrid.TabIndex = 1;
            gvInventoryGrid.Click += InventoryGrid_ClickEventHandler;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 46);
            label1.TabIndex = 2;
            label1.Text = "Joes Movie Shack";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCreateMovie
            // 
            btnCreateMovie.Cursor = Cursors.Hand;
            btnCreateMovie.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateMovie.Location = new Point(732, 105);
            btnCreateMovie.Name = "btnCreateMovie";
            btnCreateMovie.Size = new Size(168, 31);
            btnCreateMovie.TabIndex = 3;
            btnCreateMovie.Text = "Create Movie";
            btnCreateMovie.UseVisualStyleBackColor = true;
            btnCreateMovie.Click += BtnCreateMovie_ClickEventHandler;
            // 
            // btnInspectMovie
            // 
            btnInspectMovie.Cursor = Cursors.Hand;
            btnInspectMovie.Enabled = false;
            btnInspectMovie.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInspectMovie.Location = new Point(732, 267);
            btnInspectMovie.Name = "btnInspectMovie";
            btnInspectMovie.Size = new Size(168, 31);
            btnInspectMovie.TabIndex = 4;
            btnInspectMovie.Text = "Inspect Movie";
            btnInspectMovie.UseVisualStyleBackColor = true;
            // 
            // btnIncreaseQty
            // 
            btnIncreaseQty.Cursor = Cursors.Hand;
            btnIncreaseQty.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIncreaseQty.Location = new Point(733, 304);
            btnIncreaseQty.Name = "btnIncreaseQty";
            btnIncreaseQty.Size = new Size(168, 31);
            btnIncreaseQty.TabIndex = 5;
            btnIncreaseQty.Text = "Increase Qty";
            btnIncreaseQty.UseVisualStyleBackColor = true;
            btnIncreaseQty.Click += BtnIncreaseQty_ClickEventHandler;
            // 
            // btnDecreaseQty
            // 
            btnDecreaseQty.Cursor = Cursors.Hand;
            btnDecreaseQty.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecreaseQty.Location = new Point(734, 341);
            btnDecreaseQty.Name = "btnDecreaseQty";
            btnDecreaseQty.Size = new Size(168, 31);
            btnDecreaseQty.TabIndex = 6;
            btnDecreaseQty.Text = "Decrease Qty";
            btnDecreaseQty.UseVisualStyleBackColor = true;
            btnDecreaseQty.Click += BtnDecreaseQty_ClickEventHandler;
            // 
            // lblSelectedMovie
            // 
            lblSelectedMovie.BackColor = Color.MistyRose;
            lblSelectedMovie.Font = new Font("Verdana", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblSelectedMovie.Location = new Point(732, 212);
            lblSelectedMovie.Name = "lblSelectedMovie";
            lblSelectedMovie.Size = new Size(166, 52);
            lblSelectedMovie.TabIndex = 7;
            lblSelectedMovie.Text = "Row Index: 0";
            lblSelectedMovie.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRemoveMovie
            // 
            btnRemoveMovie.Cursor = Cursors.Hand;
            btnRemoveMovie.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveMovie.Location = new Point(734, 378);
            btnRemoveMovie.Name = "btnRemoveMovie";
            btnRemoveMovie.Size = new Size(168, 31);
            btnRemoveMovie.TabIndex = 8;
            btnRemoveMovie.Text = "Remove Movie";
            btnRemoveMovie.UseVisualStyleBackColor = true;
            btnRemoveMovie.Click += BtnRemoveMovie_ClickEventHandler;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(914, 420);
            Controls.Add(btnRemoveMovie);
            Controls.Add(lblSelectedMovie);
            Controls.Add(btnDecreaseQty);
            Controls.Add(btnIncreaseQty);
            Controls.Add(btnInspectMovie);
            Controls.Add(btnCreateMovie);
            Controls.Add(label1);
            Controls.Add(gvInventoryGrid);
            Controls.Add(btnReloadInventory);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmMain";
            Text = "Inventory Manager";
            Load += OnFormLoadEventHandler;
            ((System.ComponentModel.ISupportInitialize)gvInventoryGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReloadInventory;
        private DataGridView gvInventoryGrid;
        private Label label1;
        private Button btnCreateMovie;
        private Button btnInspectMovie;
        private Button btnIncreaseQty;
        private Button btnDecreaseQty;
        private Label lblSelectedMovie;
        private Button btnRemoveMovie;
    }
}