using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd2.Logica.Entidades
{
    internal class Publicacion
    {
        public string titulo { get; set; }
        public string mensaje { get; set; }
        public int temaId { get; set; }
        public int usuarioId { get; set; }
    }
}
