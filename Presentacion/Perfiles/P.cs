using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Logica;

namespace Presentacion.Perfiles
{
    public partial class P : Form
    {
        public P()
        {
            InitializeComponent();
            this.CargarDataGridPerfiles();
        }



        private void CargarDataGridPerfiles()
        {
            try
            {

                //hacer un inner join porque ocupo perfil ya lo hice en data
                List<Perfil> lstusuarios = LN.ConsultaPerfil(new Perfil { nombrePerfil = string.Empty });

                this.PerfilesdataGridView.DataSource = null;
                this.PerfilesdataGridView.Refresh();
                this.PerfilesdataGridView.DataSource = lstusuarios;
                this.PerfilesdataGridView.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LimpiarPerfiles()
        {
            this.nombrePerfiltxt.Text = string.Empty;
            
            this.nombrePerfiltxt.Focus();
        }



        private bool ValidarDatosPerfil()
        {
            List<Perfil> lstresultado = LN.ConsultaPerfil(new Perfil { nombrePerfil = string.Empty });
            bool encontrado = false;
            foreach (Perfil item in lstresultado)
            {
                if (item.nombrePerfil.ToUpper().Equals(nombrePerfiltxt.Text.ToUpper()))
                {
                    encontrado = true;
                    break;
                }
            }

            return encontrado;
        }



        private void PerfilesDataGridView_cellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PerfilesDataGridViewCell_click(object sender, DataGridViewCellEventArgs e)
        {
            this.nombrePerfiltxt.Text = this.PerfilesdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }

        private void AgregarPerfilesbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //errorProvider1.Clear(); //limpia es errorProvider
                if (nombrePerfiltxt.Text.Trim().Length > 0)
                {

                   
                            Perfil p = new Perfil();
                              p.nombrePerfil = nombrePerfiltxt.Text.Trim();
                            
                            if (!this.ValidarDatosPerfil())
                            {
                                LN.agregarPerfil(p);
                               
                                MessageBox.Show(" agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.CargarDataGridPerfiles();
                                LimpiarPerfiles();
                            }
                            else MessageBox.Show("perfil ya existe en base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        


                //else MessageBox.Show("Dede indicar usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarPerfilesbtn_Click(object sender, EventArgs e)
        {

        }

        private void eliminarPerfilesbtn_Click(object sender, EventArgs e)
        {

        }

        private void eliminarPerfilesbtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (nombrePerfiltxt.Text.Trim().Length > 0)
                {
                    Perfil p= new Perfil();

                    p.nombrePerfil = nombrePerfiltxt.Text.Trim();

                    LN.EliminarPerfil(p);
                    MessageBox.Show("Perfil eliminado");
                    CargarDataGridPerfiles();
                    LimpiarPerfiles();
                }
                else MessageBox.Show("Debe indicar usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarPerfilesbtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Perfil pe = new Perfil();

                pe.nombrePerfil = nombrePerfiltxt.Text.Trim();
                
                LN.modificarPerfil(pe);
                MessageBox.Show("Perfil modificado");
                this.CargarDataGridPerfiles();
                this.LimpiarPerfiles();
            }
            catch (Exception exc)
            {
                exc.ToString();
            }
        }

        private void buscarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                Perfil p = new Perfil();
                p.nombrePerfil = this.buscarPerfiltxt.Text.Trim();
               
                List<Perfil> lstusuarios = LN.ConsultaPerfil(p);

                this.PerfilesdataGridView.DataSource = null;
                this.PerfilesdataGridView.Refresh();
                this.PerfilesdataGridView.DataSource = lstusuarios;
                this.PerfilesdataGridView.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    }

