using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EPG.Samples.AuthAPI.Controllers
{
    [Route("api/[controller]")]
    public class RolesController : MainController
    {
        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado");

        [HttpGet]
        [Route("admin")]
        [Authorize(Roles = "admin")]
        public string Administrator() => "Administrador";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "admin,manager")]
        public string Manager() => "Gerente";
    }
}
