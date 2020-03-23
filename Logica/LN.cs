using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class LN
    {

        #region metodo Autenticacion
        /// <summary>
        /// Metodo para verificar autenticacion de usuario en sistema
        /// </summary>
        /// <param name="P_Usuario">Entidad de tipo usuario</param>
        /// <returns>True = Correcto | False = Incorrecto</returns>
        public static bool ConsultarAutenticacion(Usuario P_Usuario)
        {
            try
            {
                List<SqlParameter> lstparametros = new List<SqlParameter>();
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.Peticion = @"EXEC PA_ConsultarAutenticacion @Usuario, @Clave";

                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.ParameterName = "@Usuario";
                paramUsuario.Value = P_Usuario.nombreUsuario;
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter paramClave = new SqlParameter();
                paramClave.ParameterName = "@Clave";
                paramClave.Value = P_Usuario.pass;
                paramClave.SqlDbType = System.Data.SqlDbType.VarChar;

                sentencia.lstParametros.Add(paramUsuario);
                sentencia.lstParametros.Add(paramClave);

                AD objacceso = new AD();
                Usuario usuario = objacceso.ConsultarAutenticacion(sentencia);

                if (usuario.nombreUsuario != null)
                    if (usuario.nombreUsuario.Length > 0)
                        return true;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //verificar Intento de acceso
        public static int VerificarIntento(Usuario P_Usuario)
        {
            try
            {
                List<SqlParameter> lstparametros = new List<SqlParameter>();
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.Peticion = @"EXEC Pa_VerificarIntento @Usuario";

                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.ParameterName = "@Usuario";
                paramUsuario.Value = P_Usuario.nombreUsuario;
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;


                sentencia.lstParametros.Add(paramUsuario);

                AD objacceso = new AD();
                Usuario usuario = objacceso.VerificarAcceso(sentencia);

                if (usuario.Intento == 2)
                {
                    return usuario.Intento;
                }
                else
                {
                    return 0;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        //actulizar
        public static bool ActulizarUsuario(Usuario P_Usuario)
        {
            try
            {
                List<SqlParameter> lstparametros = new List<SqlParameter>();
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.Peticion = @"EXEC PA_ActIntento @Usuario";

                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.ParameterName = "@Usuario";
                paramUsuario.Value = P_Usuario.nombreUsuario;
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                sentencia.lstParametros.Add(paramUsuario);


                AD objacceso = new AD();

                return objacceso.ejecutarSentecia(sentencia); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //reset intento

        public static bool RestIntento(Usuario P_Usuario)
        {
            try
            {
                List<SqlParameter> lstparametros = new List<SqlParameter>();
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.Peticion = @"EXEC Pa_ResetIntento @Usuario";

                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.ParameterName = "@Usuario";
                paramUsuario.Value = P_Usuario.nombreUsuario;
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                sentencia.lstParametros.Add(paramUsuario);


                AD objacceso = new AD();

                return objacceso.ejecutarSentecia(sentencia); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #region Autenticacion de Perfiles
        /// <summary>
        /// Metodo para obtener perfiles del usuario recibido
        /// </summary>
        /// <param name="P_Usuarios">Entidad de tipo usuario</param>
        /// <returns>Lista de perfiles asociadas al usuario</returns>
        public static List<Perfil> ConsultarPerfilesUsuario(Usuario P_Usuarios)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.Peticion = @"EXEC PA_ConsultarPerfilesUsuario @idusuario";

                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.Value = P_Usuarios.idUsuario;
                paramUsuario.ParameterName = "@idusuario";
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                sentencia.lstParametros.Add(paramUsuario);

                AD objacceso = new AD();
                return objacceso.ConsultarPerfiles(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        public static int VerificarAcceso(Usuario P_Usuario)
        {
            try
            {
                List<SqlParameter> lstparametros = new List<SqlParameter>();
                SQLSentencia sentencia = new SQLSentencia();

                sentencia.Peticion = @"EXEC PA_ConsultarPerfilesUsuario @idusuario";

                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.ParameterName = "@idusuario";
                paramUsuario.Value = P_Usuario.nombreUsuario;
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;


                sentencia.lstParametros.Add(paramUsuario);

                AD objacceso = new AD();
                Usuario usuario = objacceso.VerificarAcceso(sentencia);


                return usuario.Intento;



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        #region Perfiles

        public static List<Perfil> ListarPerfiles()
        {

            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"SELECT idPerfil ,nombrePerfil FROM Perfil";

                AD objacceso = new AD();
                return objacceso.ConsultarPerfiles(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<Perfil> ConsultaPerfil(Perfil p)
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Perfiles_Consultar '" + p.nombrePerfil + "'";

                AD objacceso = new AD();
                return objacceso.ConsultarPerfiles(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        public static bool agregarPerfil(Perfil p)
        {
            try
            {

                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Perfiles_Insertar '" + p.nombrePerfil + "'";

                AD objacceso = new AD();
                return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD




                //SQLSentencia sentencia = new SQLSentencia();

                //sentencia.Peticion = @"EXEC PA_Usuarios_Insertar @nomUsuario,@pass,@estado";

                //SqlParameter paramUsuario = new SqlParameter();
                //paramUsuario.Value = usuario.nombreUsuario;
                //paramUsuario.ParameterName = "@nomUsuario";
                //paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                //paramUsuario.Value =usuario.pass;
                //paramUsuario.ParameterName = "@pass";
                //paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                //paramUsuario.Value = usuario.estadoUsuario;
                //paramUsuario.ParameterName = "@estado";
                //paramUsuario.SqlDbType = System.Data.SqlDbType.Bit;



                ////sentencia.lstParametros.Add(paramUsuario);
                //AD objacceso = new AD();
                //return objacceso.ejecutarSentecia(sentencia); //Ejecucion de metodo en AD


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static bool EliminarPerfil(Perfil per)
        {
            try
            {
                //Construccion de instruccion de peticion a ejecutar - ELIMINAR
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Perfiles_Eliminar '" + per.nombrePerfil + "'";

                AD objacceso = new AD();
                return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool modificarPerfil(Perfil p)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Perfiles_Modificar '" + p.nombrePerfil + "'";
                AD acceso = new AD();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }







        #endregion



        #region UsuariosPorPerfiles


        public static bool agregarUsuarioPorPerfiles(int idUsuario, int idPerfil)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_UsuariosPorPerfiles_Insertar '" + idUsuario + "','" + idPerfil + "'";

                AD objacceso = new AD();
                return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void pas2()
        {

        }


        public static DataTable ConsultaUsuarioYPerfilPorEstado(int u)
        {

            try
            {
                //Construccion de instruccion de peticion a ejecutar - ELIMINAR
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_ConsultarUsuarioporEstado '" + u + "'";

                AD objacceso = new AD();
                //return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD
                return objacceso.consultarUsuariosYPerfilPorEstado(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }







        #endregion




        #region Metodos usuario




        public static bool Eliminar_Usuario(Usuario usuarios)
        {
            try
            {
                //Construccion de instruccion de peticion a ejecutar - ELIMINAR
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Usuarios_Eliminar '" + usuarios.nombreUsuario + "'";

                AD objacceso = new AD();
                return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public static bool agregarUsuario(Usuario usuario)
        {
            try
            {

                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Usuarios_Insertar '" + usuario.nombreUsuario + "','" + usuario.pass + "','" + usuario.estadoUsuario + "'";

                AD objacceso = new AD();
                return objacceso.ejecutarSentecia(peticion); //Ejecucion de metodo en AD




                //SQLSentencia sentencia = new SQLSentencia();

                //sentencia.Peticion = @"EXEC PA_Usuarios_Insertar @nomUsuario,@pass,@estado";

                //SqlParameter paramUsuario = new SqlParameter();
                //paramUsuario.Value = usuario.nombreUsuario;
                //paramUsuario.ParameterName = "@nomUsuario";
                //paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                //paramUsuario.Value =usuario.pass;
                //paramUsuario.ParameterName = "@pass";
                //paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                //paramUsuario.Value = usuario.estadoUsuario;
                //paramUsuario.ParameterName = "@estado";
                //paramUsuario.SqlDbType = System.Data.SqlDbType.Bit;



                ////sentencia.lstParametros.Add(paramUsuario);
                //AD objacceso = new AD();
                //return objacceso.ejecutarSentecia(sentencia); //Ejecucion de metodo en AD


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static bool modificarUsuario(Usuario u)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Usuarios_Modificar '" + u.nombreUsuario + "','" + u.pass + "','" + u.estadoUsuario + "'";
                AD acceso = new AD();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static List<Usuario> ConsultaUsuarioId(string u)
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Usuarios_ConsultarId '" + u + "'";

                AD objacceso = new AD();
                return objacceso.consultarUsuarios(peticion);


            }

            catch (Exception e)
            {
                throw e;
            }


        }





        public static List<Usuario> ConsultaUsuario(Usuario usuario)
        {

            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Usuarios_Consultar '" + usuario.nombreUsuario + "'";

                AD objacceso = new AD();
                return objacceso.consultarUsuarios(peticion);
            }
            catch (Exception e)
            {
                throw e;
            }
        }




        #endregion
        #region Metodos Chofer

        public static bool agregarChofer(Chofer chofer)
        {
            try
            {
                //List<SqlParameter> lstparametros = new List<SqlParameter>();
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC PA_Choferes_Add @chofer, @estado";
                SqlParameter paramChofer = new SqlParameter();
                paramChofer.Value = chofer.nombreChofer;
                paramChofer.ParameterName = "@chofer";
                paramChofer.SqlDbType = System.Data.SqlDbType.VarChar;
                SqlParameter paramEstado = new SqlParameter();
                paramEstado.Value = chofer.estadoChofer;
                paramEstado.ParameterName = "@estado";
                paramEstado.SqlDbType = System.Data.SqlDbType.Bit;
                sentencia.lstParametros.Add(paramChofer);
                sentencia.lstParametros.Add(paramEstado);
                AD acceso = new AD();
                return acceso.ejecutarSentecia(sentencia);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static bool modificarChofer(Chofer chofer)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"PA_Chofer_Update @id, @chofer, @estado";
                SqlParameter paramChofer = new SqlParameter();
                paramChofer.Value = chofer.nombreChofer;
                paramChofer.ParameterName = "@chofer";
                paramChofer.SqlDbType = System.Data.SqlDbType.VarChar;
                SqlParameter paramEstado = new SqlParameter();
                paramEstado.Value = chofer.estadoChofer;
                paramEstado.ParameterName = "@estado";
                paramEstado.SqlDbType = System.Data.SqlDbType.Bit;
                SqlParameter paramId = new SqlParameter();
                paramId.Value = chofer.idChofer;
                paramId.ParameterName = "@id";
                paramId.SqlDbType = System.Data.SqlDbType.Int;
                sentencia.lstParametros.Add(paramChofer);
                sentencia.lstParametros.Add(paramEstado);
                sentencia.lstParametros.Add(paramId);
                AD acceso = new AD();
                return acceso.ejecutarSentecia(sentencia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Chofer> ConsultaChofer(Chofer chofer)
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC PA_Choferes_Consultar @chofer";
                SqlParameter paramUsuario = new SqlParameter();
                paramUsuario.Value = chofer.nombreChofer;
                paramUsuario.ParameterName = "@chofer";
                paramUsuario.SqlDbType = System.Data.SqlDbType.VarChar;
                sentencia.lstParametros.Add(paramUsuario);
                AD acceso = new AD();
                return acceso.consultarChoferes(sentencia);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Chofer> ConsultaChoferNoRelacionados()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC PA_Choferes_Consuta_No_Relacionado";
                AD acceso = new AD();
                return acceso.consultarChoferesNoRelacionados(sentencia);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Chofer> ConsultaChoferRelacionados()
        {
            try
            {
                SQLSentencia sentencia = new SQLSentencia();
                sentencia.Peticion = @"EXEC PA_Choferes_Relacionados";
                AD acceso = new AD();
                return acceso.consultarChoferesNoRelacionados(sentencia);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region Metodos grua

        public static bool agregarGrua(Grua grua)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Gruas_Add @idChofer, @ubicacion, @estado";
                SqlParameter paramIdChofer = new SqlParameter();
                paramIdChofer.Value = grua.idChofer;
                paramIdChofer.ParameterName = "@idChofer";
                paramIdChofer.SqlDbType = System.Data.SqlDbType.Int;
                SqlParameter paramUbicacion = new SqlParameter();
                paramUbicacion.Value = grua.ubicacion;
                paramUbicacion.ParameterName = "@ubicacion";
                paramUbicacion.SqlDbType = System.Data.SqlDbType.VarChar;
                SqlParameter paramEstado = new SqlParameter();
                paramEstado.Value = grua.estadoGrua;
                paramEstado.ParameterName = "@estado";
                paramEstado.SqlDbType = System.Data.SqlDbType.VarChar;
                peticion.lstParametros.Add(paramIdChofer);
                peticion.lstParametros.Add(paramUbicacion);
                peticion.lstParametros.Add(paramEstado);
                AD acceso = new AD();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool modificarGrua(Grua grua)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Grua_Update @idGrua, @idChofer, @ubicacion, @estado";
                SqlParameter paramIdGrua = new SqlParameter();
                paramIdGrua.Value = grua.idGrua;
                paramIdGrua.ParameterName = "@idGrua";
                paramIdGrua.SqlDbType = System.Data.SqlDbType.Int;
                SqlParameter paramIdChofer = new SqlParameter();
                paramIdChofer.Value = grua.idChofer;
                paramIdChofer.ParameterName = "@idChofer";
                paramIdChofer.SqlDbType = System.Data.SqlDbType.Int;
                SqlParameter paramUbicacion = new SqlParameter();
                paramUbicacion.Value = grua.ubicacion;
                paramUbicacion.ParameterName = "@ubicacion";
                paramUbicacion.SqlDbType = System.Data.SqlDbType.VarChar;
                SqlParameter paramEstado = new SqlParameter();
                paramEstado.Value = grua.estadoGrua;
                paramEstado.ParameterName = "@estado";
                paramEstado.SqlDbType = System.Data.SqlDbType.VarChar;
                peticion.lstParametros.Add(paramIdGrua);
                peticion.lstParametros.Add(paramIdChofer);
                peticion.lstParametros.Add(paramUbicacion);
                peticion.lstParametros.Add(paramEstado);
                AD acceso = new AD();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Grua> ConsultaGrua(Grua grua)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = @"EXEC PA_Gruas_Consulta @id";
                SqlParameter paramGrua = new SqlParameter();
                paramGrua.Value = grua.idGrua;
                paramGrua.ParameterName = "@id";
                paramGrua.SqlDbType = System.Data.SqlDbType.Int;
                peticion.lstParametros.Add(paramGrua);
                AD acceso = new AD();
                return acceso.consultarGruas(peticion);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region Metodos Caso

        public static bool agregarCaso(Caso caso)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = "PA AGREGAR GRUA";
                AD acceso = new AD();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static bool modificarCaso(Caso caso)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = "PA MODIFICAR GRUA";
                AD acceso = new AD();
                return acceso.ejecutarSentecia(peticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Caso> ConsultaCaso(Caso caso)
        {
            try
            {
                SQLSentencia peticion = new SQLSentencia();
                peticion.Peticion = "PA CONSULTA GRUA";
                AD acceso = new AD();
                return acceso.consultarCasos(peticion);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
