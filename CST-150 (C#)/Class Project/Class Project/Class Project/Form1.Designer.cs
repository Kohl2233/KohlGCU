namespace Class_Project
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
            btnDisplayInventory = new Button();
            lblInventoryDisplay = new Label();
            lblInvDisplayHeader = new Label();
            SuspendLayout();
            // 
            // btnDisplayInventory
            // 
            btnDisplayInventory.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisplayInventory.Location = new Point(612, 73);
            btnDisplayInventory.Name = "btnDisplayInventory";
            btnDisplayInventory.Size = new Size(147, 33);
            btnDisplayInventory.TabIndex = 0;
            btnDisplayInventory.Text = "Display Inventory";
            btnDisplayInventory.UseVisualStyleBackColor = true;
            btnDisplayInventory.Click += DisplayInvBtnClickEvent;
            // 
            // lblInventoryDisplay
            // 
            lblInventoryDisplay.AutoSize = true;
            lblInventoryDisplay.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInventoryDisplay.Location = new Point(61, 100);
            lblInventoryDisplay.Name = "lblInventoryDisplay";
            lblInventoryDisplay.Size = new Size(100, 19);
            lblInventoryDisplay.TabIndex = 1;
            lblInventoryDisplay.Text = "lblInvDisplay";
            // 
            // lblInvDisplayHeader
            // 
            lblInvDisplayHeader.AutoSize = true;
            lblInvDisplayHeader.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInvDisplayHeader.Location = new Point(61, 77);
            lblInvDisplayHeader.Name = "lblInvDisplayHeader";
            lblInvDisplayHeader.Size = new Size(88, 19);
            lblInvDisplayHeader.TabIndex = 2;
            lblInvDisplayHeader.Text = "lblHeader";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInvDisplayHeader);
            Controls.Add(lblInventoryDisplay);
            Controls.Add(btnDisplayInventory);
            Name = "Form1";
            Text = "Inventory Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDisplayInventory;
        private Label lblInventoryDisplay;
        private Label lblInvDisplayHeader;
    }
}