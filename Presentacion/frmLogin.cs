using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerContrasena_Click(object sender, EventArgs e)
        {
            if (txtContrasena.PasswordChar == '*')
            {
                txtContrasena.PasswordChar = '\0';
            }
            else
            {
                txtContrasena.PasswordChar = '*';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nombreUsuario = txtUsuario.Text.Trim();
            usuario.pass = txtContrasena.Text.Trim();
            if (LN.ConsultarAutenticacion(usuario))
            {


                frmMenuPrincipal frm = new frmMenuPrincipal();

                frm.Usuario =txtUsuario.Text.Trim();
                frm.CargarMenu();

                frm.Show();
			this.Hide();
        }else
                MessageBox.Show("usuarios y/o contraseña erroneos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
