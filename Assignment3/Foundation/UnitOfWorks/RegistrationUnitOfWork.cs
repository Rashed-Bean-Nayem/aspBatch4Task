using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.UnitOfWorks
{
    public class RegistrationUnitOfWork : UnitOfWork, IRegistrationUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        public ICourseRepository CourseRepository { get; set; }
        public IRegistrationRepository RegistrationRepository { get; set; }

      

        public RegistrationUnitOfWork(RegistrationContext context, 
            IStudentRepository studentRepository,
            ICourseRepository courseRepository, IRegistrationRepository registrationRepository)
            : base(context)
        {
            StudentRepository = studentRepository;
            CourseRepository = courseRepository;
            RegistrationRepository = registrationRepository;
        }
    }
}
