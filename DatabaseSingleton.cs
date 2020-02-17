using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace Singleton
{
    class DatabaseSingleton
    {
        private SqlConnection Connection { get; set; }
        private static DatabaseSingleton singleton = null;

        private DatabaseSingleton()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = @"Data Source=PC-HARU\SQLEXPRESS;Initial Catalog=GroceriesDB;Integrated Security=True";
            Connection = new SqlConnection(builder.ConnectionString);
            Connection.Open();
        }
    
        public static DatabaseSingleton GetInstance()
        {
            if (singleton == null)
            {
                singleton = new DatabaseSingleton();
            }
            return singleton;
        }

        public List<string> GetAllFromDB()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = "SELECT * FROM Grocery";
            List<string> groceryName = new List<string>();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        groceryName.Add(Convert.ToString(reader));
                    }
                }
            }
            return groceryName;

        }
    }
}
