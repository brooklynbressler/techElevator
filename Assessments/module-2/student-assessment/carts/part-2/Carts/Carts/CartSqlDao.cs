using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Carts
{
    public class CartSqlDao : ICartDao
    {
        private readonly string connectionString;

        public CartSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Cart> GetAllCarts()
        {
            // Implement this method to pull in all carts from database

            List<Cart> listCarts = new List<Cart>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT id, username, cookie_value, created FROM carts;";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listCarts.Add(GetCartsFromReader(reader));
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return listCarts;
        }

        public void Save(Cart newCart)
        {
            // Implement this method to save cart to database

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "INSERT INTO carts(username, cookie_value, created) VALUES (@username, @cookie_value, @created);";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@username", newCart.Username);
                    cmd.Parameters.AddWithValue("@cookie_value", newCart.CookieValue);
                    cmd.Parameters.AddWithValue("@created", newCart.Created);

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("SELECT @@IDENTITY FROM carts", conn);
                    newCart.Id = Convert.ToInt32(cmd.ExecuteScalar());

                }
            }
            catch (SqlException)
            {

            }
        }

        public Cart GetCartsFromReader(SqlDataReader reader)
        {
            Cart cart = new Cart();

            cart.CookieValue = Convert.ToString(reader["cookie_value"]);
            cart.Created = Convert.ToDateTime(reader["created"]);
            cart.Id = Convert.ToInt32(reader["id"]);
            cart.Username = Convert.ToString(reader["username"]);

            return cart;
        }
    }
}