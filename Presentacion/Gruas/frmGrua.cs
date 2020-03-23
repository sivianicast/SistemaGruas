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
            List<string> listabox = new List<string>();
            List<Chofer> listachoferes = Logica.LN.ConsultaChoferNoRelacionados();
            foreach (Chofer item in listachoferes)
            {
                listabox.Add(item.idChofer + "  " + item.nombreChofer);
            }
            this.cbIdChofer.DataSource = listabox;
            this.cbIdChofer.Refresh();
        }
        private void frmGrua_Load(object sender, EventArgs e)
        {

        }
    }
}
