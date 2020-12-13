using Foundation.Entities;
using Foundation.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Services
{
    public class AddingService : IAddingService
    {
        private readonly IRegistrationUnitOfWork _registrationUnitOfWork;
        public AddingService(IRegistrationUnitOfWork registrationUnitOfWork)
        {
            _registrationUnitOfWork = registrationUnitOfWork;
        }

        public void AddStudent(Student student)  
        {
            _registrationUnitOfWork.StudentRepository.Add(student);
            _registrationUnitOfWork.Save();
        }
        public void AddCourse(Course course)  
        {
            _registrationUnitOfWork.CourseRepository.Add(course);
            _registrationUnitOfWork.Save();
        }
        public void AddRegistration(StudentRegistration studentRegistration)
        {
            _registrationUnitOfWork.RegistrationRepository.Add(studentRegistration);

            _registrationUnitOfWork.Save();

        }

    }
}