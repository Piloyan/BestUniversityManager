using BestUniversityManager.Model;
namespace BestUniversityManager.Model
{
    public static class UniversityManager
    {
        public static Student AssignTeacher(Student student, Teacher teacher)
        {
            student._teacher = teacher;

            return student;
        }
        public static Student[] AssignTeachers(Student[] students, Teacher[] teachers)
        {
            for (int i = 0; i < students.Length; i++)
            {
                int count = i % teachers.Length;
                students[i]._teacher = teachers[count];
            }

            return students;
        }
        public static Teacher[] AssignStudents(Teacher[] teachers, Student[] students)
        {
            int minStCount = students.Length / teachers.Length;
            for (int i = 0; i < teachers.Length - 1; i++)
            {
                teachers[i]._students = new Student[minStCount];
                for (int j = 0; j < minStCount; j++)
                {
                    teachers[i]._students[j] = students[i * minStCount + j];
                }

            }
            int lastStcount = minStCount * (teachers.Length - 1);
            teachers[teachers.Length - 1]._students = new Student[students.Length - lastStcount];
            int counter = 0;
            for (int i = lastStcount; i < students.Length; i++)
            {
                teachers[teachers.Length - 1]._students[counter++] = students[i];
            }
            return teachers;
        }
        public static Teacher AssignStudents(Teacher teacher, Student[] students)
        {
            teacher._students = students;
            return teacher;
        }
        public static Group AssignStudents(Group group, Student[] students)
        {
            group._students = students;
            return group;
        }
        public static Group AssignTeachers(Group group, Teacher[] teachers)
        {
            group._teachers = teachers;
            return group;
        }
        public static Student[] AssignGroup(Student[] students, Group group)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i]._group = group;
            }
            return students;
        }
        public static Group[] AssignTeachers(Group[] groups, Teacher[] teachers)
        {
            int mincount = teachers.Length / groups.Length;
            for (int i = 0; i < groups.Length - 1; i++)
            {
                groups[i]._teachers = new Teacher[mincount];
                for (int j = 0; j < groups[i]._teachers.Length; j++)
                {
                    groups[i]._teachers[j] = teachers[i * mincount + j];
                }
            }
            int lastcount = mincount * (groups.Length - 1);
            groups[groups.Length - 1]._teachers = new Teacher[teachers.Length - lastcount];
            int counter = 0;
            for (int i = lastcount; i < teachers.Length; i++)
            {
                groups[groups.Length - 1]._teachers[counter++] = teachers[i];
            }
            return groups;
        }
        public static Teacher[] AssignGroups(Teacher[] teachers, Group[] groups)
        {
            for (int i = 0; i < teachers.Length; i++)
            {

                teachers[i]._groups = new Group[groups.Length];
                for (int j = 0; j < teachers[i]._groups.Length; j++)
                {
                    teachers[i]._groups[j] = groups[j];
                }
            }
            return teachers;
        }
    }
}
