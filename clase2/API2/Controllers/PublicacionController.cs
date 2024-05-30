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
        public BackEnd2.Modelos.ResInsertarPublicacion Post(BackEnd2.Modelos.ReqInsertarPublicacion req)
        {
            return new LogPublicacion().insertarPublicacion(req);
        }
    }
}