using BackEnd.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.AccesoDatos;

namespace BackEnd.Logica
{
    public class LogNota
    {
        public ResInsertarNota InsertarNota(ReqInsertarNota req)
        {
            ResInsertarNota res = new ResInsertarNota();
            try
            {
                //Validaciones
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Nota faltante.";
                }
                else if (req.nota.estudianteId == 0)
                {
                    res.resultado = false;
                    res.error = "ID incorrecto.";
                }
                else if (req.nota.estudianteId == null)
                {
                    res.resultado = false;
                    res.error = "ID vacio.";
                }
                else if (String.IsNullOrEmpty(req.nota.curso))
                {
                    res.resultado = false;
                    res.error = "Curso faltante.";

                }
                else if (req.nota.nota == null)
                {
                    res.resultado = false;
                    res.error = "Nota faltante.";

                }
                else if (req.nota.nota < 0)
                {
                    res.resultado = false;
                    res.error = "Imposible asignar nota negativa.";

                }
                else
                {
                    int? returnId = 0;
                    int? errorId = 0;
                    string errorDescripcion = "";

                    conexionLinqDataContext LinqReg = new conexionLinqDataContext();
                    LinqReg.InsertarNota(req.nota.estudianteId, req.nota.curso, req.nota.nota, ref returnId, ref errorId, ref errorDescripcion);
                    if (returnId <= 0 || returnId == null)
                    {
                        res.resultado = false;
                        res.error = "Estudiante no encontrado";

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
        public ResObtenerNotas ObtenerNotas(ReqObtenerNotas req)
        {

            ResObtenerNotas res = new ResObtenerNotas();
            try
            {
                if (req.estudianteId == 0)
                {
                    res.resultado = false;
                    res.error = "El estudiante no existe";
                }
                if (req.estudianteId == null)
                {
                    res.resultado = false;
                    res.error = "ID faltante.";
                }
                else
                {
                    int? errorId = 0;
                    string errorDescripcion = "";

                    conexionLinqDataContext miLinq = new conexionLinqDataContext();

                    miLinq.ObtenerNotas(req.estudianteId, ref errorId, ref errorDescripcion);
                    if (errorId == 1)
                    {
                        res.resultado = false;
                        res.error = errorDescripcion;

                    }
                    else
                    {

                        List<ObtenerNotasResult> resultSet = new List<ObtenerNotasResult>();

                        resultSet = miLinq.ObtenerNotas(req.estudianteId, ref errorId, ref errorDescripcion).ToList();

                        if (resultSet.Count == 0)
                        { 
                            errorDescripcion = "El estudiante no posee notas asignadas.";
                            res.error = errorDescripcion;
                        }
                        else
                        {


                            foreach (ObtenerNotasResult unaNotaLinq in resultSet)
                            {
                                res.ListaNotas.Add(this.FabricadeNotas(unaNotaLinq));
                            }
                            res.resultado = true;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.resultado = false;
                res.error = "Error en backend";
            }

            return res;

        }
        private Nota FabricadeNotas(ObtenerNotasResult NotaLinq)
        {
            Nota notafabricada = new Nota();
            notafabricada.nota = (int?)NotaLinq.Nota;
            notafabricada.curso = NotaLinq.Curso;

            return notafabricada;
        }
    }
}