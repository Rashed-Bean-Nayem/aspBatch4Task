using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Repositories
{
    public interface IStudentRepository : IRepository<Student, int, RegistrationContext>
    {
        IList<Student> GetLatestStudents(); 
    }
}
