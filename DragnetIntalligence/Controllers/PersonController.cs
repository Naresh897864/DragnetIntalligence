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
    public class PersonController : ControllerBase
    {
        readonly IPerson _person;
        public PersonController(IPerson person)
        {
            _person = person;
        }

        //[Route("api/Organization/GetOrganizationLevels")]
        [HttpGet("GetCommiteLevel")]
        public IActionResult GetCommiteLevel()
        {
            return Ok(_person.GetCommiteLevel());
        }

        [HttpGet("GetCommitteeCadre")]
        public IActionResult GetCommitteeCadre()
        {
            return Ok(_person.GetCommitteeCadre());
        }

        [HttpGet("GetDistricts")]
        public IActionResult GetDistricts()
        {
            return Ok(_person.GetDistricts());
        }

        [HttpGet("GetEducationQualification")]
        public IActionResult GetEducationQualification()
        {
            return Ok(_person.GetEducationQualification());
        }

        [HttpGet("GetMarialStatus")]
        public IActionResult GetMarialStatus()
        {
            return Ok(_person.GetMarialStatus());
        }

        [HttpGet("GetOccupation")]
        public IActionResult GetOccupation()
        {
            return Ok(_person.GetOccupation());
        }

        [HttpGet("GetOrgName")]
        public IActionResult GetOrgName()
        {
            return Ok(_person.GetOrgName());
        }

        [HttpGet("GetOrgTypes")]
        public IActionResult GetOrgTypes()
        {
            return Ok(_person.GetOrgTypes());
        }

        [HttpGet("GetPersonType")]
        public IActionResult GetPersonType()
        {
            return Ok(_person.GetPersonType());
        }

        [HttpGet("GetPoliceStations")]
        public IActionResult GetPoliceStations()
        {
            return Ok(_person.GetPoliceStations());
        }

        [HttpGet("GetReligion")]
        public IActionResult GetReligion()
        {
            return Ok(_person.GetReligion());
        }




    }
}
