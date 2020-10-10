using System;

namespace ClassTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountService = new AccountService();
            accountService.CreateAccount("jalaluddin", "jalal.uddin@test.com", "1234", "admin");
        }
    }
}
