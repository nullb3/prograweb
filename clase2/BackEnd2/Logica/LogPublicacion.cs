using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd2.Logica.Modelos.Request;
using BackEnd2.Modelos.Response;

namespace BackEnd2.Logica
{
    internal class LogPublicacion
    {
        public ResInsertarPublicacion insertarPublicacion(ReqInsertarPublicacion req)
        {
            ResInsertarPublicacion res = new ResInsertarPublicacion();
            try
            {
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad Request";
                }
                else if (req.publicacion.usuarioId == 0)
                {
                    res.resultado = false;
                    res.error = "Usuario incorrecto.";
                }
                else if (req.publicacion.temaId == 0)
                {
                    res.resultado = false;
                    res.error = "Tema incorrecto.";
                }
                else if (String.IsNullOrEmpty(req.publicacion.titulo))
                {
                    res.resultado = false;
                    res.error = "Título faltante.";
                }
                else if (String.IsNullOrEmpty(req.publicacion.mensaje))
                {
                    res.resultado = false;
                    res.error = "Mensaje vacío.";
                }
                else
                {
                    int? returnId = 0;
                    int? errorId = 0;
                    string errorDescripcion = "";

                    conexionLinqDataContext miLinq = new conexionLinqDataContext();
                    miLinq.SP_INGRESAR_PUBLICACION(null);
                    if (returnId <= 0)
                    {
                        res.resultado = false;
                    }
                    else
                    {
                        // OK
                        res.resultado = true;
                    }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "500 - ERROR INTERNO!!!";
            }
            return res;
        }
    }
}
