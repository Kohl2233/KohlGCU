using ProductsApp.Models;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using Microsoft.Data.SqlClient;
using System.Data;
namespace ProductsApp.Services
{
    public class ProductDAO : IProductDAO
    {
        private readonly string _connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog = ProductsDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False";

        public async Task<int> AddProduct(ProductModel product)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Products (Name, Price, Description, CreatedAt, ImageURL) OUTPUT INSERTED.Id VALUES (@Name, @Price, @Description, @CreatedAt, @ImageURL)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Description", product.Description);
                command.Parameters.AddWithValue("@CreatedAt", product.CreatedAt);
                command.Parameters.AddWithValue("ImageURL", product.ImageURL);

                connection.Open();
                int newId = (int)await command.ExecuteScalarAsync();
                return newId;
            }
        }

        public Task DeleteProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductModel>> GetAllProducts()
        {
            List<ProductModel> products = new List<ProductModel>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);
                connection.Open();
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (reader.Read())
                {
                    products.Add(new ProductModel
                    {
                        Id = reader.GetInt32(0),
                        // if column is null return an empty string or 0
                        Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Price = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                        Description = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        CreatedAt = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4),
                        ImageURL = reader.IsDBNull(5) ? string.Empty : reader.GetString(5)
                    });

                }
            }
            return products;
        }

        public Task<ProductModel> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductModel>> SearchForProductByDescription(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductModel>> SearchForProductsByName(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
