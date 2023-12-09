using Entites.Concretes;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category category1 = new Category();
            Course course1 = new Course();
            Course course2 = new Course();
            Instructor instructor1 = new Instructor();
            

            course1.Id = 1;
            course1.Name = "CSharp";  
            course1.Description = "Efilli CSharpCourse";
            course1.Price = 20;
            course1.Category = category1;
            course1.Instructor = instructor1;

            course2.Id = 2;
            course2.Name = "Java";
            course2.Description = "Efilsiz Java";
            course2.Price = 20;
            course2.Category = category1;
            course2.Instructor = instructor1;

            instructor1.Id = 3;
            instructor1.Name = "Engin";
            instructor1.Courses = new List<Course>()
            {
                course1, course2
            }; 

            category1.Id = 4;
            category1.Name = "Demiroğ";
            category1.Courses = new List<Course>() { course1, course2 };

            foreach (var course in category1.Courses )
            {
                Console.WriteLine(course.Name);
            }
            Console.WriteLine(course1.Name + " " + course1.Description);

        }
    }
}