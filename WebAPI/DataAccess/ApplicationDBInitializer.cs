using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.DataAccess
{
    public class ApplicationDBInitializer
    { 
        /// <summary>
        /// Using this method as a DB initializer
        /// before running this we have to run first migration
        /// we can do that from nuget editor
        /// add-migration "comment here"
        /// </summary>
        public ApplicationDBInitializer() {
            using (var db = new ApplicationDBContext()) {
                db.Database.Migrate();
                var maxItem = db.People.OrderByDescending(i => i.Id).FirstOrDefault();
                var newID = maxItem == null ? 1 : maxItem.Id + 1;
                //inserting myself
                var person = new Person { Id = newID, FirstName = "Jamsrandorj", LastName = "Batbayar", PreferredName = "Jama", PhoneNumber = "3196140255" };
                db.SaveChanges();



                WorkExperience w1 = new WorkExperience();
                w1.Id = 1;
                w1.CompanyName = "National Institute of Environmental Health Sciences";
                w1.PositionHeld = "Jr Software Developer";

                Address add1 = new Address();
                add1.City = "Morrisville";
                add1.Country = "United States of America";
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
                person.WorkExperiences.Add(w1);
                

                WorkExperience w2 = new WorkExperience();
                w2.Id = 2;
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
                person.WorkExperiences.Add(w2);
                db.SaveChanges();




            }
        }
    }
}