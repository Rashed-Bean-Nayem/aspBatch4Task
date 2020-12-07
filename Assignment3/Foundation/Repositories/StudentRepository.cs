using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Foundation.Contexts;
using DataAccessLayer;
using Foundation.Entities;

namespace Foundation.Repositories
{
    public class StudentRepository : Repository<Student, int, RegistrationContext>, IStudentRepository
    {
        public StudentRepository(RegistrationContext dbContext)
            : base(dbContext)
        {

        }

        public IList<Student> GetLatestStudents() 
        {
            throw new NotImplementedException();
        }
    }
}
