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

        public Student AddStudent(Student student)
        {
            Student result = null;
            _context.students.Add(student);
            _context.SaveChanges();
            return result;
        }

        public IEnumerable<Student> GetStudents()
        {
            var result = _context.students;
            return result;
        }
        
    }
}
