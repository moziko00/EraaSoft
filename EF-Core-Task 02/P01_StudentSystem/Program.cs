using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data;
using P01_StudentSystem.Models;
using System.Reflection.Metadata;

namespace P01_StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ApplicationDbContext context = new ApplicationDbContext();


            var courses=context.Courses.Include(C=>C.Students).ToList();

            foreach (var course in courses)
            {
                Console.WriteLine($"Course : {course.Name}");
                Console.WriteLine("Student Enrolled : ");

                foreach (var student in course.Students)
                {
                    Console.WriteLine($" : {student.Student.Name} ");
                }
            }


            Console.ReadLine();


        }
    }
}
