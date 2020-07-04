using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemonstration_5.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int DurationInDays { get; set; }

        public int Price { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        //public virtual Facilitator Facilitator { get; set; }
    }
}