using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Assignment2 
{
    public class DataServer 
    {
        public int DatabaseGateway(string sql,string sql2)
        {
            var connection = "Server=DESKTOP-4HQ3RMH\\SQLEXPRESS; Database= CRUDdb1; User=sa ; password=1110169958;";
            var sqlConnnection = new SqlConnection(connection);
            sqlConnnection.Open();

            var sqlcommand = new SqlCommand(sql, sqlConnnection);
            sqlcommand.ExecuteNonQuery();

            var sqlcommand2 = new SqlCommand(sql2, sqlConnnection);
            var reader = sqlcommand2.ExecuteReader();

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


        public void DatabaseGateway2(string sql)
        {
            var connection = "Server=DESKTOP-4HQ3RMH\\SQLEXPRESS; Database= CRUDdb1; User=sa ; password=1110169958;";
            var sqlConnnection = new SqlConnection(connection);
            sqlConnnection.Open();
            var sqlcommand = new SqlCommand(sql, sqlConnnection);
            sqlcommand.ExecuteNonQuery();

            sqlConnnection.Close();
            sqlConnnection.Dispose();
        }



        public void ReadFromTable(string sql)
        {
            try
            {
                var connection = "Server=DESKTOP-4HQ3RMH\\SQLEXPRESS; Database= CRUDdb1; User=sa ; password=1110169958;";
                using var sqlConnnection = new SqlConnection(connection);
                sqlConnnection.Open(); 

                using var sqlCommand = new SqlCommand(sql, sqlConnnection);
                using var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                   
                    for (var i = 0; i < reader.FieldCount; i++)
                    {
                        if (i == 0)
                        {
                            Console.Write("RoomId = ");
                            Console.Write(reader[i]);
                        }
                        else if (i==1)
                        {
                            Console.Write("  Rent = ");
                            Console.Write(reader[i]);
                        }
                        else
                        {
                            Console.Write("  HouseId = ");
                            Console.Write(reader[i]);
                        }                       
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem");
               
            }
        }
    }
}
