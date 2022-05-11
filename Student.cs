using System;
using System.Text.RegularExpressions;

namespace BestUniversityManager.Model
{
    public class Student : Model
    {
        public Student() : base()
        {

        }

        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }
        public Teacher _teacher;
        public Group _group;
    }
}
