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

namespace Presentacion.Gruas
{
  
    public partial class frmGrua : Form
    {
        private List<Grua> ListaGruaData { get; set; }

        public frmGrua()
        {
            InitializeComponent();
            CargarDataGridGruas();
            cargarBoxChoferes();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void CargarDataGridGruas()
        {
            try
            {
                List<Grua> listaGruas = Logica.LN.ConsultaGrua(new Grua { idGrua = 0 });
                ListaGruaData = listaGruas;
                DataTable dt = new DataTable();
                dt.Columns.Add("Id Grua");
                dt.Columns.Add("Id Chofer");
                dt.Columns.Add("Ubicacion Grua");
                dt.Columns.Add("Estado Grua");
                dt.Columns.Add("Cantidad Servicios");
                foreach (Grua item in listaGruas)
                {
                    dt.Rows.Add
                        (
                        item.idGrua,
                        item.idChofer,
                        item.ubicacion,
                        item.estadoGrua,
                        item.cantidadServiciosAtendidos
                        );
                }
                this.dgGruas.DataSource = null;
                this.dgGruas.Refresh();
                this.dgGruas.DataSource = dt;
                this.dgGruas.Refresh();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void cargarBoxChoferes()
        {
            this.cbIdChofer.DataSource = null;
            this.cbIdChofer.Refresh();
            this.cbIdChofer.DataSource = ChoferesNoRelacionados();
            this.cbIdChofer.Refresh();
        }
        private void frmGrua_Load(object sender, EventArgs e)
        {

        }

        private void cbIdChofer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Grua grua = new Grua();
            grua.idChofer = Convert.ToInt32(cbIdChofer.Text.Substring(0, 1));
            grua.ubicacion = tbUbicacion.Text.Trim();
            grua.estadoGrua = cbEstadogGrua.Text.Trim();
            LN.agregarGrua(grua);
            MessageBox.Show("Grua Agregada");
            CargarDataGridGruas();
            cargarBoxChoferes();
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            limpiarformulario();
        }
        private void limpiarformulario()
        {
            tbIdGrua.Clear();
            tbUbicacion.Clear();
            cbEstadogGrua.SelectedIndex = 0;
            this.cargarBoxChoferes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Grua grua = new Grua();
            grua.idGrua = Convert.ToInt32(tbIdGrua.Text.Trim());
            grua.idChofer = Convert.ToInt32(cbIdChofer.Text.Substring(0, 1));
            grua.ubicacion = tbUbicacion.Text.Trim();
            grua.estadoGrua = cbEstadogGrua.Text.Trim();
            LN.modificarGrua(grua);
            this.limpiarformulario();
            this.CargarDataGridGruas();
            this.cargarBoxChoferes();
        }

        private void dgGruas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> listabox2 = new List<string>();
            listabox2 = ChoferesNoRelacionados();
            tbIdGrua.Text = dgGruas.Rows[e.RowIndex].Cells[0].Value.ToString();
            listabox2.Add((string)dgGruas.Rows[e.RowIndex].Cells[1].Value + "   " + nombreChofer(Convert.ToInt32(dgGruas.Rows[e.RowIndex].Cells[1].Value)));
            tbUbicacion.Text = dgGruas.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbEstadogGrua.Text = dgGruas.Rows[e.RowIndex].Cells[3].Value.ToString();
            listabox2.Reverse();
            cbIdChofer.DataSource = null;
            cbIdChofer.Refresh();
            cbIdChofer.DataSource = listabox2;
            cbIdChofer.Refresh();
        }

        private void dgGruas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buscarGrua()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Id Grua");
                dt.Columns.Add("Id Chofer");
                dt.Columns.Add("Ubicacion Grua");
                dt.Columns.Add("Estado Grua");
                dt.Columns.Add("Cantidad Servicios");
                foreach (Grua item in ListaGruaData)
                {
                    if (tbSearch.Text.Equals(item.idGrua.ToString()))
                    {
                        dt.Rows.Add
                            (
                                item.idGrua,
                                item.idChofer,
                                item.ubicacion,
                                item.estadoGrua,
                                item.cantidadServiciosAtendidos
                            );
                    }
                    dgGruas.DataSource = null;
                    dgGruas.Refresh();
                    dgGruas.DataSource = dt;
                    dgGruas.Refresh();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            buscarGrua();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private List<string> ChoferesNoRelacionados()
        {
            List<string> listabox = new List<string>();
            List<Chofer> listachoferes = Logica.LN.ConsultaChoferNoRelacionados();
            foreach (Chofer item in listachoferes)
            {
                listabox.Add(item.idChofer + "   " + item.nombreChofer);
            }
            return listabox;
        }
        private string nombreChofer(int id)
        {
            string nombre = "";
            List<Chofer> listaChoferesRelacionados = LN.ConsultaChoferRelacionados();
            foreach (Chofer item in listaChoferesRelacionados)
            {
                if (item.idChofer == id)
                {
                    nombre = item.nombreChofer;
                }
            }
            return nombre;
        }
    }
}
