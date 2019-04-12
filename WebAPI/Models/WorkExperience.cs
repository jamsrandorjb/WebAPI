using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{

    public enum JobType
    {
        FULLTIME, PARTTIME, INTERN, VOLUNTEER
    }


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

        public Address WorkAddress { get; set; }

        //TODO create abstract class for edu and work experience, so they don't have to write these lines two times
        #region tobeabstracted
        public int StartYear { get; set; }
        public int StartMonth { get; set; }
        public int StartDay { get; set; }

        public int EndYear { get; set; }
        public int EndMonth { get; set; }
        public int EndDay { get; set; }

        public Boolean IsCurrent { get; set; }
        #endregion

        public string Duties { get; set; }
        public JobType? JobType { get; set; }//TODO change string to ENUM type

    }
}