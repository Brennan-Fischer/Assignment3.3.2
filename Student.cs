﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._3._2
{
    class Student
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address {  get; set; }
        public string MonthOfAdmission { get; set; }
        public double GPA { get; set; }

        public Student(string studentID, string firstName, string lastName, string address, string monthOfAdmission, double gPA)
        {
            StudentId = studentID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            MonthOfAdmission = monthOfAdmission;
            GPA = gPA;
        }

    }
}
