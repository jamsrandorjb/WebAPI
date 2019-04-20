using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.DataAccess
{
    public class ApplicationDBInitializer : DropCreateDatabaseAlways<ApplicationDBContext>
    {
        /// <summary>
        /// Using this method as a DB initializer
        /// before running this we have to run first migration
        /// we can do that from nuget editor
        /// add-migration "comment here"
        /// </summary>
        protected override void Seed(ApplicationDBContext context)
        {
            var person = new Person { FirstName = "Jamsrandorj", LastName = "Batbayar", PreferredName = "Jama", PhoneNumber = "3196140255" };
            person.Email = "jamsrandorjb@outlook.com";
            person.githubUsername = "jamsrandorjb";
            person.linkedInUsername = "jamsrandorjb";
            Address addHome = new Address();
            addHome.City = "Raleigh";
            addHome.State = "NC";
            addHome.Country = "USA";
            addHome.Zip = 275606;
            person.HomeAddress = addHome;

        
            //savechanges
            WorkExperience w1 = new WorkExperience();
            w1.CompanyName = "National Institute of Environmental Health Sciences";
            w1.PositionHeld = "Software Developer";

            Address add1 = new Address();
            add1.City = "Morrisville";
            add1.State = "NC";
            add1.Country = "USA";
            add1.Zip = 27560;
            w1.WorkAddress = add1;

            w1.StartYear = 2018;
            w1.StartMonth = 11;
            w1.StartDay = 5;

            w1.IsCurrent = true;
            w1.Duties = "•	Resolved outstanding issues related to Back-end logic, Database objects, "
                + "and User Interface with existing .Net applications. "
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
            w1.JobType = JobType.FULLTIME;
            //savechanges
            person.WorkExperiences = new List<WorkExperience>();
            person.WorkExperiences.Add(w1);


            WorkExperience w2 = new WorkExperience();
            w2.CompanyName = "Unitel Group LLC";
            w2.PositionHeld = "Software Developer";

            Address add2 = new Address();
            add2.City = "Ulaanbaatar";
            add2.Country = "Mongolia";
            add2.Zip = 14200;
            w2.WorkAddress = add2;

            w2.StartYear = 2016;
            w2.StartMonth = 1;
            w2.StartDay = 13;

            w2.EndYear = 2017;
            w2.EndMonth = 10;
            w2.EndDay = 1;

            w2.IsCurrent = false;
            w2.Duties = "•	Developed back-end and front-end side of 'Gyals.uni' internal web platform "
                + "that provides customer care service by integrating to Billing system, Microsoft Dynamics "
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
            w2.JobType = JobType.FULLTIME;//TODO change string type to enum
            //savechanges

            person.WorkExperiences.Add(w2);

            
            //savechanges
            EducationExperience e1 = new EducationExperience();
            e1.UniversityName = "Maharishi University of Management";
            e1.EduField = "Computer Science";
            e1.EduDegree = EducationDegree.MASTERS;
            e1.AdditionalComment = "Completed on-campus studies, working full time and taking online courses to finish Masters in Computer Science";

            Address add3 = new Address();
            add3.City = "Fairfield";
            add3.State = "IA";
            add3.Country = "USA";
            add3.Zip = 52557;
            e1.UniversityAddress = add3;

            e1.StartYear = 2017;
            e1.StartMonth = 10;
            e1.StartDay = 22;

            e1.IsCurrent = true;
            //savechanges
            person.EdcuationExperiences = new List<EducationExperience>();
            person.EdcuationExperiences.Add(e1);







            EducationExperience e2 = new EducationExperience();
            e2.UniversityName = "Mongolian University of Science and Technology";
            e2.EduField = "Computer Science";
            e2.EduDegree = EducationDegree.BACHELORS;
            e2.AdditionalComment = "";

            Address add4 = new Address();
            add4.City = "Ulaanbaatar";
            add4.State = "";
            add4.Country = "Mongolia";
            add4.Zip = 14200;
            e2.UniversityAddress = add4;

            e2.StartYear = 2010;
            e2.StartMonth = 8;
            e2.StartDay = 25;

            e2.IsCurrent = false;

            e2.EndYear = 2015;
            e2.EndMonth = 1;
            e2.EndDay = 22;
            person.EdcuationExperiences.Add(e2);





            context.Person.Add(person);
            context.WorkExperiences.Add(w1);
            context.WorkExperiences.Add(w2);
            context.EducationExperience.Add(e1);
            context.EducationExperience.Add(e2);
            context.Address.Add(add1);
            context.Address.Add(add2);
            context.Address.Add(add3);
            context.Address.Add(add4);
            
            base.Seed(context);
        }
    }
}