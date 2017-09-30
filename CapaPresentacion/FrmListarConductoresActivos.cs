using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CapaNegocios;


namespace CapaPresentacion
{
    public partial class FrmListarConductoresActivos : Form
    {
        FrmAsignacionCombustible frmac = new FrmAsignacionCombustible();

        CapaDatos.ListarConductoreActivos Datos_ListarConductoreActivos = new CapaDatos.ListarConductoreActivos();
        int estado;
        char acction;
        public String apellido, nombre;


        public FrmListarConductoresActivos()
        {
            InitializeComponent();
            dgListarConductor.DataSource = Datos_ListarConductoreActivos.MostrarListaConductoresTodo();
            dgListarConductor.Columns[0].Visible = false;
        }
        public void CargarGrilla(String buscar)
        {

            dgListarConductor.DataSource = Datos_ListarConductoreActivos.MostrarListaConductores(buscar);
            dgListarConductor.Columns[0].Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TxtBuscarConductor_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla(TxtBuscarConductor.Text);
        }

        private void dgListarConductor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                apellido = dgListarConductor.Rows[e.RowIndex].Cells[0].Value.ToString();
                //TxtBuscarPlaca.Text = dgListarPlaca.Rows[e.RowIndex].Cells[0].Value.ToString();
                //this.Dispose();
                frmac.TxtPlaca.Text = apellido;
                frmac.Show();
                this.Hide();

            }
        }

        private void FrmListarConductoresActivos_Load(object sender, EventArgs e)
        {

        }
    }
}
