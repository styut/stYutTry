using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication1.Models;
using System.Linq;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class jobsController : ControllerBase
    {
        static List<job> listdJobs = new List<job>()
        {
            new job { id = 1, jobField = "Softwer Developer", jobTitle = "hitek",scopeOfHours = "01/01/2000" ,region ="",requirements=[],workFromHome=true},
            new job { id = 2, jobField = "CPA", jobTitle = "Levi", scopeOfHours= "01/02/1990",region="",requirements= [],workFromHome=true},
            new job { id = 3, jobField = "psychologically", jobTitle = "Tal",scopeOfHours = "01/02/1990" ,region="",requirements= [],workFromHome=true},
            new job { id = 4, jobField = "teacher", jobTitle = "Raz", scopeOfHours= "01/02/1990",region="" ,requirements= [],workFromHome=false}
        };

        [HttpGet("GetAlljobs")]
        public ActionResult GetAllJobs()
        {
            return Ok(listdJobs);
        }



    }
}

        






