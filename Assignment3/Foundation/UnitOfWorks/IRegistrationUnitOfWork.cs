using DataAccessLayer;
using Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.UnitOfWorks 
{
    public interface IRegistrationUnitOfWork : IUnitOfWork
    {
        IStudentRepository StudentRepository { get; set; }
        ICourseRepository CourseRepository { get; set; }
        IRegistrationRepository RegistrationRepository { get; set; } 
    }
}
