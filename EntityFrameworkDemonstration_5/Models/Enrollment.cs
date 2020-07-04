using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemonstration_5.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }
    }
}