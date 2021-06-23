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
    public class OrganizationController : ControllerBase
    {
        readonly IOrganization _organization;
        public OrganizationController(IOrganization org)
        {
            _organization = org;
        }


        /*   public IActionResult Index()
           {
               return View();
           }*/

        [Route("api/Organization/GetOrganizationLevels")]
        [HttpGet("GetOrganizationLevels")]
        public IActionResult GetOrganizationLevels()
        {
            return Ok(_organization.GetOrganizationLevels());
        }

        [Route("api/Organization/GetOrgTypes")]
        [HttpGet("GetOrgTypes")]
        public IActionResult GetOrgTypes()
        {
            return Ok(_organization.GetOrgtypes());
        }

        [Route("api/Organization/GetDistricts")]
        [HttpGet("GetDistricts")]
        public IActionResult GetDistricts()
        {
            return Ok(_organization.GetDistricts());
        }

        [Route("api/Organization/GetFronatalOrg")]
        [HttpGet("GetFronatalOrg")]
        public IActionResult GetFronatalOrg()
        {
            return Ok(_organization.GetFronatalOrg()); 
        }

        [Route("api/Organization/GetOrgStatus")]
        [HttpGet("GetOrgStatus")]
        public IActionResult GetOrgStatus()
        {
            return Ok(_organization.GetOrgStatus()); 
        }
    }
}
