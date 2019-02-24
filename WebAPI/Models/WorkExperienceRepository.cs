using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class WorkExperienceRepository : IWorkExperience
    {
        private List<WorkExperience> workExperiences = new List<WorkExperience>();

        /// <summary>
        /// I used fake data, haven't connected to DB yet
        /// </summary>
        public WorkExperienceRepository(){

            WorkExperience w1 = new WorkExperience();
            w1.Id = 1;
            w1.CompanyName = "National Institute of Environmental Health Sciences";
            w1.PositionHeld = "Jr Software Developer";

            w1.LocationCity = "Morrisville";
            w1.LocationCountry = "United States of America";
            w1.LocationZip = 27560;

            w1.StartYear = 2018;
            w1.StartMonth = 11;
            w1.StartDay = 5;
            
            w1.IsCurrent = true;
            w1.Duties = "•	Resolved outstanding issues related to Back-end logic, Database objects, "
                +"and User Interface with existing .Net applications. "
                + "•	Reverse engineering from application source to create project solution, find "
                + "existing bugs, fixed them and deployed it back to production."
                + "•	Modified the internal electron library’s search engine logic due to increasing "
                + "parameters and parameter restrictions set by Thunderstone.Solved this issue by looping "
                + "through the parameters and sending Asynchronous requests."
                + "•	Developed console apps that create Excel reports using Web API’s and SQL queries, "
                + "automated them using Jenkins."
                + "•	As a team, established standard operating procedure-SOP for code deployment."
                + "•	Technologies: C#, .Net, Web API, Entity Framework, ADO.net, Jenkins, Oracle SQL, "
                + "Javascript, Kendo UI, SVN, MVC, JIRA, Windows Server, IIS, XML.";
            w1.JobType = "Full time/Contractor";//TODO change string type to enum
            workExperiences.Add(w1);


            WorkExperience w2 = new WorkExperience();
            w2.Id = 2;
            w2.CompanyName = "Unitel Group LLC";
            w2.PositionHeld = "Software Developer";

            w2.LocationCity = "Ulaanbaatar";
            w2.LocationCountry = "Mongolia";
            w2.LocationZip = 14200;

            w2.StartYear = 2016;
            w2.StartMonth = 1;
            w2.StartDay = 13;

            w2.EndYear = 2017;
            w2.EndMonth = 10;
            w2.EndDay = 1;

            w2.IsCurrent = false;
            w2.Duties = "•	Developed back-end and front-end side of 'Gyals.uni' internal web platform "
                +"that provides customer care service by integrating to Billing system, Microsoft Dynamics "
                + "CRM and Mobile Message Center. /AngularJS client-side development, C# .NET server-side development, "
                + "and OracleDB database management/"
                + "•	Sped up the Billing system performance by optimizing existing stored procedures, backing up "
                + "unused data and creating necessary indexes.  "
                + "•	Developed Mobile USSD services for customized promotion campaigns that based on nearly "
                + "near time data. / 1 - 2 minutes delayed data /"
                + "•	Maintained internal Billing system “Number.uni” that uses Rest API to connect Core Billing system, "
                + "OCS system and Microsoft Dynamics CRM, developed new windows for direct campaigns to streamline rewards "
                + "and promotion programs and its reporting windows as well."
                + "•	Technologies: C#, .Net, JavaScript, Rest API, AngularJS, Oracle DB PL-SQL, MVC, JIRA, Shell Scripting, "
                + "Windows Server, Linux Server.";
            w2.JobType = "Full time";//TODO change string type to enum
            workExperiences.Add(w2);


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

        public void addExperience(WorkExperience we) {
            this.workExperiences.Add(we);
        }
        /// <summary>
        /// Returning only company names that I worked, using Linq, casting
        /// </summary>
        /// <returns>List of company names</returns>
        public List<string> GetCompanyNames(){
            return this.workExperiences.Select(x => x.CompanyName).ToList();
        }

        public void removeExperience(int id) {
            this.workExperiences.Remove(workExperiences.Where(e => e.Id == id).FirstOrDefault());
        }
    }
}