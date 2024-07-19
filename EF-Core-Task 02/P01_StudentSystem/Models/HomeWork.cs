using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
    public class HomeWork
    {
        public int HomeworkId { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public ContentType ContentType { get; set; }

        [Required]
        public DateTime Submissiontime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
