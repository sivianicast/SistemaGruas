using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AccesoDatos
{
    public class AD
    {
        #region Atributos 

        private string cadenaconexion = Proyecto_Progra_3.Properties.Settings.Default.Conexion;
        private SqlConnection objconexion;

        #endregion

        #region Constructor

        public AD()
        {
            try
            {
                objconexion = new SqlConnection(cadenaconexion);
                this.ABRIR();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
        }

        #endregion

        #region Metodos

        #region PRIVADOS

        private void ABRIR()
        {
            if (objconexion.State == System.Data.ConnectionState.Closed)
                objconexion.Open();
        }

        private void CERRAR()
        {
            if (objconexion.State == System.Data.ConnectionState.Open)
                objconexion.Close();
        }
        #endregion

        #region PUBLICOS
        #region ejecutarSentecia
        //Metodo que ejecuta la sentencia para eliminar, modificar, agregar
        public bool ejecutarSentecia(SQLSentencia peticion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                this.ABRIR();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
        }
        #endregion




        public Usuario ConsultarAutenticacion(SQLSentencia P_Peticion)
        {
            Usuario resultado = new Usuario();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    resultado.nombreUsuario = dt.Rows[0].ItemArray[0].ToString();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return resultado;
        }

        //verificar el los intentos de acceso
        public Usuario VerificarAcceso(SQLSentencia P_Peticion)
        {
            Usuario resultado = new Usuario();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    resultado.Intento =Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return resultado;
        }

        // actulizar el intento
        public bool ActulizarIntento(SQLSentencia peticion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                this.ABRIR();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
        }



        /// <summary>
        /// Metodo para consultar los perfiles del usuario autenticado
        /// </summary>
        /// <param name="P_Peticion">Entidad Sentencia</param>
        /// <returns>Lista de Entidades de Perfiles</returns>
        public List<Perfil> ConsultarPerfiles(SQLSentencia P_Peticion)
        {
            List<Perfil> lstresultados = new List<Perfil>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();

                //ASigna los valores del QUERY a ejecutar en SQL
                cmd.Connection = objconexion; //ASigna conexion
                cmd.CommandType = System.Data.CommandType.Text; //ASigna el tipo
                cmd.CommandText = P_Peticion.Peticion; //ASigna peticion recibida

                if (P_Peticion.lstParametros.Count > 0) //Consulta si tiene parametros
                    cmd.Parameters.AddRange(P_Peticion.lstParametros.ToArray()); //Los asigna

                SqlDataAdapter objconsultar = new SqlDataAdapter(cmd);
                objconsultar.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        Perfil p = new Perfil();

                        p.idPerfil = Convert.ToInt32(item.ItemArray[0].ToString());
                        p.nombrePerfil = item.ItemArray[1].ToString();

                        lstresultados.Add(p);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }

            return lstresultados;
        }



       

        #region consultarUsuarios
        //Metodo para cosultar lista de usuarios en la base de datos
        public List<Usuario> consultarUsuarios(SQLSentencia peticion)
        {
            List<Usuario> listaResultado = new List<Usuario>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());


                SqlDataAdapter objCaptura = new SqlDataAdapter(cmd);
                objCaptura.Fill(dt);
                if (dt.Rows.Count > 0)
                    foreach (DataRow item in dt.Rows)
                    {
                        Usuario usuario = new Usuario();
                        usuario.idUsuario = (int)item.ItemArray[0];
                        usuario.nombreUsuario= item.ItemArray[1].ToString();
                        usuario.pass = item.ItemArray[2].ToString();
                        usuario.estadoUsuario = (bool)item.ItemArray[3];
                        listaResultado.Add(usuario);
                    }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
            return listaResultado;
        }
        #endregion



        public DataTable consultarUsuariosYPerfilPorEstado(SQLSentencia  peticion)
        {
          //  List<Caso> listaResultado = new List<Caso>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(peticion.Peticion, objconexion);

                da.Fill(dt);

                return dt;

             
               
                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
            return dt;

        }


        #region consultarChoferes
        //Metodo para cosultar lista de choferes en la base de datos
        public List<Chofer> consultarChoferes(SQLSentencia peticion)
        {
            List<Chofer> listaResultado = new List<Chofer>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                SqlDataAdapter objCaptura = new SqlDataAdapter(cmd);
                objCaptura.Fill(dt);
                if (dt.Rows.Count > 0)
                    foreach (DataRow item in dt.Rows)
                    {
                        Chofer chofer = new Chofer();
                        chofer.idChofer = (int)item.ItemArray[0];
                        chofer.nombreChofer = item.ItemArray[1].ToString();
                        chofer.ingresoObtenido = (int)item.ItemArray[2];
                        chofer.estadoChofer = (bool)item.ItemArray[3];
                        listaResultado.Add(chofer);
                    }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
            return listaResultado;
        }
        public List<Chofer> consultarChoferesNoRelacionados(SQLSentencia peticion)
        {
            List<Chofer> listaResultado = new List<Chofer>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                SqlDataAdapter objCaptura = new SqlDataAdapter(cmd);
                objCaptura.Fill(dt);
                if (dt.Rows.Count > 0)
                    foreach (DataRow item in dt.Rows)
                    {
                        Chofer chofer = new Chofer();
                        chofer.idChofer = (int)item.ItemArray[0];
                        chofer.nombreChofer = item.ItemArray[1].ToString();
                        listaResultado.Add(chofer);
                    }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
            return listaResultado;
        }
        #endregion

        #region consultarGruas
        //Metodo para cosultar lista de Gruas en la base de datos
        public List<Grua> consultarGruas(SQLSentencia peticion)
        {
            List<Grua> listaResultado = new List<Grua>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                SqlDataAdapter objCaptura = new SqlDataAdapter(cmd);
                objCaptura.Fill(dt);
                if (dt.Rows.Count > 0)
                    foreach (DataRow item in dt.Rows)
                    {
                        Grua grua = new Grua();
                        grua.idGrua = (int)item.ItemArray[0];
                        grua.idChofer = (int)item.ItemArray[1];
                        grua.ubicacion = item.ItemArray[2].ToString();
                        grua.estadoGrua = item.ItemArray[3].ToString();
                        listaResultado.Add(grua);
                    }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
            return listaResultado;
        }
        #endregion
        #region consultarCasos
        //Metodo para cosultar lista de Casos en la base de datos
        public List<Caso> consultarCasos(SQLSentencia peticion)
        {
            List<Caso> listaResultado = new List<Caso>();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = objconexion;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = peticion.Peticion;
                if (peticion.lstParametros.Count > 0)
                    cmd.Parameters.AddRange(peticion.lstParametros.ToArray());
                SqlDataAdapter objCaptura = new SqlDataAdapter(cmd);
                objCaptura.Fill(dt);
                if (dt.Rows.Count > 0)
                    foreach (DataRow item in dt.Rows)
                    {
                        Caso caso = new Caso();
                        caso.idCaso = (int)item.ItemArray[0];
                        caso.idGrua = (int)item.ItemArray[1];
                        caso.nombreCaso = item.ItemArray[2].ToString();
                        caso.estadoCaso = (bool)item.ItemArray[3];
                        caso.kilometraje = (double)item.ItemArray[4];
                        caso.costoCaso = (int)item.ItemArray[5];
                        listaResultado.Add(caso);
                    }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CERRAR();
            }
            return listaResultado;
        }
        #endregion
        #endregion
    }
    #endregion
}
