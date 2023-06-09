using Group3_Hw6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_Hw6
{
    public abstract class Person
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Age { get; set; }
        protected string City { get; set; }

        protected Courses[] CoursesAttended = new Courses[10];

        //output basic information
        public virtual void PrintInfo()
        {
            Console.WriteLine("Basic persion`s info:");
            Console.WriteLine("============================================");
            Console.WriteLine($"FirstName: {this.FirstName}");
            Console.WriteLine($"LastName: {this.LastName}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine($"City: {this.City}");

            Console.WriteLine("============================================");
            Console.WriteLine("Courses list:");
            Console.WriteLine("============================================");
            int i = 1;
            foreach (var cousrce in CoursesAttended)
            {
                if (!(cousrce == null))
                {
                    Console.Write($"{i++}.");
                    cousrce.PrintCourceInfo();
                }
            }

        }

        //output Exch. information
        public virtual void DescribeYourselfInfo()
        {
            Console.WriteLine("Exchanged person`s info:");
            Console.WriteLine("============================================");
            Console.WriteLine($"FirstName: {this.FirstName}");
            Console.WriteLine($"LastName: {this.LastName}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine($"City: {this.City}");

            Console.WriteLine("============================================");
            Console.WriteLine("Courses list:");
            Console.WriteLine("============================================");
            int i = 1;
            foreach (var cousrce in CoursesAttended)
            {
                if (!(cousrce == null))
                {
                    Console.Write($"{i++}.");
                    cousrce.PrintCourceInfo();
                }
            }
        }
        //Add one course to the student(add a new course to the course array).
        public void AddNewCourse(Courses newCource)
        {
            int i = 0;
            foreach (var cource in this.CoursesAttended)
            {
                if (cource == null)
                {
                    this.CoursesAttended[i] = newCource;
                    this.CoursesAttended[i].AddOneStudent();
                    break;
                }
                i++;
            }
        }
    }
}
