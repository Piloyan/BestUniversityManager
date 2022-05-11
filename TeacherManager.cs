using System;
using BestUniversityManager.Model;
namespace BestUniversityManager.BL
{
    public static class TeacherManager
    {
        const short maxAge = 139;
        public static Teacher Create(string firstName, string lastName, int age)
            => new Teacher(firstName, lastName, age);
        public static Teacher[] Create(int count, int minAge)
        {
            Teacher[] teachers = new Teacher[count];
            Random rnd = new Random();
            for (int i = 0; i < teachers.Length; i++)
            {
                teachers[i] = new Teacher($" name{i}", $" lastName{i}", rnd.Next(minAge, maxAge));
            }
            return teachers;
        }
        public static void Print(Teacher teacher)
        {
            Console.WriteLine("**********Teacher********");
            Console.WriteLine($"id:{teacher._id} name:{teacher._firstName} lastName{teacher._lastName} age:{teacher._age}");
            Console.WriteLine($"**************{teacher._id}-Student**********");
            if (teacher._students != null)
                for (int i = 0; i < teacher._students.Length; i++)
                {
                    Console.WriteLine($"id:{teacher._students[i]._id} name:{teacher._students[i]._firstName} lastName:{teacher._students[i]._lastName} age:{teacher._students[i]._age}");
                }
        }
        public static void Print(Teacher[] teachers)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                Console.WriteLine("**********Teacher********");
                Console.WriteLine($"id:{teachers[i]._id} name:{teachers[i]._firstName} lastName{teachers[i]._lastName} age:{teachers[i]._age}");
                if (teachers[i]._students != null)
                {
                    Console.WriteLine($"**************Teacher id:{teachers[i]._id}-Student**********");
                    for (int j = 0; j < teachers[i]._students.Length; j++)
                    {
                        Console.WriteLine($"id:{teachers[i]._students[j]._id} name:{teachers[i]._students[j]._firstName} lastName:{teachers[i]._students[j]._lastName} age:{teachers[i]._students[j]._age}");
                    }
                }

                if (teachers[i]._groups != null)
                {
                    for (int j = 0; j < teachers[i]._groups.Length; j++)
                    {
                        Console.WriteLine($"GroupId:{teachers[i]._groups[j]._id} GroupName:{teachers[i]._groups[j]._name}");
                    }

                }
            }
        }

    }
}
