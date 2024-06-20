using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneProject
{
    internal class MilestoneDOA
    {
        // Attributes
        private string connectionString =
            "datasource=localhost;" +
            "port=3306;" +
            "username=root;" +
            "password=root;" +
            "database=milestone_project;";

        private List<ProductCategory> ProductCategories = new List<ProductCategory>();

        private List<Product> Products = new List<Product>();


        // Default Constructor
        public MilestoneDOA() {
            // Load All Product Categories
            LoadAllProductCategories();

            // Load All Products
            LoadAllProducts();
        }

        public int[] GetProductCategoryIDs()
        {
            int[] IDs = new int[ProductCategories.Count];
            for (int i = 0; i < IDs.Length; i++)
            {
                IDs[i] = ProductCategories[i].CategoryID;
            }
            return IDs;
        }

        /// <summary>
        /// Method to Load All Categories from Database
        /// </summary>
        private void LoadAllProductCategories()
        {
            // Clear List
            ProductCategories.Clear();

            // Set up Database Connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Set Up Query Command
            MySqlCommand command = new MySqlCommand(
                "SELECT category_id," +
                "name," +
                "description " +
                "FROM product_categories", connection);

            // Execute Command
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Get Data
                    int categoryID = reader.GetInt32(0);
                    string categoryName = reader.GetString(1);
                    string categoryDescription = reader.GetString(2);

                    // Create Object
                    ProductCategory category = new ProductCategory(
                        categoryID, 
                        categoryName, 
                        categoryDescription);

                    // Add to Category List
                    ProductCategories.Add(category);
                }
            }
            connection.Close();
        }


        /// <summary>
        /// Method to Load All Products From Database
        /// </summary>
        private void LoadAllProducts()
        {
            // Clear List
            Products.Clear();

            // Set up Connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Set up Query Command
            MySqlCommand command = new MySqlCommand(
                "SELECT product_id," +
                "category_id," +
                "vendor_id," +
                "name," +
                "price " +
                "FROM products", connection);

            // Execute Command
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Get Data
                    int productID = reader.GetInt32(0);
                    int categoryID = reader.GetInt32(1);
                    int vendorID = reader.GetInt32(2);
                    string name = reader.GetString(3);
                    float price = reader.GetFloat(4);

                    // Create Object
                    Product product = new Product(
                        productID,
                        categoryID,
                        vendorID,
                        name,
                        price);

                    // Add to Product List
                    Products.Add(product);
                }
            }
            connection.Close();
        }

        public void LoadProductsOfCategory(int category_ID)
        {
            // Clear List
            Products.Clear();

            // Set up Connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Set up Query Command
            MySqlCommand command = new MySqlCommand(
                "SELECT product_id," +
                "category_id," +
                "vendor_id," +
                "name," +
                "price " +
                "FROM products " +
                "WHERE category_id = @categoryID", connection);

            // Set up Parameters
            command.Parameters.AddWithValue("@categoryID", category_ID);

            // Execute Command
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Get Data
                    int productID = reader.GetInt32(0);
                    int categoryID = reader.GetInt32(1);
                    int vendorID = reader.GetInt32(2);
                    string name = reader.GetString(3);
                    float price = reader.GetFloat(4);

                    // Create Object
                    Product product = new Product(
                        productID,
                        categoryID,
                        vendorID,
                        name,
                        price);

                    // Add to Product List
                    Products.Add(product);
                }
            }
            connection.Close();
        }


        /// <summary>
        /// Getter Method for Product Categories List
        /// </summary>
        /// <returns></returns>
        public List<ProductCategory> GetAllProductCategories()
        {
            return ProductCategories;
        }

        /// <summary>
        /// Getter Method for Product List
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts(bool reload)
        {
            if (reload)
            {
                LoadAllProducts();
            }
            return Products;
        }



        public int AddSingleCategory(ProductCategory category)
        {
            // Set up Connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Set Up Non-Query Command
            MySqlCommand command = new MySqlCommand(
                "INSERT INTO `product_categories`(" +
                "`name`, `description`) " +
                "VALUES (@name, @description)", connection);

            // Set Up Command Parameters
            command.Parameters.AddWithValue("@name", category.Name);
            command.Parameters.AddWithValue("@description", category.Description);

            // Execute Non-Query Command
            int status = command.ExecuteNonQuery();
            connection.Close();

            // Update Category List
            LoadAllProductCategories();

            // Return Status
            return status;
        }

        public int AddSingleProduct(Product product)
        {
            // Set up Connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Set up Non-Query Command
            MySqlCommand command = new MySqlCommand(
                "INSERT INTO `products`(`category_id`, `vendor_id`, `name`, `price`) " +
                "VALUES (@category_id, @vendor_id, @name, @price)", connection);

            // Set up Parameters
            command.Parameters.AddWithValue("@category_id", product.CategoryID);
            command.Parameters.AddWithValue("@vendor_id", product.VendorID);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@price", product.Price);

            // Execute Non-Query Command
            int status = command.ExecuteNonQuery();
            connection.Close();

            // Update Product List
            LoadAllProducts();

            // Return Status
            return status;
        }

        public int DeleteSingleCategory(int categoryID)
        {
            // Set up Connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Set up Non-Query Command
            MySqlCommand command = new MySqlCommand(
                "DELETE FROM product_categories WHERE product_categories.category_id = @categoryID", connection);

            // Set Up Parameters
            command.Parameters.AddWithValue("@categoryID", categoryID);

            // Execute Non-Query
            int result = command.ExecuteNonQuery();
            connection.Close();

            // Update Product Categories
            LoadAllProductCategories();

            // Return Result
            return result;
        }

        public int DeleteSingleProduct(int productID)
        {
            // Set up Connection
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Set up Non-Query Command
            MySqlCommand command = new MySqlCommand(
                "DELETE FROM products WHERE products.product_id = @productID", connection);

            // Set Up Parameters
            command.Parameters.AddWithValue("@productID", productID);

            // Execute Non-Query Command
            int result = command.ExecuteNonQuery();
            connection.Close();

            // Update Products
            LoadAllProducts();

            // Return Result
            return result;
        }
    }
}
