using Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFile.Areas.Admin.Data
{
    public class StudentData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public IList<StudentRegistration> StuReg { get; set; }
    }
}
