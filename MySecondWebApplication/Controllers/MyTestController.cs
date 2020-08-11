using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MySecondWebApplication.Models;
using MySecondWebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MySecondWebApplication.Controllers
{
    [Authorize]
    [Route("api")]
    [ApiController]
    public class MyTestController : Controller
    {
        private readonly ISchoolRepository _context;
        private readonly IUserModel _userContext;
        private readonly IConfiguration _config;
        private readonly IStudentRepository _studentContext;

        public MyTestController(ISchoolRepository context,IStudentRepository studentContext,IUserModel userContext,IConfiguration config)
        {
            _studentContext = studentContext;
            _context = context;
            _userContext = userContext;
            _config = config;
        }
        #region School
        [Route("schools")]
        public ObjectResult GetSchools()
        {
            return new ObjectResult(_context.GetSchools());
        }
        [HttpGet]
        [Route("school/{id}")]
        public ObjectResult GetSchoolById(int id) {
            return new ObjectResult(_context.GetSchoolById(id));
        }
        [HttpPost]
        [Route("school/add")]
        public ObjectResult AddSchool([FromBody] School school) {
            var res = _context.AddSchool(school);
            return new ObjectResult(res);
        }
        [HttpPost]
        [Route("school/update")]
        public ObjectResult UpdateSchool([FromBody]  School school) {
            return new ObjectResult(_context.UpdateSchool(school));
        }
        [HttpDelete]
        [Route("school/delete/{id}")]
        public ObjectResult DeleteSchool(int id)
        {   
            var result = _context.DeleteSchool(id);
            return new ObjectResult(result);
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

        [HttpDelete]
        [Route("student/delete/{id}")]
        public ObjectResult DeleteStudent(int id)
        {
            var result = _studentContext.DeleteStudent(id);
                return new ObjectResult(result);
        }

        [HttpGet]
        [Route("student/{id}")]
        public ObjectResult GetStudentById(int id)
        {
            var result = _studentContext.GetStudentById(id);
            return new ObjectResult(result);
        }
        #endregion

        #region User
        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public bool RegisterUser([FromBody] UserModel user)
        {
            bool res = _userContext.AddUser(user);
            return res;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public ObjectResult Login([FromBody] LoginUser user)
        {
            var result = Authenticate(user);
            if (result != null)
            {
                return new ObjectResult(result);
            }
            return null;
        }

        public SendToken Authenticate(LoginUser user)
        {
            var result = _userContext.GetUser(user.Email, user.Password);
            if (result == null) return null;
            string token = generateJwtToken(result);

            return new SendToken{ 
                Token=token
            };
        }

        private string generateJwtToken(UserViewModel user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config["Jwt:Secret"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }



        #endregion
    }
}
