using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestUniversityManager.Model;

namespace BestUniversityManager.BL
{
    public static class GroupManager
    {
        public static Group Create(string name)
            => new Group(name);
        public static Group[] Create(int count)
        {
            Group[] groups = new Group[count];
            for (int i = 0; i < count; i++)
            {
                groups[i] = new Group($"GrName{i}");
            }
            return groups;
        }
        public static void Print(Group group)
        {
            Console.WriteLine("************Group************");
            Console.WriteLine($"GroupId:{group._id} GroupName:{group._name}");

            if (group._teachers != null && group._students != null)
            {
                for (int i = 0; i < group._teachers.Length; i++)
                {
                    Console.WriteLine($"id:{group._teachers[i]._id} TchName:{group._teachers[i]._firstName} TchLastName:{group._teachers[i]._lastName} TchAge:{group._teachers[i]._age}");
                }
                for (int j = 0; j < group._students.Length; j++)
                {
                    Console.WriteLine($"id:{group._students[j]._id} StName:{group._students[j]._firstName} StLastName:{group._students[j]._lastName} StAge:{group._students[j]._age}");
                }
            }
            else if (group._teachers != null)
            {
                for (int i = 0; i < group._teachers.Length; i++)
                {
                    Console.WriteLine($"id:{group._teachers[i]._id} TchName:{group._teachers[i]._firstName} TchLastName:{group._teachers[i]._lastName} TchAge:{group._teachers[i]._age}");
                }
            }
            else if (group._students != null)
            {
                for (int i = 0; i < group._students.Length; i++)
                {
                    Console.WriteLine($"id:{group._students[i]._id} StName:{group._students[i]._firstName} StLastName:{group._students[i]._lastName} StAge:{group._students[i]._age}");
                }
            }
        }
        public static void Print(Group[] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"**************Group**************");
                Console.WriteLine($"GroupId:{groups[i]._id} Groupname:{groups[i]._name}");
                if (groups[i]._teachers != null)
                {
                    Console.WriteLine($"******GroupId{groups[i]._id}-Teachers*******");
                    for (int j = 0; j < groups[i]._teachers.Length; j++)
                    {
                        Console.WriteLine($"TchId{groups[i]._teachers[j]._id} TchName:{groups[i]._teachers[j]._firstName} TchLastName:{groups[i]._teachers[j]._lastName} tchAge:{groups[i]._teachers[j]._age}");
                    }
                }
            }
        }

    }
}
