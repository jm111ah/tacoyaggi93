using Microsoft.Extensions.FileSystemGlobbing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crown.Lib
{
    public class _﻿Dependency_Injection
    {
        public class Student
        {
            School school = new School();
            public string ClassA()
            {
                return school.Name + school.Gender;
            }
        }

        public class School
        {

            public string Name { get; set; }
            public string Gender { get; set; }
        }



    }
}
