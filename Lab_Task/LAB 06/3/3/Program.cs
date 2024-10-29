using System;
using System.Collections.Generic;

namespace ExIList
{
    class Student
    {
        public int StudentID { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>();
            studentList.Add(new Student());
            studentList.Add(new Student());
            studentList.Add(new Student());
        }
    }
}

