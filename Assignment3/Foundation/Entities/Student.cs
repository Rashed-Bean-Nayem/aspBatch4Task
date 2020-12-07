﻿using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Entities
{
    public class Student: IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public IList<StudentRegistration> StuReg { get; set; }  

    }
}
