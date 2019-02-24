using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    /// <summary>
    /// Represents one specific work experience
    /// </summary>
    public class WorkExperience
    {
        public WorkExperience() { }

        /// <summary>
        /// The unique identifier for the work experience
        /// </summary>
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string PositionHeld { get; set; }

        public string LocationCity { get; set; } 
        public string LocationCountry { get; set; }
        public int LocationZip { get; set; }

        public int StartYear { get; set; }
        public int StartMonth { get; set; }
        public int StartDay { get; set; }

        public int EndYear { get; set; }
        public int EndMonth { get; set; }
        public int EndDay { get; set; }

        public Boolean IsCurrent { get; set; }

        public string Duties { get; set; }
        public string JobType { get; set; }//TODO change string to ENUM type

    }
}