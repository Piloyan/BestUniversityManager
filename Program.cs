using BestUniversityManager.BL;
using System;
using BestUniversityManager.Model;
namespace BestUniversityManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = StudentManager.Create("John", "Smith", 19);
            Student[] students = StudentManager.Create(18, 26);
            Teacher tch = TeacherManager.Create("John1", "Smith1", 23);
            Teacher[] teachers = TeacherManager.Create(9, 42);
            _ = UniversityManager.AssighnhTeacher(student, tch);
            Group group = GroupManager.Create("Math");
            group = UniversityManager.AssighnStudents(group, students);
            _ = UniversityManager.AssighnTeachers(group, teachers);
            Group[] groups = GroupManager.Create(3);
            teachers = UniversityManager.AssighnStudents(teachers, students);
            _ = UniversityManager.AssighnhTeachers(students, teachers);
            groups = UniversityManager.AssighnTeachers(groups, teachers);
            teachers = UniversityManager.AssighnGroups(teachers, groups);
            TeacherManager.Print(teachers);
            Console.ReadLine();
        }
    }
}
