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
    public partial class ReporteRutas : MetroFramework.Forms.MetroForm
    {
        CapaDatos.OrigenDestino Datos_OrigenDestino = new CapaDatos.OrigenDestino();
        CapaDatos.TipoVehicular Datos_TipoVehicular = new CapaDatos.TipoVehicular();
        public ReporteRutas()
        {
            InitializeComponent();
        }

        public void iniciar()
        {
            cborutas.Text = "";
            CboTipoVehicular.Text = "";
            checkBoxTipo.Checked = false;
            checkBoxRutas.Checked = false;

        }

        private void ReporteRutas_Load(object sender, EventArgs e)
        {
            cborutas.DataSource = Datos_OrigenDestino.MostrarOrigenDestino();
            cborutas.DisplayMember = "Concatenacion";
            cborutas.ValueMember = "IdOrigenDestino";

            CboTipoVehicular.DataSource = Datos_TipoVehicular.MostrarTipoVehicular();
            CboTipoVehicular.DisplayMember = "TipoVehicular";
            CboTipoVehicular.ValueMember = "IdTipoVehiculo";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            iniciar();
            this.Hide();
        }

        private void checkBoxFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTipo.Checked == true)
            {
                CboTipoVehicular.Enabled = false;

            }
            else
            {
                CboTipoVehicular.Enabled = true;

            }

        }

        private void checkBoxRutas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRutas.Checked == true)
            {
                cborutas.Enabled = false;
                
            }
            else
            {
                cborutas.Enabled = true;
                
            }
        }
    }
}
