using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STAWebsite.Models
{
    public class Auto_warning
    {
        [Key]
        public int aw_id { get; set; } // PK
        [Key]
        [ForeignKey("Instructor")]
        public int instructor_id { get; set;  } // FK
        [Key]
        [ForeignKey("Student")]
        public int student_id { get; set; } // FK

    }
    public class Auto_warningDBContext : DbContext
    {
        public DbSet<Auto_warning> Auto_Warnings { get; set; }
    }
}