using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTest3
{
    public interface IAccountServiceEmailing
    {
        void SendEmail(string receiver, string subject, string body);
    }
}
