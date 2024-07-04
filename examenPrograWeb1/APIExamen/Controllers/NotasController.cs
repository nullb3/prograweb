using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using BackEnd.Logica;
using BackEnd.Modelos;

namespace APIExamen.Controllers
{
    public class NotasController : ApiController
    {
        // POST api/values
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Notas/InsertarNota")]
        public ResInsertarNota Register(ReqInsertarNota req)
        {
            return new LogNota().InsertarNota(req);
        }

        // POST api/values
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Notas/ObtenerNotas")]
        public ResObtenerNotas Register(ReqObtenerNotas req)
        {
            return new LogNota().ObtenerNotas(req);
        }
    }
}