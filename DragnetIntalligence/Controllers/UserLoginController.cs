
using Dragnet.IRepository;
using Dragnet.Models;
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
    public class UserLoginController : ControllerBase
    {
        readonly IUserLogin _userlogin;
        public UserLoginController(IUserLogin userLogin)
        {
            _userlogin = userLogin;
        }


      //  [Route("~/api/Login")]
      //  [EnableCors("AllowOrigin")]
        public IActionResult UserLogin([FromBody] UserLogin userLogin)
        {


            if (userLogin.UserId != null & userLogin.Password != null)
            {

               return Ok( _userlogin.Login(userLogin.UserId, userLogin.Password));
            }
            else
            {
                return BadRequest();
            }
        }

      


    }
}
