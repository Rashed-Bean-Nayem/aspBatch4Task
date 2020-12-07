using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.UnitOfWorks
{
    public class ShopingUnitOfWork : UnitOfWork, IShopingUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        public ICourseRepository CourseRepository { get; set; }

      

        public ShopingUnitOfWork(RegistrationContext context, 
            IStudentRepository studentRepository,
            ICourseRepository courseRepository)
            : base(context)
        {
            StudentRepository = studentRepository;
            CourseRepository = courseRepository;
        }
    }
}
