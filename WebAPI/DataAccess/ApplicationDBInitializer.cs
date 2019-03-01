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


            }
        }
    }
}