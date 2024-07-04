using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Modelos
{
    public class Nota
    {
        public int? estudianteId { get; set; }
        public string curso { get; set; }
        public int? nota { get; set; }
    }
}