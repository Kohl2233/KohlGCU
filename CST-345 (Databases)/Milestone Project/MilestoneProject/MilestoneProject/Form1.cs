using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.BC;

namespace MilestoneProject
{
    public partial class Form1 : Form
    {
        // Attributes
        BindingSource productCategoriesBindingSource = new BindingSource();
        BindingSource productsBindingSource = new BindingSource();
        private MilestoneDOA milestoneDOA;



        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            milestoneDOA = new MilestoneDOA();


            productCategoriesBindingSource.DataSource = milestoneDOA.GetAllProductCategories();
            productsBindingSource.DataSource = milestoneDOA.GetAllProducts(false);

            dgvProductCategories.DataSource = null; // needs to be set to null for some reason to refresh
            dgvProducts.DataSource = null;
            dgvProductCategories.DataSource = productCategoriesBindingSource;
            dgvProducts.DataSource = productsBindingSource;

            comBoxCategoryID.DataSource = milestoneDOA.GetProductCategoryIDs();
        }



        /// <summary>
        /// Method to Display Product Categories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowAllCategoriesOnClick(object sender, EventArgs e)
        {
            dgvProductCategories.DataSource = null;
            productCategoriesBindingSource.DataSource = milestoneDOA.GetAllProductCategories();
            dgvProductCategories.DataSource = productCategoriesBindingSource;
        }



        /// <summary>
        /// Method to Display All Products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowAllProductsOnClick(object sender, EventArgs e)
        {
            dgvProducts.DataSource = null;
            productsBindingSource.DataSource = milestoneDOA.GetAllProducts(true);
            dgvProducts.DataSource = productsBindingSource;
        }



        /// <summary>
        /// Method used to Search through Categories (by name)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCategorySearchOnClick(object sender, EventArgs e)
        {
            // Input Validation
            if (txtCategorySearch.Text == "")
            {
                // Invalid Input
                btnCategorySearch.ForeColor = Color.Red;
            }
            else
            {
                // Searching
                btnCategorySearch.ForeColor = Color.Black;
                List<ProductCategory> results = new List<ProductCategory>();
                foreach (ProductCategory category in milestoneDOA.GetAllProductCategories())
                {
                    if (category.Name.Contains(txtCategorySearch.Text))
                    {
                        results.Add(category);
                    }
                }
                productCategoriesBindingSource.DataSource = results;
                dgvProductCategories.DataSource = productCategoriesBindingSource;
                txtCategorySearch.Text = "";
            }
        }



        /// <summary>
        /// Method Used for Searching Product (by name)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProductSearchOnClick(object sender, EventArgs e)
        {
            // Input Validation
            if (txtProductSearch.Text == "")
            {
                // Invalid Input
                btnProductSearch.ForeColor = Color.Red;
            }
            else
            {
                // Searching
                btnProductSearch.ForeColor = Color.Black;
                List<Product> results = new List<Product>();
                foreach (Product product in milestoneDOA.GetAllProducts(false))
                {
                    if (product.Name.Contains(txtProductSearch.Text))
                    {
                        results.Add(product);
                    }
                }
                productsBindingSource.DataSource = results;
                dgvProducts.DataSource = productsBindingSource;
                txtProductSearch.Text = "";
            }
        }


        private void BtnAddCategoryOnClick(object sender, EventArgs e)
        {
            // Input Validation
            if (txtCategoryName.Text != "")
            {
                lblCategoryName.ForeColor = Color.Black;
                if (txtCategoryDescription.Text != "")
                {
                    // All is Valid
                    lblCategoryDescription.ForeColor = Color.Black;

                    // Create Category Object
                    ProductCategory category = new ProductCategory(0, txtCategoryName.Text, txtCategoryDescription.Text);

                    // Send to DOA
                    int result = milestoneDOA.AddSingleCategory(category);

                    // Update Display
                    dgvProductCategories.DataSource = null; // needs to be set to null for some reason to refresh
                    productCategoriesBindingSource.DataSource = milestoneDOA.GetAllProductCategories();
                    dgvProductCategories.DataSource = productCategoriesBindingSource;

                    comBoxCategoryID.DataSource = null;
                    comBoxCategoryID.DataSource = milestoneDOA.GetProductCategoryIDs();

                    // Reset Category Text Fields
                    txtCategoryName.Text = "";
                    txtCategoryDescription.Text = "";

                }
                else
                {
                    // Invalid Category Description
                    lblCategoryDescription.ForeColor = Color.Red;
                }
            }
            else
            {
                // Invalid Category Name
                lblCategoryName.ForeColor = Color.Red;
            }
        }

        private void BtnAddProductOnClick(object sender, EventArgs e)
        {
            // Input Validation
            if (txtProductName.Text != "")
            {
                lblProductName.ForeColor = Color.Black;
                if (txtProductPrice.Text != "")
                {
                    if (float.TryParse(txtProductPrice.Text, out float price))
                    {
                        lblProductPrice.ForeColor = Color.Black;
                        if (comBoxCategoryID.SelectedIndex > -1)
                        {
                            // All is Valid
                            lblProductCategoryID.ForeColor = Color.Black;

                            // Create Product Object
                            Product product = new Product(0, comBoxCategoryID.SelectedIndex + 1, 1, txtProductName.Text, price);

                            // Send to DOA
                            milestoneDOA.AddSingleProduct(product);

                            // Update Display
                            dgvProducts.DataSource = null; // needs to be set to null for some reason to refresh
                            productsBindingSource.DataSource = milestoneDOA.GetAllProducts(false);
                            dgvProducts.DataSource = productsBindingSource;

                            // Reset Product Text Fields
                            txtProductName.Text = "";
                            txtProductPrice.Text = "";
                            comBoxCategoryID.SelectedIndex = -1;

                        }
                        else
                        {
                            lblProductCategoryID.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        lblProductPrice.ForeColor = Color.Red;

                    }
                }
                else
                {
                    lblProductPrice.ForeColor = Color.Red;
                }
            }
            else
            {
                lblProductName.ForeColor = Color.Red;
            }
        }


        private void btnDeleteCategoryOnClick(object sender, EventArgs e)
        {
            // Delete Category
            int activeRow = dgvProductCategories.CurrentRow.Index;
            int categoryID = (int)dgvProductCategories.Rows[activeRow].Cells[0].Value;
            int result = milestoneDOA.DeleteSingleCategory(categoryID);
            MessageBox.Show("Deleted " + result + " Entry.");

            // Update Display
            dgvProductCategories.DataSource = null; // needs to be set to null for some reason to refresh
            productCategoriesBindingSource.DataSource = milestoneDOA.GetAllProductCategories();
            dgvProductCategories.DataSource = productCategoriesBindingSource;

            comBoxCategoryID.DataSource = null;
            comBoxCategoryID.DataSource = milestoneDOA.GetProductCategoryIDs();
        }

        private void BtnDeleteProductOnClick(object sender, EventArgs e)
        {
            // Delete Product
            int activeRow = dgvProducts.CurrentRow.Index;
            int productID = (int)dgvProducts.Rows[activeRow].Cells[0].Value;
            int result = milestoneDOA.DeleteSingleProduct(productID);
            MessageBox.Show("Deleted " + result + " Product.");

            // Update Display
            dgvProducts.DataSource = null; // needs to be set to null for some reason to refresh
            productsBindingSource.DataSource = milestoneDOA.GetAllProducts(false);
            dgvProducts.DataSource = productsBindingSource;
        }

        private void DvgProductCategoriesOnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int activeRow = dgvProductCategories.CurrentRow.Index;
            int categoryID = (int)dgvProductCategories.Rows[activeRow].Cells[0].Value;
            milestoneDOA.LoadProductsOfCategory(categoryID);

            // Update Display
            dgvProducts.DataSource = null; // needs to be set to null for some reason to refresh
            productsBindingSource.DataSource = milestoneDOA.GetAllProducts(false);
            dgvProducts.DataSource = productsBindingSource;
        }
    }
}