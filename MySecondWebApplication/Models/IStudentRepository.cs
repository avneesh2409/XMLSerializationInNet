using MySecondWebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        bool AddStudent(StudentAddModel student);
        Student DeleteStudent(int id);
        Student UpdateStudent(Student student);
    }
}
