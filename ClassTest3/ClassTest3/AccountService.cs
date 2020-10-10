using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace ClassTest3
{
    public class AccountService : DatabaseHelper, IAccountService
    {
        AccountCreation accountCreation = new AccountCreation();
        AccountEmailing accountEmailing = new AccountEmailing();
        public void CreateAccount(string username, string email,string password, string accountType)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
                throw new InvalidOperationException();

            if (accountType == "Admin")
                accountCreation.CreateAdmin(username, email, password);
            else if (accountType == "Customer")
                accountCreation.CreateCustomer(username, email, password);

            var subject = "Your account is created";
            var body = "Thank you for registration. You can now login.";

            accountEmailing.SendEmail(email, subject, body);
        }
        
    }
}
