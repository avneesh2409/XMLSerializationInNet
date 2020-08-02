using Microsoft.AspNetCore.Mvc;
using MySecondWebApplication.Models;
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

        public MyTestController(ISchoolRepository context)
        {
            _context = context;
        }
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
    }
}
