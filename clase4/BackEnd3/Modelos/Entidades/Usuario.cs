using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd3.Modelos
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public string numVerificacion { get; set; }
    }
}
