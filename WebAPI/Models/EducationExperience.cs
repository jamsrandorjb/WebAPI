using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public enum EducationDegree
    {
        MASTERS, BACHELORS, GENERALEDUCATION
    }

    public class EducationExperience
    {
        public EducationExperience() { }

        /// <summary>
        /// The unique identifier for the education experience
        /// </summary>
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string UniversityName { get; set; }
        public EducationDegree? EduDegree { get; set; }
        public string EduField { get; set; }
        public double GPA { get; set; } 
        public string AdditionalComment { get; set; }

       public Address UniversityAddress { get; set; }

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

        
    }
}




