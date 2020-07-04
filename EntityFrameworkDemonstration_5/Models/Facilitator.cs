using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemonstration_5.Models
{
    public class Facilitator
    {
        public int FacilitatorId { get; set; }

        public string Name { get; set; }

        public string ContactNo { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}