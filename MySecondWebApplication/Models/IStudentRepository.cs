using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        Student AddStudent(Student student);
    }
}
