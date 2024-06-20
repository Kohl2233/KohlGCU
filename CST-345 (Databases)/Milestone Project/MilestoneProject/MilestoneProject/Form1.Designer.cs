namespace MilestoneProject
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
            gBoxAddCategory = new GroupBox();
            btnAddCategory = new Button();
            txtCategoryDescription = new TextBox();
            lblCategoryDescription = new Label();
            txtCategoryName = new TextBox();
            lblCategoryName = new Label();
            lblCategoriesTable = new Label();
            btnShowCategories = new Button();
            txtCategorySearch = new TextBox();
            btnCategorySearch = new Button();
            btnDeleteCategory = new Button();
            dgvProductCategories = new DataGridView();
            dgvProducts = new DataGridView();
            btnDeleteProduct = new Button();
            btnProductSearch = new Button();
            txtProductSearch = new TextBox();
            btnShowProducts = new Button();
            lblProducts = new Label();
            groupBox1 = new GroupBox();
            btnCreateProduct = new Button();
            comBoxCategoryID = new ComboBox();
            lblProductCategoryID = new Label();
            txtProductPrice = new TextBox();
            lblProductPrice = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            gBoxAddCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxAddCategory
            // 
            gBoxAddCategory.Controls.Add(btnAddCategory);
            gBoxAddCategory.Controls.Add(txtCategoryDescription);
            gBoxAddCategory.Controls.Add(lblCategoryDescription);
            gBoxAddCategory.Controls.Add(txtCategoryName);
            gBoxAddCategory.Controls.Add(lblCategoryName);
            gBoxAddCategory.Location = new Point(12, 12);
            gBoxAddCategory.Name = "gBoxAddCategory";
            gBoxAddCategory.Size = new Size(277, 141);
            gBoxAddCategory.TabIndex = 0;
            gBoxAddCategory.TabStop = false;
            gBoxAddCategory.Text = "Add Category";
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(196, 111);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(75, 23);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "Create";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += BtnAddCategoryOnClick;
            // 
            // txtCategoryDescription
            // 
            txtCategoryDescription.Location = new Point(9, 82);
            txtCategoryDescription.Name = "txtCategoryDescription";
            txtCategoryDescription.Size = new Size(262, 23);
            txtCategoryDescription.TabIndex = 3;
            // 
            // lblCategoryDescription
            // 
            lblCategoryDescription.AutoSize = true;
            lblCategoryDescription.Location = new Point(6, 64);
            lblCategoryDescription.Name = "lblCategoryDescription";
            lblCategoryDescription.Size = new Size(67, 15);
            lblCategoryDescription.TabIndex = 2;
            lblCategoryDescription.Text = "Description";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(9, 37);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(262, 23);
            txtCategoryName.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(6, 19);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(90, 15);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "Category Name";
            // 
            // lblCategoriesTable
            // 
            lblCategoriesTable.AutoSize = true;
            lblCategoriesTable.Location = new Point(295, 12);
            lblCategoriesTable.Name = "lblCategoriesTable";
            lblCategoriesTable.Size = new Size(63, 15);
            lblCategoriesTable.TabIndex = 1;
            lblCategoriesTable.Text = "Categories";
            // 
            // btnShowCategories
            // 
            btnShowCategories.Location = new Point(364, 8);
            btnShowCategories.Name = "btnShowCategories";
            btnShowCategories.Size = new Size(127, 23);
            btnShowCategories.TabIndex = 2;
            btnShowCategories.Text = "Show all Categories";
            btnShowCategories.UseVisualStyleBackColor = true;
            btnShowCategories.Click += BtnShowAllCategoriesOnClick;
            // 
            // txtCategorySearch
            // 
            txtCategorySearch.Location = new Point(512, 8);
            txtCategorySearch.Name = "txtCategorySearch";
            txtCategorySearch.Size = new Size(184, 23);
            txtCategorySearch.TabIndex = 3;
            // 
            // btnCategorySearch
            // 
            btnCategorySearch.Location = new Point(702, 8);
            btnCategorySearch.Name = "btnCategorySearch";
            btnCategorySearch.Size = new Size(75, 23);
            btnCategorySearch.TabIndex = 4;
            btnCategorySearch.Text = "Search";
            btnCategorySearch.UseVisualStyleBackColor = true;
            btnCategorySearch.Click += BtnCategorySearchOnClick;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(787, 8);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(169, 23);
            btnDeleteCategory.TabIndex = 5;
            btnDeleteCategory.Text = "Delete Selected Category";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategoryOnClick;
            // 
            // dgvProductCategories
            // 
            dgvProductCategories.AllowUserToAddRows = false;
            dgvProductCategories.AllowUserToDeleteRows = false;
            dgvProductCategories.AllowUserToResizeColumns = false;
            dgvProductCategories.AllowUserToResizeRows = false;
            dgvProductCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductCategories.Location = new Point(295, 37);
            dgvProductCategories.MultiSelect = false;
            dgvProductCategories.Name = "dgvProductCategories";
            dgvProductCategories.ReadOnly = true;
            dgvProductCategories.RowTemplate.Height = 25;
            dgvProductCategories.Size = new Size(661, 194);
            dgvProductCategories.TabIndex = 6;
            dgvProductCategories.CellClick += DvgProductCategoriesOnCellClick;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(295, 269);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(661, 233);
            dgvProducts.TabIndex = 7;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(787, 240);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(169, 23);
            btnDeleteProduct.TabIndex = 12;
            btnDeleteProduct.Text = "Delete Selected Product";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += BtnDeleteProductOnClick;
            // 
            // btnProductSearch
            // 
            btnProductSearch.Location = new Point(702, 240);
            btnProductSearch.Name = "btnProductSearch";
            btnProductSearch.Size = new Size(75, 23);
            btnProductSearch.TabIndex = 11;
            btnProductSearch.Text = "Search";
            btnProductSearch.UseVisualStyleBackColor = true;
            btnProductSearch.Click += BtnProductSearchOnClick;
            // 
            // txtProductSearch
            // 
            txtProductSearch.Location = new Point(512, 240);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.Size = new Size(184, 23);
            txtProductSearch.TabIndex = 10;
            // 
            // btnShowProducts
            // 
            btnShowProducts.Location = new Point(364, 240);
            btnShowProducts.Name = "btnShowProducts";
            btnShowProducts.Size = new Size(127, 23);
            btnShowProducts.TabIndex = 9;
            btnShowProducts.Text = "Show all Products";
            btnShowProducts.UseVisualStyleBackColor = true;
            btnShowProducts.Click += BtnShowAllProductsOnClick;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(295, 244);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(54, 15);
            lblProducts.TabIndex = 8;
            lblProducts.Text = "Products";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCreateProduct);
            groupBox1.Controls.Add(comBoxCategoryID);
            groupBox1.Controls.Add(lblProductCategoryID);
            groupBox1.Controls.Add(txtProductPrice);
            groupBox1.Controls.Add(lblProductPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(lblProductName);
            groupBox1.Location = new Point(12, 244);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 190);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Product";
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Location = new Point(196, 160);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(75, 23);
            btnCreateProduct.TabIndex = 11;
            btnCreateProduct.Text = "Create";
            btnCreateProduct.UseVisualStyleBackColor = true;
            btnCreateProduct.Click += BtnAddProductOnClick;
            // 
            // comBoxCategoryID
            // 
            comBoxCategoryID.FormattingEnabled = true;
            comBoxCategoryID.Location = new Point(9, 131);
            comBoxCategoryID.Name = "comBoxCategoryID";
            comBoxCategoryID.Size = new Size(262, 23);
            comBoxCategoryID.TabIndex = 10;
            // 
            // lblProductCategoryID
            // 
            lblProductCategoryID.AutoSize = true;
            lblProductCategoryID.Location = new Point(6, 113);
            lblProductCategoryID.Name = "lblProductCategoryID";
            lblProductCategoryID.Size = new Size(114, 15);
            lblProductCategoryID.TabIndex = 9;
            lblProductCategoryID.Text = "Product Category ID";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(9, 87);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(262, 23);
            txtProductPrice.TabIndex = 8;
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(6, 69);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(65, 15);
            lblProductPrice.TabIndex = 7;
            lblProductPrice.Text = "Retail Price";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(9, 43);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(262, 23);
            txtProductName.TabIndex = 6;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(6, 25);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 5;
            lblProductName.Text = "Product Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 514);
            Controls.Add(groupBox1);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnProductSearch);
            Controls.Add(txtProductSearch);
            Controls.Add(btnShowProducts);
            Controls.Add(lblProducts);
            Controls.Add(dgvProducts);
            Controls.Add(dgvProductCategories);
            Controls.Add(btnDeleteCategory);
            Controls.Add(btnCategorySearch);
            Controls.Add(txtCategorySearch);
            Controls.Add(btnShowCategories);
            Controls.Add(lblCategoriesTable);
            Controls.Add(gBoxAddCategory);
            Name = "Form1";
            Text = "Products";
            gBoxAddCategory.ResumeLayout(false);
            gBoxAddCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gBoxAddCategory;
        private Button btnAddCategory;
        private TextBox txtCategoryDescription;
        private Label lblCategoryDescription;
        private TextBox txtCategoryName;
        private Label lblCategoryName;
        private Label lblCategoriesTable;
        private Button btnShowCategories;
        private TextBox txtCategorySearch;
        private Button btnCategorySearch;
        private Button btnDeleteCategory;
        private DataGridView dgvProductCategories;
        private DataGridView dgvProducts;
        private Button btnDeleteProduct;
        private Button btnProductSearch;
        private TextBox txtProductSearch;
        private Button btnShowProducts;
        private Label lblProducts;
        private GroupBox groupBox1;
        private TextBox txtProductPrice;
        private Label lblProductPrice;
        private TextBox txtProductName;
        private Label lblProductName;
        private Button btnCreateProduct;
        private ComboBox comBoxCategoryID;
        private Label lblProductCategoryID;
    }
}