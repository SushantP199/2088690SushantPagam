using System.Data.SqlClient;
using System.Collections.Generic;


namespace Restaurant.Api.Models
{
    public class MenuItemOps
    {
        private SqlDataReader sqlDataReader;

        public List<MenuItem> GetMenuItemData(string conn)
        {
            List<MenuItem> menuList = new List<MenuItem>();

            SqlConnection sqlConnection = new SqlConnection(conn);

            string query = "SELECT * FROM MenuItem";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();

                var sqlDataReader = sqlCommand.ExecuteReader();

                MenuItem menuItem = null;
                while (sqlDataReader.Read())
                {
                    menuItem = new MenuItem();

                    menuItem.Id = sqlDataReader.GetInt32(0);
                    menuItem.Name = sqlDataReader.GetString(1);
                    menuItem.Price = (decimal)sqlDataReader.GetValue(2);

                    menuList.Add(menuItem);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return menuList;
        }

        internal List<MenuItem> GetMenuItemByID(string conn, int id)
        {
            List<MenuItem> menuList = new List<MenuItem>();

            SqlConnection sqlConnection = new SqlConnection(conn);

            string query = $"SELECT * FROM MenuItem WHERE Id={id}";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();

                var sqlDataReader = sqlCommand.ExecuteReader();

                MenuItem menuItem = null;
                while (sqlDataReader.Read())
                {
                    menuItem = new MenuItem();

                    menuItem.Id = sqlDataReader.GetInt32(0);
                    menuItem.Name = sqlDataReader.GetString(1);
                    menuItem.Price = (decimal)sqlDataReader.GetValue(2);

                    menuList.Add(menuItem);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return menuList;
        }

        public bool UpdateMenu(string conn, int id, MenuItem menuItem)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = $"UPDATE MenuItem SET Name='{menuItem.Name}', Price='{menuItem.Price}' WHERE Id='{id}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return true;
        }
    }
}
