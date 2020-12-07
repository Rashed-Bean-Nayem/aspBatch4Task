using DataAccessLayer;
using Foundation.Contexts;
using Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Repositories
{
    public class CourseRepository : Repository<Course, int, RegistrationContext>, ICourseRepository
    {
        public CourseRepository(RegistrationContext dbContext)
            : base(dbContext)
        {

        }

        public IList<Course> GetLatestCourses()
        {
            throw new NotImplementedException();
        }
    }
}