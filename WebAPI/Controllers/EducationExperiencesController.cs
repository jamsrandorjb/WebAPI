using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.DataAccess;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class EducationExperiencesController : ApiController
    {
        private ApplicationDBContext db = new ApplicationDBContext();

        // GET: api/EducationExperiences
        public IQueryable<EducationExperience> GetEducationExperience()
        {
            return db.EducationExperience.Include("UniversityAddress");
        }

        // GET: api/EducationExperiences/5
        [ResponseType(typeof(EducationExperience))]
        public async Task<IHttpActionResult> GetEducationExperience(int id)
        {
            EducationExperience educationExperience = await db.EducationExperience.FindAsync(id);
            if (educationExperience == null)
            {
                return NotFound();
            }

            return Ok(educationExperience);
        }

        // PUT: api/EducationExperiences/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEducationExperience(int id, EducationExperience educationExperience)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != educationExperience.Id)
            {
                return BadRequest();
            }

            db.Entry(educationExperience).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducationExperienceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/EducationExperiences
        [ResponseType(typeof(EducationExperience))]
        public async Task<IHttpActionResult> PostEducationExperience(EducationExperience educationExperience)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EducationExperience.Add(educationExperience);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = educationExperience.Id }, educationExperience);
        }

        // DELETE: api/EducationExperiences/5
        [ResponseType(typeof(EducationExperience))]
        public async Task<IHttpActionResult> DeleteEducationExperience(int id)
        {
            EducationExperience educationExperience = await db.EducationExperience.FindAsync(id);
            if (educationExperience == null)
            {
                return NotFound();
            }

            db.EducationExperience.Remove(educationExperience);
            await db.SaveChangesAsync();

            return Ok(educationExperience);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EducationExperienceExists(int id)
        {
            return db.EducationExperience.Count(e => e.Id == id) > 0;
        }
    }
}