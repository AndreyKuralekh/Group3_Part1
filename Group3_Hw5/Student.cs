using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_Hw5
{
    internal class Student
    {
        private string FirstName { get; set; }
        private string LastName { get; set; } 
        private int Age { get; set; } 
        private string City { get; set; } 

        private Courses[] CoursesAttended = new Courses[10];

        public Student(): this("NoBody") 
        {
            Console.WriteLine("Contructor reload 1");
        }
        public Student(string firstName) :this(firstName, "NoBody")
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

        //output basic information
        public void PrintInfo () 
        {
            Console.WriteLine("============================================");

            Console.WriteLine("============================================");
            Console.WriteLine("Basic student`s info:");
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
        public void AddNewCourse(Courses newCource ) 
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
