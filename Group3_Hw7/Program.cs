namespace Group3_Hw7
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
            Courses c0 = new Courses("Grammar", "Ivanupenkoff", 8, 0);
            Courses c1 = new Courses("History", "Ivanupollo", 4, 0);
            Courses c2 = new Courses("Match", "Ivanoff", 12, 0);
            Courses c3 = new Courses("Philosofy", "Petroff", 8, 0);
            Courses c4 = new Courses("Architecture", "Sidoroff", 6, 0);
            Courses c5 = new Courses("Dentistry", "Petrenko", 22, 0);
            Courses c6 = new Courses("Economics", "Ivanoff", 3, 0);
            Courses c7 = new Courses("Law", "Putinkoff", 15, 0);

            //------------------------------------------------------------------------
            var student1 = new Student("Taras","Shevchenko",22, "Kiev");
            student1.CoursesAttended.Add(c2);   //Match     -   Ivanoff
            student1.CoursesAttended.Add(c3);   //Philosofy -   Petroff
            student1.CoursesAttended.Add(c7);   //Law       -   Putinkoff
            student1.PrintInfo();
            //------------------------------------------------------------------------
            var student2 = new Student("Petro", "Petroff", 26, "Lviv");
            student2.CoursesAttended.Add(c1);   //History   -   Ivanupollo
            student2.CoursesAttended.Add(c7);   //Law       -   Putinkoff
            student2.PrintInfo();
            //------------------------------------------------------------------------
            var techer1 = new Teacher("Petro", "Ivanupollo", 26, "Lviv");   //History
            techer1.CoursesAttended.Add(c1);
            techer1.StudentAttended.Add(student2);
            techer1.PrintInfo();
            //------------------------------------------------------------------------
            var techer2 = new Teacher("Sidor", "Ivanoff", 28, "Kiev");      //Match
            techer2.CoursesAttended.Add(c1);        //History   -   Ivanupollo
            techer2.StudentAttended.Add(student1);  //Taras     -   Shevchenko
            techer2.PrintInfo();
            //------------------------------------------------------------------------
            var techer3 = new Teacher("Andrii", "Petroff", 33, "Kiev");      //Philosofy
            techer3.CoursesAttended.Add(c3);        //Philosofy -   Petroff
            techer3.StudentAttended.Add(student1);  //Taras     -   Shevchenko
            techer3.PrintInfo();
            //------------------------------------------------------------------------
            var techer4 = new Teacher("Ivan", "Putinkoff", 47, "Kiev");      //Law
            techer3.CoursesAttended.Add(c7);
            techer3.StudentAttended.Add(student1);
            techer3.StudentAttended.Add(student2);
            techer3.PrintInfo();

            Console.WriteLine($"finish");

        }
    }
}