using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Repositories
{
    public class RegistrationRepository: Repository<StudentRegistration, int, RegistrationContext>, IRegistrationRepository
    {
        public RegistrationRepository(RegistrationContext dbContext) 
            : base(dbContext)
        {

        }

        public IList<StudentRegistration> GetLatestRegistraion()
        {
            throw new NotImplementedException();
        }
    }
}
