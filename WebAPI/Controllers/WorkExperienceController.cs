using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    /// <summary>
    /// This is where you can pull all the information about my work experience
    /// </summary>
    public class WorkExperienceController : System.Web.Http.ApiController
    {
        private WorkExperienceRepository wer;
        public WorkExperienceController() {
            if (wer == null)
                wer = new WorkExperienceRepository();
        }

        /// <summary>
        /// Gets a list of company names that I worked, I used WEB API custom route here
        /// </summary>
        /// <returns>A list of compnay names</returns>
        //GET api/workexperience/getcompanynames
        [HttpGet]
        [ActionName("GetCompanyNames")]
        public List<string> GetCompanyNames() {   
            return wer.GetCompanyNames();
        }

        /// <summary>
        /// Gets a list of work experiences
        /// </summary>
        /// <returns>a list of work experience</returns>
        //GET api/workexperience/get
        [NonAction]
        public List<WorkExperience> Get() {
            return wer.findAll();
        }

        /// <summary>
        /// Get a work experience by ID
        /// </summary>
        /// <param name="id">ID of the work experience</param>
        /// <returns>Work experience information</returns>
        //GET api/workexperience/get/id
        [NonAction]
        public WorkExperience Get(int id) {
            return wer.find(id);
        }

        //POST api/workexperience/post
        [NonAction]
        public void Post(WorkExperience we) {
            wer.addExperience(we);
        }

        //DELETE api/workexperience/delete/id
        [NonAction]
        public void Delete(int id) {
            wer.removeExperience(id);
        }
    }
}