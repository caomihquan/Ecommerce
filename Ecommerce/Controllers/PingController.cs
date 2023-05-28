using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{ 
    public class PingController : ApplicationBaseController
    {
        [Route("ping")]
        [HttpGet]
        public IActionResult Ping()
        {
            return Ok(new { msg = "pong" });
        }

        [Route("ping-anonymous")]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult PingAnonymous()
        {
            return Ok(new { msg = "pong" });
        }
    }
}
