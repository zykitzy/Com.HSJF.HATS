using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Com.HSJF.HATS.Web.Controllers
{
    [Authorize(Roles = "Identity")]
    public class IdentityController : ApiController
    {
        /// <summary>
        /// Test Controller
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [Route("Login")]
        public string Get([FromBody]string username)
        {
            return "welcome " + username;
        }
    }
}
