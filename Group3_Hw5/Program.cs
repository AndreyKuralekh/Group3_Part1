namespace Group3_Hw5
{
    /*
        Create a student class and describe its main characteristics: 
            - First name, 
            - last name, 
            - age, 
            - city, 
            - courses attended (an array of courses).
        
        Describe the following actions: Print (output basic information).
        
        Add one course to the student (add a new course to the course array).
        Delete a course from a student.
       
        Create a course class and describe its main characteristics: 
            - course name, 
            - teacher name, 
            - course duration, 
            - number of students.
        
        Describe the following actions: Print (output basic information).
        
        Add a student to the course group (add one student to the number of students).

    for each of the classes create a chain of calling constructors.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Courses[] courses = new Courses[10];
            courses[0] = new Courses("History", "Ivanupollo", 4, 0);
            courses[1] = new Courses("Match", "Ivanoff", 12, 0);
            courses[2] = new Courses("Philosofy", "Petroff", 8, 0);
            courses[3] = new Courses("Architecture", "Sidoroff", 6, 0);
            courses[4] = new Courses("Dentistry", "Petrenko", 22, 0);
            courses[5] = new Courses("Economics", "Ivanoff", 3, 0);
            courses[6] = new Courses("Law", "Putinkoff", 15, 0);
            
            //------------------------------------------------------------------------
            var student1 = new Student("Taras","Shevchenko",22, "Kiev");
            student1.AddNewCourse(courses[0]);
            student1.AddNewCourse(courses[1]);
            student1.AddNewCourse(courses[2]);
            student1.PrintInfo();
            //------------------------------------------------------------------------
            var student2 = new Student("Petro", "Petroff", 26, "Lviv");
            student2.AddNewCourse(courses[1]);
            student2.AddNewCourse(courses[6]);
            student2.PrintInfo();
            //------------------------------------------------------------------------


            student1.DeleteCourse("Match");
            student1.PrintInfo();
            student2.PrintInfo();
            //

            Console.WriteLine($"finish");

        }
    }
}