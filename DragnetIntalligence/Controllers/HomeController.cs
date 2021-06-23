using Dragnet.IRepository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dragnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class HomeController : ControllerBase
    {
        readonly IHome _home;
        public HomeController(IHome home)
        {
            _home = home;
        }

       
        [HttpGet("GetActivitiesDailyCount")]
        public IActionResult GetActivitiesDailyCount()
        {
            return Ok(_home.GetActivitiesDailyCount());
        }

        [HttpGet("GetActivitiesMonthlyCount")]
        public IActionResult GetActivitiesMonthlyCount()
        {
            return Ok(_home.GetActivitiesMonthlyCount());
        }

        [HttpGet("GetMessagesCount")]
        public IActionResult GetMessagesCount()
        {
            return Ok(_home.GetMessagesCount());
        }
    }
}
