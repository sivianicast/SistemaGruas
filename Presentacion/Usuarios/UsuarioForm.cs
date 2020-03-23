using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion.Usuarios
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
            CargarCombos();
            CargarDataGridUsuarios();

        }


        private void CargarCombos()
        {
            List<Perfil> lstresultado = LN.ListarPerfiles();

            this.perfilUsuarioscbo.DataSource = lstresultado;
            perfilUsuarioscbo.ValueMember = "idPerfil";
            perfilUsuarioscbo.DisplayMember = "nombrePerfil";
            perfilUsuarioscbo.Refresh();
        }




        private void CargarDataGridUsuarios()
        {
            try
            {

                //hacer un inner join porque ocupo perfil ya lo hice en data
                List<Usuario> lstusuarios = LN.ConsultaUsuario(new Usuario { nombreUsuario = string.Empty });

                this.UsuariosdataGridView.DataSource = null;
                this.UsuariosdataGridView.Refresh();
                this.UsuariosdataGridView.DataSource = lstusuarios;
                this.UsuariosdataGridView.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LimpiarUsuarios()
        {
            this.nombreUsuariotextBox.Text = string.Empty;
            this.claveUsuariotxt.Text = string.Empty;
            this.estadoUsuariotxt.Text = string.Empty;
            this.perfilUsuarioscbo.Text = String.Empty;
            this.nombreUsuariotextBox.Focus();
        }

        

        private int consultarIdUsuario() {

            int a = 0;
            List<Usuario> lstresultado = LN.ConsultaUsuario(new Usuario { nombreUsuario = string.Empty });
           // bool encontrado = false;
            foreach (Usuario item in lstresultado)
            {
                if (item.nombreUsuario==nombreUsuariotextBox.Text)
                {
                    a = item.idUsuario;
                    //           pruebatxt.Text = a.ToString();
                    
                    break;
                }
            }

            return a;
        }
        
        private bool ValidarDatosUsuario()
        {
            List<Usuario> lstresultado = LN.ConsultaUsuario(new Usuario { nombreUsuario = string.Empty });
            bool encontrado = false;
            foreach (Usuario item in lstresultado)
            {
                if (item.nombreUsuario.ToUpper().Equals(nombreUsuariotextBox.Text.ToUpper()))
                {
                    encontrado = true;
                    break;
                }
            }

            return encontrado;
        }
        

        private void AddUsuariobtn_Click(object sender, EventArgs e)
        {
            int iu,ip=0;


            try
            {
                //errorProvider1.Clear(); //limpia es errorProvider
                if (nombreUsuariotextBox.Text.Trim().Length > 0)
                {

                    if (claveUsuariotxt.Text.Trim().Length > 0)
                    {

                        if (estadoUsuariotxt.Text.Trim().Length > 0)
                        {
                            Usuario u = new Usuario();
                            u.nombreUsuario = nombreUsuariotextBox.Text.Trim();
                            u.estadoUsuario = estadoUsuariotxt.Text.Trim().Equals("Activo") ? true : false;
                            u.pass = claveUsuariotxt.Text.Trim();
                            
                            if (!ValidarDatosUsuario())
                            {
                                LN.agregarUsuario(u);
                                iu = this.consultarIdUsuario();
                                ip = Int32.Parse(perfilUsuarioscbo.SelectedValue.ToString());
                                LN.agregarUsuarioPorPerfiles(iu, ip);

                                MessageBox.Show("Usuario agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarDataGridUsuarios();
                                LimpiarUsuarios();
                            }
                            else MessageBox.Show("usuario ya existe en base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                           // errorProvider1.SetError(txtEstado, "Debe indicar Estado");
                        }
                    }
                    else
                    {
                       // errorProvider1.SetError(txtClave, "Debe indicar clave");
                    }
                }
                else
                {
                    //errorProvider1.SetError(txtUsuario, "Debe indicar usuario");
                }


                //else MessageBox.Show("Dede indicar usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuscarUsuariobtn_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario();
                u.nombreUsuario = busacarUsuariotxt.Text.Trim();

                List<Usuario> lstusuarios = LN.ConsultaUsuario(u);

                this.UsuariosdataGridView.DataSource = null;
                this.UsuariosdataGridView.Refresh();
                this.UsuariosdataGridView.DataSource = lstusuarios;
                this.UsuariosdataGridView.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombreUsuariotextBox.Text.Trim().Length > 0)
                {
                    Usuario u = new Usuario();

                    u.nombreUsuario = nombreUsuariotextBox.Text.Trim();

                    LN.Eliminar_Usuario(u);
                    MessageBox.Show("Usuario eliminado");
                    CargarDataGridUsuarios();
                    LimpiarUsuarios();
                }
                else MessageBox.Show("Debe indicar usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UsuariosdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.nombreUsuariotextBox.Text = UsuariosdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.claveUsuariotxt.Text = UsuariosdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.estadoUsuariotxt.Text = Convert.ToBoolean(UsuariosdataGridView.Rows[e.RowIndex].Cells[3].Value) ? "Activo" : "Inactivo";

        }



        private void cargarIdUsuario() {


        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.consultarIdUsuario();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private int idPerfil(int num) {
            return num;
        }

        

        private void ComboPerfilSelected(object sender, EventArgs e)
        {
            //int a;
            //a=Int32.Parse(perfilUsuarioscbo.SelectedValue.ToString());
            //idPerfil(a);
            ////pruebatxt.Text = perfilUsuarioscbo.SelectedValue.ToString();


        }

        private void UpdateUsuariobtn_Click(object sender, EventArgs e)
        {
            try {
                Usuario us = new Usuario();
                us.nombreUsuario = nombreUsuariotextBox.Text.Trim();
                us.pass = claveUsuariotxt.Text.Trim();
                us.estadoUsuario = estadoUsuariotxt.Text.Trim().Equals("Activo")? true:false;

                LN.modificarUsuario(us);
                MessageBox.Show("Usuario modificado");
                this.CargarDataGridUsuarios();
                this.LimpiarUsuarios();
            }
            catch (Exception exc) {
                exc.ToString();
            }
        }

        private void UsuariosdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
