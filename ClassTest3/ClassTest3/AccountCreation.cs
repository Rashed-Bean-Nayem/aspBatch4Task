using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTest3
{
    public class AccountCreation:DatabaseHelper
    {
        public void CreateAdmin(string username, string email, string password)
        {
            if (username.Length >= 10 && username.Length <= 20
                && email.Contains("@") && password.Length >= 8)
            {
                var sql = $"Insert into users (username, email, password, type) values('{username},'{email}','{password}', 'admin')";
                ExecuteSqlQuery(sql);
            }
        }

        public void CreateCustomer(string username, string email, string password)
        {
            if (username.Length >= 10 && username.Length <= 20
                && email.Contains("@") && password.Length >= 8)
            {
                var sql = $"Insert into users (username, email, password, type) values('{username},'{email}','{password}', 'customer')";
                ExecuteSqlQuery(sql);
            }
        }
    }
}
