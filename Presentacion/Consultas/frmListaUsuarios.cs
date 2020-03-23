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
using Entidades;
using System.Data.SqlClient;


namespace Presentacion.Consultas
{
    public partial class frmListaUsuarios : Form
    {
        public frmListaUsuarios()
        {
            InitializeComponent();
            CargarComboEstados();
            
        }

        private void CargarComboEstados() {
            string nom,nom2;
            int val = 0;
            List<String> lstresultado= new List<String>() ;

            lstresultado.Add(nom="Activo");
            lstresultado.Add(nom="No Activo");
            this.estadoUsuarioscbo.DataSource = lstresultado;

            //estadoUsuarioscbo.ValueMember = "nom";
            estadoUsuarioscbo.DisplayMember = "nom";
            estadoUsuarioscbo.Refresh();


        }

         
        private void CargarDataGridUsuarios()
        {
           
        }


        private void buscarEstadoUsbtn_Click(object sender, EventArgs e)
        {
            int a = 0;

            try
            {
                
            LN.ConsultaUsuarioYPerfilPorEstado(1);
           
            this.UsuariosActivodataGridView1.DataSource = null;
            this.UsuariosActivodataGridView1.Refresh();

                if (estadoUsuarioscbo.SelectedValue.ToString() == "Activo")
                    a = 1;
                else
                    a = 0;
                this.UsuariosActivodataGridView1.DataSource = LN.ConsultaUsuarioYPerfilPorEstado(a);
            this.UsuariosActivodataGridView1.Refresh();
            //this.CargarDataGridUsPer();
            }
            catch (Exception)
            {

               throw;
            }


            //ip = Int32.Parse(perfilUsuarioscbo.SelectedValue.ToString());
        }

        private void UsuariosActivodataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }






        // private void buscarEstadoUsbtn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //         //u.nombreUsuario = busacarUsuariotxt.Text.Trim();

        //        List<Usuario> lstusuarios = LN.ConsultaUsuario(u);

        //        this.UsuariosdataGridView.DataSource = null;
        //        this.UsuariosdataGridView.Refresh();
        //        this.UsuariosdataGridView.DataSource = lstusuarios;
        //        this.UsuariosdataGridView.Refresh();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        // }
    }
    
}
