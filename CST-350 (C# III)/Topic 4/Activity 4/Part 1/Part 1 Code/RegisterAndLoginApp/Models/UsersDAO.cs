
using System.Data.SqlClient;

namespace RegisterAndLoginApp.Models
{
    public class UsersDAO : IUserManager
    {
        // MySQL Connection String
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";



        public int AddUser(UserModel user)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = @"INSERT INTO users (Username, PasswordHash, Salt, Groups) VALUES (@Username, @PasswordHash, @Salt, @Groups); SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                    command.Parameters.AddWithValue("@Salt", user.Salt);
                    command.Parameters.AddWithValue("@Groups", user.Groups);

                    // Execute the Query
                    object result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }

        public int CheckCredentials(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Find User with Given username
                string query = "SELECT * FROM Users WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                SqlDataReader reader = command.ExecuteReader();
                // if user is found, verify password and return said user Id
                if (reader.Read())
                {
                    UserModel user = new UserModel
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        Username = reader.GetString(reader.GetOrdinal("Username")),
                        PasswordHash = reader.GetString(reader.GetOrdinal("PasswordHash")),
                        Salt = (byte[])reader["Salt"],
                        Groups = reader.GetString(reader.GetOrdinal("Groups"))
                    };
                    bool valid = user.VerifyPassword(password);
                    if (valid)
                    {
                        return user.Id; // user was found and password was correct
                    } else
                    {
                        return 0; // user found, password incorrect
                    }
                }
                return 0; // user not found
            }
        }

        public void DeleteUser(UserModel user)
        {
            // delete the matching user record
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM Users WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", user.Id);
                command.ExecuteNonQuery();
            }
        }

        public List<UserModel> GetAllUsers()
        {
            // search for all users
            List<UserModel> users = new List<UserModel>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Users";
                SqlCommand commnad = new SqlCommand(query, connection);
                SqlDataReader reader = commnad.ExecuteReader();
                while (reader.Read())
                {
                    UserModel user = new UserModel
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        Username = reader.GetString(reader.GetOrdinal("Username")),
                        PasswordHash = reader.GetString(reader.GetOrdinal("PasswordHash")),
                        Salt = (byte[])reader["Salt"],
                        Groups = reader.GetString(reader.GetOrdinal("Groups"))
                    };
                    users.Add(user);
                }
            }
            return users;
        }

        public UserModel GetUserById(int id)
        {
            // find the matching user id
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UserModel user = new UserModel
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        Username = reader.GetString(reader.GetOrdinal("Username")),
                        PasswordHash = reader.GetString(reader.GetOrdinal("PasswordHash")),
                        Salt = (byte[])reader["Salt"],
                        Groups = reader.GetString(reader.GetOrdinal("Groups"))
                    };
                    return user;
                }
            }
            return null;
        }

        public void UpdateUser(UserModel user)
        {
            // find matching user, if found update the record using new data
            // id numbers do not change
            int id = user.Id;
            UserModel found = GetUserById(id);
            if (found != null)
            {
                 using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Users SET Username = @Username, PasswordHash = @PasswordHash, Salt = @Salt, Groups = @Groups WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                    command.Parameters.AddWithValue("@Salt", user.Salt);
                    command.Parameters.AddWithValue("@Id", user.Id);
                    command.Parameters.AddWithValue("Groups", user.Groups);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
