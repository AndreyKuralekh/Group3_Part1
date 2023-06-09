using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_Hw6
{
    internal class Student :Person
    {
        public Student() : this("NoBody")
        {
            Console.WriteLine("Contructor reload 1");
        }
        public Student(string firstName) : this(firstName, "NoBody")
        {
            this.FirstName = firstName;
            //Console.WriteLine("Contructor reload 2");
        }
        public Student(string firstName, string lastName) : this(firstName, lastName, 0)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            //Console.WriteLine("Contructor reload 3");
        }
        public Student(string firstName, string lastName, int age) : this(firstName, lastName, age, "Nowhere")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            //Console.WriteLine("Contructor reload 4");
        }
        public Student(string firstName, string lastName, int age, string city)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.City = city;
            //Console.WriteLine("Contructor reload 5");
        }
        public Student(string firstName, string lastName, int age, string city, Courses[] coursesAttended)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.City = city;
            this.CoursesAttended = coursesAttended;
            //Console.WriteLine("Contructor reload 6");
        }
        public override void PrintInfo()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Person`s role: Student");
            Console.WriteLine("============================================");
            base.PrintInfo();
        }

        public override void DescribeYourselfInfo()
        {

            Console.WriteLine("============================================");
            Console.WriteLine("Person`s role: Student");
            Console.WriteLine("============================================");
            base.DescribeYourselfInfo();
        }

        //Delete a course from a student.
        public void DeleteCourse(string courceName)
        {
            int i = 0;
            int findOf = 0;
            foreach (var cource in this.CoursesAttended)
            {
                if (cource.CourseName == courceName)
                {
                    findOf = i;
                    break;
                }
                i++;
            }
            this.CoursesAttended = this.CoursesAttended.Where((val, idx) => idx != findOf).ToArray();
        }
    }
}
