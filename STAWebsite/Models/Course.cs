using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STAWebsite.Models
{
    public class Course
    {
        [Key]
        public int course_id { get; set; }
        public string course_name { get; set; }
        public string course_code { get; set; }
    }
    public class CourseDBContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
    }
}