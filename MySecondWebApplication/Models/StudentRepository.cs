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
                var res = _context.schools.Where(e=>e.Id == student.SchoolId).FirstOrDefault();
                if (res != null) {
                    _context.students.Add(new Student { 
                           Name=student.Name,
                           Address=student.Address,
                           SchoolId=student.SchoolId,
                           School=res
                    });
                    _context.SaveChanges();
                    return true;
                }
                
                return false;
            }
            catch(Exception ex) {
                return false;
            }
        }

        public Student DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            var result = _context.students;
            return result;
        }

        public Student UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
