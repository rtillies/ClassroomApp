﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomApp
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Student> Roster { get; set; } = new List<Student>();
    }
}
