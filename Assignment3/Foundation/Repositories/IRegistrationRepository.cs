using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Repositories
{
    public interface IRegistrationRepository: IRepository<StudentRegistration, int, RegistrationContext>
    {
        IList<StudentRegistration> GetLatestRegistraion();
       
    }
}
