using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using BackEnd3.Logica;
using BackEnd3.Modelos;

namespace API3.Controllers
{
    public class UsuarioController : ApiController
    {
        // POST api/values
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Usuario/ingresarUsuario")]
        public ResAgregarUsuario Register(ReqAgregarUsuario req)
        {
            return new LogUsuario().AgregarUsuario(req);
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Usuario/login")]
        public ResLogin Login(ReqLogin req2)
        {
            return new LogUsuario().loginUsuario(req2);
        }
    }
}