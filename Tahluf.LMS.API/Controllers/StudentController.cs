using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahluf.LMS.CORE.Data;
using Tahluf.LMS.CORE.Service;

namespace Tahluf.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStdService stdService;

        public StudentController(IStdService stdService)
        {
            this.stdService = stdService;
        }
        [HttpGet]
        public List<Student> getallstd()
        {
            return stdService.getallstd();
        }

        [HttpGet]
        [Route("getstdudentbyid/{id}")]
         public Student getstdudentbyid(int id)
        {
            return stdService.getstdudentbyid(id);

        }
        [HttpPost]

        public bool insertstd([FromBody] Student student)
        {
            return stdService.insertstd(student);

        }

        [HttpPut]

        //[ProducesResponseType(typeof(Student), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]

        public bool updatestd([FromBody]Student student)
        {
            return stdService.updatestd(student);
        }

        [HttpDelete ("delete/{id}") ]
        public bool deletestd( int id)
        {
            return stdService.deletestd(id);
        }
    }
}
