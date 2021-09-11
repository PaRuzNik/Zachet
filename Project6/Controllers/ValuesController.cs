using Microsoft.AspNetCore.Mvc;
using Project6.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/<ValuesController>/5
        [HttpGet]
        protected ActionResult Button1_Click()
        {
            return RedirectToAction("/Home/Get");
        }
    }

}
