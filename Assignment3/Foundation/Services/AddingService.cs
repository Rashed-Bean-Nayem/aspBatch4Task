using Foundation.Entities;
using Foundation.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Services
{
    public class AddingService : IAddingService
    {
        private readonly IShopingUnitOfWork _shopingUnitOfWork;
        public AddingService(IShopingUnitOfWork shopingUnitOfWork)
        {
            _shopingUnitOfWork = shopingUnitOfWork;
        }

        public void AddStudent(Student student)  
        {
            _shopingUnitOfWork.StudentRepository.Add(student);
            _shopingUnitOfWork.Save();
        }
        public void AddCourse(Course course)  
        {
            _shopingUnitOfWork.CourseRepository.Add(course);
            _shopingUnitOfWork.Save();
        }
        public void AddRegistration(StudentRegistration studentRegistration)
        {
            _shopingUnitOfWork.RegistrationRepository.Add(studentRegistration);

            _shopingUnitOfWork.Save();

        }

    }
}