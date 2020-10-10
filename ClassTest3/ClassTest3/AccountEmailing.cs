using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace ClassTest3
{
    public class AccountEmailing: IAccountServiceEmailing
    {
        public void SendEmail(string receiver, string subject, string body)
        {
            var smtp = new SmtpClient("devskill.com", 25);
            smtp.Send("info@devskill.com", receiver, subject, body);
        }
    }
}
