using pruebaDeveloper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace pruebaDeveloper.Controllers
{
    public class UsersApiController : ApiController
    {
        [HttpGet]
        [Route("ListadoDeUsuarios")]
        public IHttpActionResult ListadoDeUsuarios()
        { //se coloca lo que se necesite retornar

            Users objuser = new Users();
            var Listado = objuser.ListadoDeUsuarios();

            return Ok(Listado);
        }
    }
}
