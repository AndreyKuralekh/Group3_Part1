﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_Hw6
{
    public class Teacher :Person
    {
        public Teacher() : this("NoBody")
        {
            Console.WriteLine("Contructor reload 1");
        }
        public Teacher(string firstName) : this(firstName, "NoBody")
        {
            this.FirstName = firstName;
            //Console.WriteLine("Contructor reload 2");
        }
        public Teacher(string firstName, string lastName) : this(firstName, lastName, 0)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            //Console.WriteLine("Contructor reload 3");
        }
        public Teacher(string firstName, string lastName, int age) : this(firstName, lastName, age, "Nowhere")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            //Console.WriteLine("Contructor reload 4");
        }
        public Teacher(string firstName, string lastName, int age, string city)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.City = city;
            //Console.WriteLine("Contructor reload 5");
        }
        public Teacher(string firstName, string lastName, int age, string city, Courses[] coursesAttended)
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
            Console.WriteLine("Person`s role: Teacher");
            base.PrintInfo();
        }

        public override void DescribeYourselfInfo()
        {
            Console.WriteLine("Person`s role: Teacher");
            base.DescribeYourselfInfo();
        }
    }
}
