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
namespace Presentacion.Procesos
{
	public partial class frmRegistroCasos : Form
	{
		public frmRegistroCasos()
		{
			InitializeComponent();
            CargarComboEstadosGruas();
            CargarComboCasosAtendidos();

        }


        private void CargarComboEstadosGruas()
        {
            string nom, nom2,nom3;
            int val = 0;
            List<String> lstresultado = new List<String>();

            lstresultado.Add(nom = "");

            lstresultado.Add(nom = "En Servicio");
            lstresultado.Add(nom = "En Espera");
            lstresultado.Add(nom = "Inactivo");
            this.EstadoGruascbo.DataSource = lstresultado;

            //estadoUsuarioscbo.ValueMember = "nom";
            EstadoGruascbo.DisplayMember = "nom";
            EstadoGruascbo.Refresh();


        }

        private void CargarComboCasosAtendidos()
        {
            List<int> lstresultado = new List<int>();
            int i = 0;
            while(i<10)
            {

                lstresultado.Add(i);
                i++;
            }
                this.cabtServicioscbo.DataSource = lstresultado;

            //EstadoGruascbo.ValueMember = i.ToString();
            EstadoGruascbo.DisplayMember = i.ToString();
            EstadoGruascbo.Refresh();


        }


        private void buscarNumeroServiciosbtn_Click(object sender, EventArgs e)
        {
            int a = 0;
            string b;
            try
            {
                a = Int32.Parse(cabtServicioscbo.SelectedValue.ToString());
                // b = EstadoGruascbo.SelectedValue.ToString();
                b = "En Espera";
              //  if (b) {

                    List<Grua> lstgruas = LN.ConsultaGruaPorEstadoYServicios(b, a);
                    this.GruasCasodgv.DataSource = null;
                    this.GruasCasodgv.Refresh();
                    this.GruasCasodgv.DataSource = lstgruas;
                    this.GruasCasodgv.Refresh();
                //}    //this.CargarDataGridUsPer();
            }
            catch (Exception)
            {

                throw;
            }


        }

        private int calcularCosto(int cost) {
            float n,m;
            int resultado;
            n = float.Parse(kilometrajeCasotxt.Text.Trim());
          m= n * cost;
            return resultado = Convert.ToInt32(m);
        }


        private int calcularIngresoChofer(int totalCaso)
        {
            int resultado = (totalCaso /100)*40;
             return resultado;
           
        }




        private bool verificaEstado() {

            if(String.Equals(this.EstadoGruascbo.Text.Trim(),"En Espera"))
           // if (String.Equals(estadoGruaCaso.Text.Trim(),"En Espera"))
                return true;
            else
                return false;


        }



        private void GruasCasodgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            this.gruaCasotxt.Text = GruasCasodgv.Rows[e.RowIndex].Cells[0].Value.ToString();
           
        }

        private void agregarCasobtn_Click(object sender, EventArgs e)
        {
            
            int cost=2500;
            int ing = 0;
            try {
                Caso c = new Caso();
                c.idGrua = Int32.Parse(gruaCasotxt.Text);
                c.ubicacionCaso = ubicacionCasotxt.Text.Trim();
                c.kilometraje = float.Parse(kilometrajeCasotxt.Text.Trim());
                c.costoPorKilometraje = cost;
                c.costoCaso = this.calcularCosto(cost);

                int id = Int32.Parse(gruaCasotxt.Text);

                //area de grua
                string u;
                string esta;
                u = ubicacionCasotxt.Text.Trim();
                esta = "En Servicio";
                LN.modificarGruaPorid(id, u, esta);

                //areaGrua
                LN.actualizarCasosAtendidos(id);

                //area chofer
                ing= this.calcularCosto(cost);
                int ingreso= this.calcularIngresoChofer(ing);
                LN.modificarIngresoChoferCaso(id, ingreso);
                LN.agregarCaso(c);
                LN.AgregoCasoTrans(id, u, esta, ingreso,c);
                MessageBox.Show("Caso agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
            catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }
        }

        private void modificarCasobtn_Click(object sender, EventArgs e)
        {

        }
    }
}
