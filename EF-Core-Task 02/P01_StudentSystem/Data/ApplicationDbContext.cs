using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet <Student> Students { get; set; }
        public DbSet <Course> Courses { get; set; }
        public DbSet <Resource> Resources { get; set; }
        public DbSet <HomeWork> HomeworksSubmission { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Student_System;Integrated Security=True;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<StudentCourse>()
                .HasKey(SC => new { SC.StudentId, SC.CourseId });


            modelBuilder.Entity<Student>()
                .HasMany(S => S.HomeworkSubmissions)
                .WithOne(H => H.Student)
                .HasForeignKey(H => H.StudentId);

            modelBuilder.Entity<Student>()
                .HasMany(S=>S.Courses)
                .WithOne(SC=>SC.Student)
                .HasForeignKey(SC => SC.StudentId);

            modelBuilder.Entity<Course>()
                .HasMany(C => C.Students)
                .WithOne(SC => SC.Course)
                .HasForeignKey(SC => SC.CourseId);

            modelBuilder.Entity<Course>()
                .HasMany(C => C.HomewrkSubmissions)
                .WithOne(R => R.Course)
                .HasForeignKey(R => R.CourseId);

            modelBuilder.Entity<Course>()
                .HasMany(C => C.HomewrkSubmissions)
                .WithOne(H => H.Course)
                .HasForeignKey(H => H.CourseId);



            List<Student> listofStudents = new List<Student>();
            listofStudents.Add(new Student
            { 
                StudentId = 1,
                Name = "Mohamed",
                PhoneNumber = "019289337",
                RegisteredOn = DateTime.Now,
                Birthday = new DateTime(2000, 5, 1)
            });
            listofStudents.Add(new Student
            { 
                StudentId = 2,
                Name = "Hema",
                PhoneNumber = "786354521",
                RegisteredOn = DateTime.Now,
                Birthday = new DateTime(2004, 2, 16)
            });


            modelBuilder.Entity<Student>().HasData(listofStudents);


            List<Course> listcourses = new List<Course>();
            listcourses.Add(new Course
            {
                CourseId = 1,
                Name = "Cource 1",
                Description = "Content Cource 1",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(3),
                Price = 99.99m
            });

            listcourses.Add(new Course
            {
                CourseId = 2,
                Name = "Course 2",
                Description = "Content Cource 2",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(6),
                Price = 94.99m
            });
            modelBuilder.Entity<Course>().HasData(listcourses);



            List<Resource> listofResources = new List<Resource>();
            listofResources.Add(new Resource
            {
                ResourceId = 1,
                Name = "Resource 1",
                URL = "https://Test1.com",
                ResourceType = ResourceType.Video,
                CourseId = 1
            });
            listofResources.Add(new Resource
            {
                ResourceId = 2,
                Name = "Resource 2",
                URL = "https://Test2.com",
                ResourceType = ResourceType.Document,
                CourseId = 2
            });

            modelBuilder.Entity<Resource>().HasData(listofResources);


            List<HomeWork> listofHomework = new List<HomeWork>();
            listofHomework.Add(new HomeWork
            {
                HomeworkId = 1,
                Content = "homework1.pdf",
                ContentType = ContentType.Pdf,
                Submissiontime = DateTime.Now,
                StudentId = 1,
                CourseId = 1
            });


            listofHomework.Add(new HomeWork
            {
                HomeworkId = 2,
                Content = "homework2.zip",
                ContentType = ContentType.Zip,
                Submissiontime = DateTime.Now,
                StudentId = 2,
                CourseId = 2
            });

            modelBuilder.Entity<HomeWork>().HasData(listofHomework);




        }
    }
}
