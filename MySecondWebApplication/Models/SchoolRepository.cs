using Microsoft.AspNetCore.Mvc;
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
        public School UpdateSchool(School school) {
             
            var entity = _context.schools.FirstOrDefault(item => item.Id == school.Id);
            if (entity != null)
            {
                entity.Name = school.Name;
                _context.SaveChanges();
                return school;
            }
            return null;
        }
        public IEnumerable<School> GetSchools()
        {
            return _context.schools;
        }
    }
}
