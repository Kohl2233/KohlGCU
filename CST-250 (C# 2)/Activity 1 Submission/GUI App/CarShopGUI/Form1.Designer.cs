namespace CarShopGUI
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
            groupBox1 = new GroupBox();
            lblYear = new Label();
            lblColor = new Label();
            lblPrice = new Label();
            lblModel = new Label();
            lblMake = new Label();
            btnCreate = new Button();
            txtYear = new TextBox();
            txtColor = new TextBox();
            txtPrice = new TextBox();
            txtModel = new TextBox();
            txtMake = new TextBox();
            groupBox2 = new GroupBox();
            lbInventory = new ListBox();
            btnAddCart = new Button();
            groupBox3 = new GroupBox();
            lbShoppingCart = new ListBox();
            btnCheckout = new Button();
            lblGrandTotal = new Label();
            lblTotal = new Label();
            lblError = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblYear);
            groupBox1.Controls.Add(lblColor);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(lblModel);
            groupBox1.Controls.Add(lblMake);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(txtMake);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 205);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create a Car";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblYear.Location = new Point(6, 140);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(40, 21);
            lblYear.TabIndex = 8;
            lblYear.Text = "Year";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblColor.Location = new Point(6, 111);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(48, 21);
            lblColor.TabIndex = 7;
            lblColor.Text = "Color";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(6, 82);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 21);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblModel.Location = new Point(6, 53);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(54, 21);
            lblModel.TabIndex = 5;
            lblModel.Text = "Model";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMake.Location = new Point(6, 24);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(48, 21);
            lblMake.TabIndex = 4;
            lblMake.Text = "Make";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(6, 167);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(188, 32);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create Car";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(94, 138);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 1;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(94, 109);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(94, 80);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 1;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(94, 51);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 1;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(94, 22);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(100, 23);
            txtMake.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbInventory);
            groupBox2.Location = new Point(218, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 205);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Store Inventory";
            // 
            // lbInventory
            // 
            lbInventory.FormattingEnabled = true;
            lbInventory.ItemHeight = 15;
            lbInventory.Location = new Point(6, 19);
            lbInventory.Name = "lbInventory";
            lbInventory.Size = new Size(188, 169);
            lbInventory.TabIndex = 0;
            // 
            // btnAddCart
            // 
            btnAddCart.Location = new Point(424, 105);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(84, 23);
            btnAddCart.TabIndex = 2;
            btnAddCart.Text = "Add to Cart";
            btnAddCart.UseVisualStyleBackColor = true;
            btnAddCart.Click += btnAddCart_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbShoppingCart);
            groupBox3.Location = new Point(514, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 205);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Shopping Cart";
            // 
            // lbShoppingCart
            // 
            lbShoppingCart.FormattingEnabled = true;
            lbShoppingCart.ItemHeight = 15;
            lbShoppingCart.Location = new Point(6, 19);
            lbShoppingCart.Name = "lbShoppingCart";
            lbShoppingCart.Size = new Size(188, 169);
            lbShoppingCart.TabIndex = 0;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(633, 223);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(75, 23);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGrandTotal.Location = new Point(514, 251);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(92, 21);
            lblGrandTotal.TabIndex = 5;
            lblGrandTotal.Text = "Grand Total:";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(633, 251);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(75, 23);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "lblTotal";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(12, 223);
            lblError.Name = "lblError";
            lblError.Size = new Size(38, 15);
            lblError.TabIndex = 7;
            lblError.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 281);
            Controls.Add(lblError);
            Controls.Add(lblTotal);
            Controls.Add(lblGrandTotal);
            Controls.Add(btnCheckout);
            Controls.Add(groupBox3);
            Controls.Add(btnAddCart);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Car Shop GUI";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblYear;
        private Label lblColor;
        private Label lblPrice;
        private Label lblModel;
        private Label lblMake;
        private Button btnCreate;
        private TextBox txtYear;
        private TextBox txtColor;
        private TextBox txtPrice;
        private TextBox txtModel;
        private TextBox txtMake;
        private GroupBox groupBox2;
        private ListBox lbInventory;
        private Button btnAddCart;
        private GroupBox groupBox3;
        private ListBox lbShoppingCart;
        private Button btnCheckout;
        private Label lblGrandTotal;
        private Label lblTotal;
        private Label lblError;
    }
}