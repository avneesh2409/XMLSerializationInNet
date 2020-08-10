using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Models
{
    public interface ISchoolRepository
    {
        IEnumerable<School> GetSchools();
        School AddSchool(School school);
        School UpdateSchool(School school);
        School DeleteSchool(int id);
    }
}
