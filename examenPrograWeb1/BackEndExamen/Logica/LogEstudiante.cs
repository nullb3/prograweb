using BackEnd.AccesoDatos;
using BackEnd.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Logica
{
    public class LogEstudiante
    {
        public ResInsertarEstudiante InsertarEstudiante(ReqInsertarEstudiante req)
        {
            ResInsertarEstudiante res = new ResInsertarEstudiante();
            try
            {
                //Validaciones
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Campo o campos vacios.";
                }
                else if (String.IsNullOrEmpty(req.estudiante.nombre))
                {
                    res.resultado = false;
                    res.error = "Nombre u nombres faltantes.";
                }
                else if (String.IsNullOrEmpty(req.estudiante.apellidos))
                {
                    res.resultado = false;
                    res.error = "Apellidos u apellido faltante.";

                }
                else if (String.IsNullOrEmpty(req.estudiante.carrera))
                {
                    res.resultado = false;
                    res.error = "Carrera faltante.";

                }
                else
                {
                    int? returnId = 0;
                    int? errorId = 0;
                    string errorDescripcion = "";

                    conexionLinqDataContext LinqReg = new conexionLinqDataContext();
                    LinqReg.InsertarEstudiante(req.estudiante.nombre, req.estudiante.apellidos, req.estudiante.carrera, ref returnId, ref errorId, ref errorDescripcion);
                    if (returnId <= 0 || returnId == null)
                    {
                        res.resultado = false;
                        res.error = "Error en base datos";

                    }
                    else
                    {
                        // TODO BIEN
                        res.resultado = true;
                    }
                }

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