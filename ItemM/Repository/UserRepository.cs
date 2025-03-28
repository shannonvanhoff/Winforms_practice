using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using ItemM.Models;

namespace ItemM.Repository
{
    public class UserRepository
    {
        private readonly string connectionstring = "Data Source=.;Initial Catalog=ItemM;Integrated Security=True;Trust Server Certificate=True";

        public void RegisterUser(User user)
        {
            try
            {
                using (var connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    var query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Password); // Note: Store hashed passwords in production
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public User LoginUser(string username, string password)
        {
            try
            {
                using (var connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    var query = "SELECT UserID, Username, Password FROM Users WHERE Username = @Username AND Password = @Password";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password); // Note: Compare hashed passwords in production
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    UserID = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    Password = reader.GetString(2)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
