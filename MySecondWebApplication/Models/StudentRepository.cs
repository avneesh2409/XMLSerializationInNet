using Microsoft.EntityFrameworkCore;
using MySecondWebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Models
{
    public class StudentRepository : IStudentRepository
    {
        private AppDbContext _context;
        public StudentRepository(AppDbContext context) {
            _context = context;
        }

        public bool AddStudent(StudentAddModel student)
        {
            try
            {
                _context.students.Add(new Student
                {
                    Name = student.Name,
                    Address = student.Address,
                    SchoolId = student.SchoolId
                });
                    _context.SaveChanges();
                    return true;
            }
            catch(Exception ex) {
                return false;
            }
        }

        public Student DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(int id)
        {
            try
            {
                var result = _context.students.Where(s => s.Id == id)
                    .Include(s => s.School)
                    .FirstOrDefault();
                return result;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public IEnumerable<Student> GetStudents()
        {                 
            var result = _context.students.Include(s=>s.School);
            return result;
        }

        public Student UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
