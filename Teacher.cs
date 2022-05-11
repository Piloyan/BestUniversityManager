using System;
using System.Text.RegularExpressions;

namespace BestUniversityManager.Model
{
    public class Teacher : Model
    {
        public Teacher() : base()
        {

        }

        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }
        public Student[] _students;
        public Group[] _groups;
    }
}
