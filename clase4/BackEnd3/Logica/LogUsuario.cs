using BackEnd3.AccesoDatos;
using BackEnd3.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd3.Logica
{
    public class LogUsuario
    {
        public ResAgregarUsuario AgregarUsuario(ReqAgregarUsuario req)
        {
            ResAgregarUsuario res = new ResAgregarUsuario();
            try
            {
                //Validaciones
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad Request";
                }
                else if (String.IsNullOrEmpty(req.usuario.nombre))
                {
                    res.resultado = false;
                    res.error = "Nombre u nombres faltantes.";
                }
                else if (String.IsNullOrEmpty(req.usuario.apellidos))
                {
                    res.resultado = false;
                    res.error = "Apellidos u apellido faltante.";

                }
                else if (String.IsNullOrEmpty(req.usuario.correo))
                {
                    res.resultado = false;
                    res.error = "Correo electronico faltante.";

                }
                else if (String.IsNullOrEmpty(req.usuario.contrasena))
                {
                    res.resultado = false;
                    res.error = "Contrasena faltante.";

                }
                else if (String.IsNullOrEmpty(req.usuario.numVerificacion))
                {
                    res.resultado = false;
                    res.error = "Numero de verificacion incorrecto.";

                }
                else
                {
                    int? usuarioId = 0;
                    int? estado = 0;
                    int? returnId = 0;
                    int? errorId = 0;
                    string errorDescripcion = "";
                    string nombre = "";
                    string apellidos = "";

                    conexionLinqDataContext LinqReg = new conexionLinqDataContext();
                    LinqReg.SP_INGRESAR_USUARIO(req.usuario.nombre, req.usuario.apellidos, req.usuario.correo, req.usuario.contrasena, req.usuario.numVerificacion, ref returnId, ref errorId, ref errorDescripcion);
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
        public ResLogin loginUsuario(ReqLogin req)
        {
            ResLogin res = new ResLogin();
            try
            {
                //Validaciones
                if (req == null)
                {
                    res.resultado = false;
                    res.error = "Bad Request";
                }
                else if (String.IsNullOrEmpty(req.correo))
                {
                    res.resultado = false;
                    res.error = "Correo electronico faltante.";

                }
                else if (String.IsNullOrEmpty(req.contrasena))
                {
                    res.resultado = false;
                    res.error = "Contrasena faltante.";

                }
                else
                {
                    int? usuarioId = 0;
                    int? estado = 0;
                    string nombre = "";
                    string apellidos = "";

                    conexionLinqDataContext LinqLog = new conexionLinqDataContext();
                    LinqLog.sp_Login(req.correo, req.contrasena, ref usuarioId, ref estado, ref nombre, ref apellidos);
                    if (usuarioId <= 0 || usuarioId == null){
                        res.resultado = false;
                        res.error = "Usuario o contrasena incorrectos";
                    }
                    else{
                        // TODO BIEN
                        res.resultado = true;
                        res.nombre = nombre;
                        res.apellidos = apellidos;
                    }
                }

            }
            catch (Exception ex){
                res.resultado = false;
                res.error = "500 - ERROR INTERNO!!!";

            }

            return res;

        }
    }
}