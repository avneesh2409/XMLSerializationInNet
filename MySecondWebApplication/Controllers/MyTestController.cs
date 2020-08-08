using Microsoft.AspNetCore.Mvc;
using MySecondWebApplication.Models;
using MySecondWebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondWebApplication.Controllers
{
    [Route("api")]
    public class MyTestController
    {
        private readonly ISchoolRepository _context;
        private readonly IUserModel _userContext;
        private readonly IStudentRepository _studentContext;

        public MyTestController(ISchoolRepository context,IStudentRepository studentContext,IUserModel userContext)
        {
            _studentContext = studentContext;
            _context = context;
            _userContext = userContext;
        }
        #region School
        [Route("schools")]
        public ObjectResult GetSchools()
        {
            return new ObjectResult(_context.GetSchools());
        }
        [HttpPost]
        [Route("school/add")]
        public ObjectResult AddSchool(School school) {
            var res = _context.AddSchool(school);
            return new ObjectResult(res);
        }
        [HttpPost]
        [Route("school/update")]
        public ObjectResult UpdateSchool([FromBody]  School school) {
            return new ObjectResult(_context.UpdateSchool(school));
        }
        #endregion

        #region Student

        [Route("students")]
        public ObjectResult GetStudents()
        {
            var result = _studentContext.GetStudents();
            return new ObjectResult(result);
        }
        [HttpPost]
        [Route("student/add")]
        public ObjectResult AddStudent([FromBody] StudentAddModel student)
        {
            var result = _studentContext.AddStudent(student);
            return new ObjectResult(result);
        }
        #endregion

        #region User
        [HttpPost]
        [Route("register")]
        public bool RegisterUser([FromBody] UserModel user)
        {
            bool res = _userContext.AddUser(user);
            return res;
        }
        #endregion
    }
}
