using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ClassTest3
{
    public class DatabaseHelper
    {
        public void ExecuteSqlQuery(string sql)
        {
            var connectionString = "Server = myServerAddress; Database = myDataBase; User Id = myUsername; Password = myPassword;";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}
