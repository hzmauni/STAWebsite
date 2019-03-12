using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STAWebsite.Models
{
    public class Enroll
    {
        [Key]
        public int enroll_id { get; set; }  //PK
        [Key]
        [ForeignKey("Student")]
        public int student_id { get; set; } //FK
        [Key]
        [ForeignKey("Course")]
        public int course_id { get; set; }  //FK
    }

    public class EnrollDBContext : DbContext
    {
        public DbSet<Enroll> Enrolls { get; set; }
    }
}