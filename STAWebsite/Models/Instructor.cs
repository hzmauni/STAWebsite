using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STAWebsite.Models
{
    public class Instructor
    {
        [Key]
        public int instructor_id { get; set; }
        public string instructor_name { get; set; }
        public string instructor_password { get; set; }
        public int i_courses { get; set; }
        public float i_avg_rating { get; set; }
    }
    public class InstructorDBContext : DbContext
    {
        
        public DbSet<Instructor> Instructors { get; set; }
    }
}