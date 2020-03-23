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
using Presentacion.Catalogo;
using Presentacion.Usuarios;
using Presentacion.Perfiles;
using Presentacion.Consultas;
using Presentacion.Choferes;
using Presentacion.Gruas;
using Presentacion.Procesos;

namespace Presentacion
{
    public partial class frmMenuPrincipal : Form
    {

        #region Propiedades

        public string Usuario { get; set; }

        #endregion


        #region Constructor

        public frmMenuPrincipal()
        {
            InitializeComponent();
            CenterToScreen();
        }

        #endregion


        #region Metodos publicos

        public void CargarMenu()
        {
            tsslUsuarioConectado.Text = Usuario;
            int op1 = 0;


            int AccesoMenu = LN.VerificarAcceso(new Usuario { nombreUsuario = Usuario });

            consultasToolStripMenuItem.Visible = true;
            catalogosToolStripMenuItem.Visible = true;
            sistemaToolStripMenuItem.Visible = true;
            switch (AccesoMenu)
            {
                case 1:
                    {
                        consultasToolStripMenuItem.Visible = true;
                        catalogosToolStripMenuItem.Visible = true;
                        sistemaToolStripMenuItem.Visible = true;
                        cerrarSistemaToolStripMenuItem1.Visible = true;
                    }
                    break;
                case 2:
                    {
                        consultasToolStripMenuItem.Visible = true;
                        catalogosToolStripMenuItem.Visible = true;
                        sistemaToolStripMenuItem.Visible = true;
                        cerrarSistemaToolStripMenuItem.Visible = false;
                        perfilToolStripMenuItem.Visible = false;
                        choferesToolStripMenuItem1.Visible = false;
                        gruasToolStripMenuItem1.Visible = false;
                        cerrarSistemaToolStripMenuItem1.Visible = true;


                    }
                    break;
                case 5:
                    {
                        consultasToolStripMenuItem.Visible = true;
                        catalogosToolStripMenuItem.Visible = true;
                        sistemaToolStripMenuItem.Visible = true;
                    }

                    break;

            }

        }

        #endregion









        private void Principal_Load(object sender, EventArgs e)
        {
			

        }

		private void cerrarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
		{
            UsuarioForm frm = new UsuarioForm();
            frm.MdiParent = this;
            frm.Show();

            // llama a usuario
        }

		private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void choferesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmChoferes frm = new frmChoferes();
			frm.MdiParent = this;
			frm.Show();
		}

		private void gruasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmGruas frm = new frmGruas();
			frm.MdiParent = this;
			frm.Show();
		}

		private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmUsuarios frm = new frmUsuarios();
			frm.MdiParent = this;
			frm.Show();
		}

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaUsuarios frm = new frmListaUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            P frm = new P();
            frm.MdiParent = this;
            frm.Show();
        }

        private void choferesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChoferP frm = new frmChoferP();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gruasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGrua frm = new frmGrua();
            frm.MdiParent = this;
            frm.Show();
        }

        private void añadirCasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroCasos frm = new frmRegistroCasos();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
