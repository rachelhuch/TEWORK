using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Carts
{
    public class CartSqlDao : ICartDao
    {
        private readonly string connectionString;
        private SqlConnection conn;

        public CartSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Cart> GetAllCarts()
        {
            // Implement this method to pull in all carts from database
            List<Cart> carts = new List<Cart>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM carts";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Cart cart1 = new Cart();
                        //carts.Username = Convert.ToString(rdr["username"]);
                        //carts.CookieValue = Convert.ToString(rdr["cookie_value"]);
                        //carts.Created = Convert.ToDateTime(rdr["created"]);

                        carts.Add(cart1);
                    }
                }
            }


            catch (SqlException ex)
            {

                Console.WriteLine(ex.Message);
            }
            return carts;
        }

        public void Save(Cart newCart)
        {
            // Implement this method to save cart to database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"Insert into carts VALUES ('rhuch', 'b053d', '2020-02-24')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", newCart.Username);
                cmd.Parameters.AddWithValue("@cookie_value", newCart.CookieValue);
                cmd.Parameters.AddWithValue("@created", newCart.Created);

                int newId = Convert.ToInt32(cmd.ExecuteScalar());

                
            }
        }
    }
}