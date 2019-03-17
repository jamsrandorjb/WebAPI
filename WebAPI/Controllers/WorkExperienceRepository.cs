using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Controllers;
using WebAPI.DataAccess;

namespace WebAPI.Models
{
    public class WorkExperienceRepository : IWorkExperience
    {
        private List<WorkExperience> workExperiences = new List<WorkExperience>();

        /// <summary>
        /// 
        /// </summary>
        public WorkExperienceRepository()
        {
            using (var db = new ApplicationDBContext())
            {
                workExperiences = db.WorkExperiences.ToList();
            }
        }
        /// <summary>
        /// find work experience by ID, using Linq here. FirstOrDefault
        /// if there is no work experience related to the input it will return null
        /// </summary>
        /// <param name="id">Id of the work experience</param>
        /// <returns>Work Experience object</returns>
        public WorkExperience find(int id)
        {
            return workExperiences.Where(e => e.Id == id).FirstOrDefault();
        }

        public List<WorkExperience> findAll()
        {
            return workExperiences.OrderBy(x => x.Id).ToList();
        }

        public void addExperience(WorkExperience we)
        {
            this.workExperiences.Add(we);
        }
        /// <summary>
        /// Returning only company names that I worked, using Linq, casting
        /// </summary>
        /// <returns>List of company names</returns>
        public List<string> GetCompanyNames()
        {
            return this.workExperiences.Select(x => x.CompanyName).ToList();
        }

        public void removeExperience(int id)
        {
            this.workExperiences.Remove(workExperiences.Where(e => e.Id == id).FirstOrDefault());
        }
    }
}