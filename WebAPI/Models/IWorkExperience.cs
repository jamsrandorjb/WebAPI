using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public interface IWorkExperience
    {
        List<WorkExperience> findAll();
        WorkExperience find(int id);
        void removeExperience(int id);
        void addExperience(WorkExperience we);
    }
}