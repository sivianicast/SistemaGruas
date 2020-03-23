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

namespace Presentacion.Choferes
{
    public partial class frmChoferP : Form
    {
        private List<Chofer> ListaChofeData { get; set; }
        public frmChoferP()
        {
            InitializeComponent();
            CargarDataGridChoferes();
            //this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgChoferes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.texboxId.Text = dgChoferes.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.texbNombre.Text = dgChoferes.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.cboxEstado.Text = dgChoferes.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void CargarDataGridChoferes()
        {
            try
            {
                List<Chofer> listaChoferes = Logica.LN.ConsultaChofer(new Chofer { nombreChofer = string.Empty });
                ListaChofeData = listaChoferes;
                DataTable dt = new DataTable();
                dt.Columns.Add("Id Chofer");
                dt.Columns.Add("Nombre Chofer");
                dt.Columns.Add("Ingreso Obtenido");
                dt.Columns.Add("Estado Chofer");
                foreach (Chofer item in listaChoferes)
                {
                    if (item.idChofer == 0) continue;
                    dt.Rows.Add
                        (
                            item.idChofer,
                            item.nombreChofer,
                            item.ingresoObtenido,
                            item.estadoChofer ? "Activo" : "Inactivo"
                        );
                }
                this.dgChoferes.DataSource = null;
                this.dgChoferes.Refresh();
                this.dgChoferes.DataSource = dt;
                this.dgChoferes.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validarCampos(2))
            {
                Chofer chofer = new Chofer();
                chofer.nombreChofer = texbNombre.Text.Trim();
                chofer.estadoChofer = cboxEstado.SelectedItem.ToString().Equals("Activo") ? true : false;
                LN.agregarChofer(chofer);
                MessageBox.Show("Chofer Agregado");
                limpiarDatos();
                CargarDataGridChoferes();
            }

        }

        private void cboxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void limpiarDatos()
        {
            this.texboxId.Text = string.Empty;
            this.texbNombre.Text = string.Empty;
            this.cboxEstado.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validarCampos(1))
            {
                Chofer chofer = new Chofer();
                chofer.idChofer = Int32.Parse(texboxId.Text.Trim());
                chofer.nombreChofer = texbNombre.Text.Trim();
                chofer.estadoChofer = cboxEstado.SelectedItem.ToString().Equals("Activo") ? true : false;
                if (validarChoferInactivo( chofer.idChofer))
                {
                    MessageBox.Show("El chofer tiene una grua asignada");
                }
                else
                {
                    LN.modificarChofer(chofer);
                    MessageBox.Show("Chofer Modificado");
                    limpiarDatos();
                    CargarDataGridChoferes();
                }
            }
        }
        private bool validarChoferInactivo ( int id)
        {
            try
            {
            bool validar = false;
                List<Chofer> listaId = new List<Chofer>();
                listaId = LN.ConsultaChoferRelacionados();
                foreach (Chofer item in listaId)
                {
                    if (item.idChofer == id)
                    {
                    validar = true;
                    }
                }
            return validar;
            }
            catch (Exception)
            {
                throw;
            }
        }
            
        private bool validarCampos(int tipo)
        {
            int cont = 0;
            if (texboxId.Text.Trim().Length <= 0 && tipo == 1)
            {
                MessageBox.Show("Id esta vacia");
                cont++;
            }
            if (texbNombre.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Nombre vacio");
                cont++;
            }
            if (cboxEstado.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Estado vacio");
                cont++;
            }
            if (cont == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void texboxId_TextChanged(object sender, EventArgs e)
        {
        }

        private void texboxId_Click(object sender, EventArgs e)
        {        
        }

        private void frmChoferP_Load(object sender, EventArgs e)
        {

        }
        private void Buscar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Id Chofer");
                dt.Columns.Add("Nombre Chofer");
                dt.Columns.Add("Ingreso Obtenido");
                dt.Columns.Add("Estado Chofer");
                foreach (Chofer item in ListaChofeData)
                    if (item.nombreChofer.ToUpper().Contains(textBoxSearch.Text.ToUpper().Trim()))
                    {
                        dt.Rows.Add
                            (
                                item.idChofer,
                                item.nombreChofer,
                                item.ingresoObtenido,
                                item.estadoChofer ? "Activo" : "Inactivo"
                            );
                    }
                this.dgChoferes.DataSource = null;
                this.dgChoferes.Refresh();
                this.dgChoferes.DataSource = dt;
                this.dgChoferes.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

