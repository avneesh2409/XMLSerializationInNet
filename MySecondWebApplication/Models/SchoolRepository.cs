﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public School DeleteSchool(int id)
        {
            try
            {
                var x = _context.schools.Find(id);
                _context.schools.Remove(x);
                _context.SaveChanges();
                return x;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        public School GetSchoolById(int id)
        {
            try
            {
                var result = _context.schools.FirstOrDefault(e=>e.Id==id);
                return result;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
