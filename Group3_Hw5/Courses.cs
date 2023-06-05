using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group3_Hw5
{
    public class Courses
    {
        public string CourseName { get; set; }
        private string TeacherName { get; set; }
        private int CourseDuration { get; set; }
        private int NumberOfStudents { get; set; }
        public Courses() : this("NoName")
        { 
        }
        public Courses(string courseName) : this(courseName, "NoBody")
        { 
            this.CourseName = courseName;
        }
        public Courses(string courseName, string teacherName) : this(courseName, teacherName, 0)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
        }
        public Courses(string courseName, string teacherName, int courseDuration) : this(courseName, teacherName, courseDuration, 0)
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.CourseDuration = courseDuration;
        }
        public Courses(string courseName, string teacherName, int courseDuration, int numberOfStudents) 
        {
            this.CourseName = courseName;
            this.TeacherName = teacherName;
            this.CourseDuration = courseDuration;
            this.NumberOfStudents = numberOfStudents;
        }
        public void PrintCourceInfo()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"CourseName: {CourseName}");
            Console.WriteLine($"TeacherName: {TeacherName}");
            Console.WriteLine($"CourseDuration: {CourseDuration}");
            Console.WriteLine($"NumberOfStudents: {NumberOfStudents}");
        }
        public void AddOneStudent()
        {
            this.NumberOfStudents++;
        }
        public void RemoveOneStudent()
        {
            this.NumberOfStudents--;
        }
    }
}
