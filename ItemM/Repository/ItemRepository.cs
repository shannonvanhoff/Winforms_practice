using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemM.Models;
using Microsoft.Data.SqlClient;

namespace ItemM.Repository
{
    public class ItemRepository
    {
        private readonly string connectionstring = "Data Source=.;Initial Catalog=ItemM;Integrated Security=True;Trust Server Certificate=True";

        public List<Item> GeTItems()
        {
            var Items = new List<Item>();
            try
            {
                using (var connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    var query = "SELECT ItemID, ItemName, ItemDescription FROM Item";
                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var item = new Item
                                {
                                    ItemID = reader.GetInt32(0),
                                    ItemName = reader.GetString(1),
                                    ItemDescription = reader.GetString(2)
                                };
                                Items.Add(item);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Items;
        }
        public Item GetItem(int id)
        {
            
            try
            {
                using (var connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    var query = "SELECT ItemID, ItemName, ItemDescription FROM Item WHERE ItemID = @ItemID";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Item item = new Item();
                                item.ItemID = reader.GetInt32(0);
                                item.ItemName = reader.GetString(1);
                                item.ItemDescription = reader.GetString(2);

                                return item;
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

        public void CreateItem(Item item)
        {
            try
            {
                using (var connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    var checkQuery = "SELECT COUNT(*) FROM Item WHERE ItemID = @ItemID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@ItemID", item.ItemID);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count >= 0)
                        {
                            // Generate a new unique ItemID
                            item.ItemID = GenerateNewItemID(connection);
                        }
                    }

                    var query = "INSERT INTO Item (ItemID, ItemName, ItemDescription) VALUES (@ItemID, @ItemName, @ItemDescription)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemID", item.ItemID);
                        command.Parameters.AddWithValue("@ItemName", item.ItemName);
                        command.Parameters.AddWithValue("@ItemDescription", item.ItemDescription);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private int GenerateNewItemID(SqlConnection connection)
        {
            var query = "SELECT MAX(ItemID) + 1 FROM Item";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                return (int)command.ExecuteScalar();
            }
        }
        public void UpdateItem(Item item)
        {
            try
            {
                using (var connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    var query = "UPDATE Item SET ItemName = @ItemName, ItemDescription = @ItemDescription WHERE ItemID = @ItemID";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemID", item.ItemID);
                        command.Parameters.AddWithValue("@ItemName", item.ItemName);
                        command.Parameters.AddWithValue("@ItemDescription", item.ItemDescription);

                         command.ExecuteNonQuery();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void DeleteItem(int id) 
        {
            try
            {
                using (var connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    var query = "DELETE FROM Item WHERE ItemID = @ItemID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemID", id);

                        command.ExecuteNonQuery();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
