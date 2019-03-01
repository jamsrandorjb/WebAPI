using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PreferredName { get; set; }
        public string PhoneNumber { get; set; }

        public Address HomeAddress { get; set; }

        public List<WorkExperience> WorkExperiences { get; set; }
        public List<EducationExperience> EdcuationExperiences { get; set; }

    }
}