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
    public partial class FrmListaPlacas : Form
    {
        FrmAsignacionCombustible frmac = new FrmAsignacionCombustible();
        
        CapaDatos.ListarPlaca Datos_ListarPlaca = new CapaDatos.ListarPlaca();
        
        int estado;
        char acction;
        public String placa;


        public FrmListaPlacas()
        {
            InitializeComponent();
            dgListarPlaca.DataSource = Datos_ListarPlaca.MostrarListaPlacaTodo();
           

        }
        public void CargarGrilla(String buscar)
        {
        
            dgListarPlaca.DataSource = Datos_ListarPlaca.MostrarListaPlaca(buscar);
            dgListarPlaca.Columns[2].Visible = false;
        }
        public void CargarGrillaConductor(String buscar)
        {

            dgListarPlaca.DataSource = Datos_ListarPlaca.MostrarListaPlaca(buscar);
            dgListarPlaca.Columns[2].Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmListaPlacas_Load(object sender, EventArgs e)
        {

        }

        private void TxtBuscarPlaca_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla(TxtBuscarPlaca.Text);
        }

        private void dgListarPlaca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{

            //    frmac.TxtPlaca.Text = dgListarPlaca.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    this.Hide();
            //}
        }

        private void dgListarPlaca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgListarPlaca_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                 
               placa= dgListarPlaca.Rows[e.RowIndex].Cells[0].Value.ToString();
                //TxtBuscarPlaca.Text = dgListarPlaca.Rows[e.RowIndex].Cells[0].Value.ToString();
                //this.Dispose();
                frmac.TxtPlaca.Text = placa;
                frmac.Show();
                this.Hide();
                
            }

        }
    }
}
