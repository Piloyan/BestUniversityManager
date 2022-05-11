using System;
using BestUniversityManager.Model;

namespace BestUniversityManager.BL
{
    public static class StudentManager
    {
        const short maxAge = 139;
        public static Student Create(string firstName, string lastName, int age)
            => new Student(firstName, lastName, age);
        public static Student[] Create(int count, int minAge)
        {
            Student[] students = new Student[count];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student($"name{i}", $"lastName{i}", rnd.Next(minAge, maxAge));
            }
            return students;
        }

        public static void Print(Student student)
        {
            Console.WriteLine("**********Student**********");
            Console.WriteLine($"id:{student._id} StName:{student._firstName} StLastName:{student._lastName} StAge:{student._age}");
            Console.WriteLine($"**********{student._id}-Teacher**********");
            if (student._teacher != null)
                Console.WriteLine($"id:{student._teacher._id} TchName:{student._teacher._firstName} TchLastName:{student._teacher._lastName} TchAge:{student._teacher._age}");

        }

        public static void Print(Student[] students)
        {

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("**********Student**********");
                Console.WriteLine($"id:{students[i]._id} StName:{students[i]._firstName} StLastName:{students[i]._lastName} StAge:{students[i]._age}");
                if (students[i]._teacher != null)
                {
                    Console.WriteLine($"**********Student id:{students[i]._id}-Teacher**********");
                    Console.WriteLine($"id:{students[i]._teacher._id} TchName:{students[i]._teacher._firstName} TchLastName:{students[i]._teacher._lastName} TchAge:{students[i]._teacher._age}");
                }
                if (students[i]._group != null)
                    Console.WriteLine(value: $"GroupId:{students[i]._group._id} GroupName:{students[i]._group._name}");
            }
        }
    }
}
