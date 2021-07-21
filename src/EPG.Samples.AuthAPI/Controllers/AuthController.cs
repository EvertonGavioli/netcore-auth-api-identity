using EPG.Samples.AuthAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPG.Samples.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("new-account")]
        public IActionResult NovaConta([FromBody]UsuarioCadastro usuarioCadastro)
        {
            return Ok();
        }
    }
}
