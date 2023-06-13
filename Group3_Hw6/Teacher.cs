using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_Hw7
{
    public class Teacher :Person
    {
        public StudentCollection<Student> StudentAttended = new StudentCollection<Student>();
        public Teacher() : this("NoBody")
        {
            Console.WriteLine("Contructor reload 1");
        }
        public Teacher(string firstName) : this(firstName, "NoBody")
        {
            this.FirstName = firstName;
        }
        public Teacher(string firstName, string lastName) : this(firstName, lastName, 0)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Teacher(string firstName, string lastName, int age) : this(firstName, lastName, age, "Nowhere")
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public Teacher(string firstName, string lastName, int age, string city)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.City = city;
        }
/*        public Teacher(string firstName, string lastName, int age, string city, List<Courses> coursesAttended)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.City = city;
            this.CoursesAttended = coursesAttended;
        }
*/
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
