using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STAWebsite.Models
{
    public class I_rate_S
    {
        [Key]
        public int rating_id { get; set; } //PK

        public int s_criteria_1 { get; set; }
        public int s_criteria_2 { get; set; }
        public int s_criteria_3 { get; set; }
        [Key]
        [ForeignKey("Instructor")]
        public int instructor_id { get; set; } // FK
        [Key]
        [ForeignKey("Student")]
        public int student_id { get; set; } // FK
    }

    public class I_rate_SContext : DbContext
    {
        public DbSet<I_rate_S> I_Rate_Ss { get; set; }

    }
}