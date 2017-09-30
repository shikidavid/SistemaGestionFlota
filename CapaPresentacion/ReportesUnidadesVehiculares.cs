using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ReportesUnidadesVehiculares : MetroFramework.Forms.MetroForm
    {
        CapaDatos.TipoVehicular Datos_TipoVehicular = new CapaDatos.TipoVehicular();
        CapaDatos.SubTipoVehicular Datos_SubTipoVehicular = new CapaDatos.SubTipoVehicular();
        CapaDatos.EstadoVehicular Datos_EstadoVehicular = new CapaDatos.EstadoVehicular();

        public ReportesUnidadesVehiculares()
        {
            InitializeComponent();
        }
        public void iniciar()
        {
            CboSubTipoVehicular.Text = "";
            CboTipoVehicular.Text = "";
            CboEstadoVehicular.Text = "";
            checkBoxTodos.Checked = false;
        }

        //private void BtnSalir_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //}

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ReportesUnidadesVehiculares_Load(object sender, EventArgs e)
        {
            CboEstadoVehicular.DataSource = Datos_EstadoVehicular.MostrarEstadoVehicular();
            CboEstadoVehicular.DisplayMember = "EstadoVehicular";
            CboEstadoVehicular.ValueMember = "IdEstadoVehicular";

            CboSubTipoVehicular.DataSource = Datos_SubTipoVehicular.MostrarSubTipoVehicular();
            CboSubTipoVehicular.DisplayMember = "SubTipoVehicular";
            CboSubTipoVehicular.ValueMember = "IdSubTipoVehicular";

            CboTipoVehicular.DataSource = Datos_TipoVehicular.MostrarTipoVehicular();
            CboTipoVehicular.DisplayMember = "TipoVehicular";
            CboTipoVehicular.ValueMember = "IdTipoVehiculo";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            iniciar();
            this.Hide();
        }

        private void checkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTodos.Checked == true)
            {
                CboSubTipoVehicular.Enabled = false;
                CboTipoVehicular.Enabled = false;
                CboEstadoVehicular.Enabled = false;
            }
            else
            {
                CboSubTipoVehicular.Enabled = true;
                CboTipoVehicular.Enabled = true;
                CboEstadoVehicular.Enabled = true;
            }

        }
    }
}
