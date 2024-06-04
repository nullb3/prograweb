using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using BackEnd2.Logica;
using BackEnd2.Modelos;

namespace API.Controllers
{
    public class PublicacionController : ApiController
    {
        // POST api/values
        public ResInsertarPublicacion Post(ReqInsertarPublicacion req)
        {
            [System.Web.Http.HttpPost]
            [System.Web.Http.Route("api/publicacion/ingresarpublicacion")]
            
            return new LogPublicacion().insertarPublicacion(req);
        }
    }
}