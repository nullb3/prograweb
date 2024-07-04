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
    public class EstudianteController : ApiController
    {
        // POST api/values
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/Estudiante/InsertarEstudiante")]
        public ResInsertarEstudiante Register(ReqInsertarEstudiante req)
        {
            return new LogEstudiante().InsertarEstudiante(req);
        }
    }
}