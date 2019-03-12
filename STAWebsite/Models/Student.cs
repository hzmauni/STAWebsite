using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STAWebsite.Models
{
    public class Student
    {
        [Key]
        public int student_id { get; set; }
        public string student_name { get; set; }
        public string student_password { get; set; }
        public int s_courses { get; set; }
        public float s_avg_rating { get; set; }
    }
    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}