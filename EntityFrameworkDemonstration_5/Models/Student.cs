using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemonstration_5.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailId { get; set; }

        [Required]
        [StringLength(15)]
        [Column("ContactNumber")]
        public string ContactNo { get; set; }

        [StringLength(20)]
        public string Qualification { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}