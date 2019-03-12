
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STAWebsite.Models
{
    public class Teach
    {
        [Key]
        public int teach_id { get; set; } //PK
        [Key]
        [ForeignKey("Instructor")]
        public int instructor_id { get; set; } // FK
        [Key]
        [ForeignKey("Student")]
        public int student_id { get; set; } // FK
    }

    public class TeachDBContext : DbContext
    {
        public DbSet<Teach> Teachs{ get; set; }
    }
}