using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STAWebsite.Models
{
    public class S_rate_I
    {
        [Key]
        public int rating_id { get; set; } //PK

        public int i_criteria_1 { get; set; }
        public int i_criteria_2 { get; set; }
        public int i_criteria_3 { get; set; }
        public int i_criteria_4 { get; set; }
        public string review { get; set; }
        [Key]
        [ForeignKey("Instructor")]
        public int instructor_id { get; set; } // FK
        [Key]
        [ForeignKey("Student")]
        public int student_id { get; set; } // FK
    }

    public class S_rate_IDBContext : DbContext
    {
        public DbSet<S_rate_I>  S_Rate_Is { get; set; }
    }
}