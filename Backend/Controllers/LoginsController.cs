using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        [HttpPut("GetLogin")]
        public IActionResult GetLogin()
        {
            if (ModelState.IsValid)
            {
            }
            return NotFound("No Data Found");
        }
    }
}
