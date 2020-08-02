using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Models
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly AppDbContext _context;
        public SchoolRepository(AppDbContext context) {
            _context = context;
        }
        public School AddSchool(School school)
        {
            _context.schools.Add(school);
            _context.SaveChanges();
            return school;
        }

        public IEnumerable<School> GetSchools()
        {
            return _context.schools;
        }
    }
}
