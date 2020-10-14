using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Assignment2 
{
    public class ModifyTable
    {
        public int DatabaseGateway(string sql,string sql2)
        {
            var connection = "Server=DESKTOP-4HQ3RMH\\SQLEXPRESS; Database= CRUDdb1; User=sa ; password=1110169958;";
            var sqlConnnection = new SqlConnection(connection);
            sqlConnnection.Open();
            var sqlcommand = new SqlCommand(sql, sqlConnnection);
            sqlcommand.ExecuteNonQuery();

            using var sqlcommand2 = new SqlCommand(sql2, sqlConnnection);
            using var reader = sqlcommand2.ExecuteReader();

            int HouseId=0; 
         
            while (reader.Read())
            { 
                for (var i = 0; i < reader.FieldCount; i++)
                {
                    
                    HouseId = Convert.ToInt32(reader[i]); 
                }
            }

            sqlConnnection.Close();
            sqlConnnection.Dispose();

            int final = Convert.ToInt32(HouseId);
            return HouseId; 
        }
       
    }
}
