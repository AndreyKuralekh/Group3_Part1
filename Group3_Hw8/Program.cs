using System.Data;
using System.Linq;
namespace Group3_Hw8
{
    /*
        - add a collection of students to the teacher
        - add a collection of students to the course
        - add a collection of courses to a student
        - add a collection of courses to the teacher
        - implement collection management methods (add, remove, get the number of elements in the collection)
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagedCollection<Student> studentsAttendedCourses = new ManagedCollection<Student>();
            ManagedCollection<Teacher> teacherLeadedCourses = new ManagedCollection<Teacher>();
            ManagedCollection<Courses> coursesAndAttendenses = new ManagedCollection<Courses>();

            Courses c0 = new Courses("Grammar", "Ivanupenkoff", 8, 0);
            Courses c1 = new Courses("History", "Ivanupollo", 4, 0);
            Courses c2 = new Courses("Match", "Ivanoff", 12, 0);
            Courses c3 = new Courses("Philosofy", "Petroff", 8, 0);
            Courses c4 = new Courses("Architecture", "Sidoroff", 6, 0);
            Courses c5 = new Courses("Dentistry", "Petrenko", 22, 0);
            Courses c6 = new Courses("Economics", "Ivanoff", 3, 0);
            Courses c7 = new Courses("Law", "Putinkoff", 15, 0);

            coursesAndAttendenses.Add(c0);
            coursesAndAttendenses.Add(c1);
            coursesAndAttendenses.Add(c2);
            coursesAndAttendenses.Add(c3);
            coursesAndAttendenses.Add(c4);
            coursesAndAttendenses.Add(c5);
            coursesAndAttendenses.Add(c6);
            coursesAndAttendenses.Add(c7);
            //------------------------------------------------------------------------
            var student1 = new Student("Taras", "Shevchenko", 22, "Kiev");
            student1.CoursesAttended.Add(c2);   //Match     -   Ivanoff
            student1.CoursesAttended.Add(c3);   //Philosofy -   Petroff
            student1.CoursesAttended.Add(c7);   //Law       -   Putinkoff
            studentsAttendedCourses.Add(student1);
            //student1.PrintInfo();
            //------------------------------------------------------------------------
            var student2 = new Student("Petro", "Petroff", 26, "Lviv");
            student2.CoursesAttended.Add(c1);   //History   -   Ivanupollo
            student2.CoursesAttended.Add(c7);   //Law       -   Putinkoff
            studentsAttendedCourses.Add(student2);
            //student2.PrintInfo();
            //------------------------------------------------------------------------
            var techer1 = new Teacher("Petro", "Ivanupollo", 26, "Lviv");   //History
            techer1.CoursesAttended.Add(c1);
            techer1.StudentAttended.Add(student2);
            teacherLeadedCourses.Add(techer1);
            //techer1.PrintInfo();
            //------------------------------------------------------------------------
            var techer2 = new Teacher("Sidor", "Ivanoff", 28, "Kiev");      //Match
            techer2.CoursesAttended.Add(c2);        //History   -   Ivanoff
            techer2.StudentAttended.Add(student1);  //Taras     -   Shevchenko
            teacherLeadedCourses.Add(techer2);
            //techer2.PrintInfo();
            //------------------------------------------------------------------------
            var techer3 = new Teacher("Andrii", "Petroff", 33, "Kiev");      //Philosofy
            techer3.CoursesAttended.Add(c3);        //Philosofy -   Petroff
            techer3.StudentAttended.Add(student1);  //Taras     -   Shevchenko
            teacherLeadedCourses.Add(techer3);
            //techer3.PrintInfo();
            //------------------------------------------------------------------------
            var techer4 = new Teacher("Ivan", "Putinkoff", 47, "Kiev");      //Law
            techer3.CoursesAttended.Add(c7);
            techer3.StudentAttended.Add(student1);
            techer3.StudentAttended.Add(student2);
            //techer3.PrintInfo();

            //List<Person> studentsAndCourses = studentsAttendedCourses.SelectMany .Select(x => x.lastName);
            var studentsAndCourses = from student in studentsAttendedCourses.ToList()
                                     orderby student.LastName 
                                     select student;

            var teacherAndCourses  = from teacher in teacherLeadedCourses.ToList()
                                     orderby teacher.LastName
                                     select teacher;

            var coursesAndAttend = from course in coursesAndAttendenses.ToList()
                                   join teacher in teacherLeadedCourses.ToList() on course.CourseName equals teacher.CoursesAttended[0].CourseName
                                   join student in studentsAttendedCourses.ToList() on course.CourseName equals student.CoursesAttended[0].CourseName
                                   orderby course.CourseName
                                   select new { Course = course.CourseName, Teacher = teacher.LastName, Student = student.LastName };

            var groupedCourses   = from c in coursesAndAttend
                                   group c by c.Course into g
                                   select new { Course = g.Key, Teachers = g.Select(x => x.Teacher).Distinct(), Students = g.Select(x => x.Student).Distinct() };

            PrintPersonList(studentsAndCourses);
            PrintPersonList(teacherAndCourses);

            PrintGroupedCoursesList(groupedCourses);

            Console.WriteLine($"finish");

        }
        static void PrintPersonList(IEnumerable<dynamic> list)
        {
            foreach (var s in list)
            {
                Console.WriteLine($"{s.GetType().Name}: {s.LastName}, {s.FirstName} ");
                int i = 1;
                foreach (var c in s.CoursesAttended)
                {
                    Console.WriteLine($" {c.GetType().Name} #{i}: {c.CourseName}");
                    i++;
                }
            }
        }
        static void PrintGroupedCoursesList(IEnumerable<dynamic> list)
        {
            foreach (var g in list)
            {
                Console.WriteLine($"Course: {g.Course}");
                Console.WriteLine("Teachers:");
                foreach (var t in g.Teachers)
                {
                    Console.WriteLine($"- {t}");
                }
                Console.WriteLine("Students:");
                foreach (var s in g.Students)
                {
                    Console.WriteLine($"- {s}");
                }
            }
        }
    }
}