using DragnetIntalligence.IRepository;
using DragnetIntalligence.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragnetIntalligence.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]  
    public class CourtController : ControllerBase
    {
        readonly ICourt _Court;
        public CourtController(ICourt Cou)
        {
            _Court = Cou;
        }
        [Route("api/Court/SaveCourt")]
        [HttpPost("SaveCourt")]
        public IActionResult SaveCourt([FromBody] InsertCourt court)
        {
            return Ok(_Court.InsertCourt(court));
        }

    }
}
