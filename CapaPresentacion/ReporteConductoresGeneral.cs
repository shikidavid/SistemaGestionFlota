using MetroFramework;
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
    public partial class ReporteConductoresGeneral : MetroFramework.Forms.MetroForm
    {
        CapaDatos.EstadoConductor Datos_EstadoConductor = new CapaDatos.EstadoConductor();
        CapaDatos.TipoContrato Datos_TipoContrato = new CapaDatos.TipoContrato();

        public ReporteConductoresGeneral()
        {
            InitializeComponent();
        }

        //private void BtnSalir_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //}
        public void iniciar()
        {
            dtpFechaInicial.Text = "";
            dtpFechaFinal.Text = "";
            dtpFechaVencimiento.Text = "";
            CboEstadoConductor.Text = "";
            CboTipoContrato.Text = "";
            checkBoxEstado.Checked= false;
            checkBoxFecha.Checked = false;
            checkBoxFechaVencimiento.Checked = false;
            checkBoxTipoContrato.Checked = false;
        }
        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            iniciar();
            this.Hide();
        }

        private void ReporteConductoresGeneral_Load(object sender, EventArgs e)
        {
            CboEstadoConductor.DataSource = Datos_EstadoConductor.MostarEstadoConductor();
            CboEstadoConductor.DisplayMember = "EstadoConductor";
            CboEstadoConductor.ValueMember = "IdEstadoconductor";

            CboTipoContrato.DataSource = Datos_TipoContrato.MostrarTipoContrato();
            CboTipoContrato.DisplayMember = "TipoContrato";
            CboTipoContrato.ValueMember = "IdTipoContrato";

            
        }

        private void checkBoxFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFecha.Checked == true)
            {
                dtpFechaInicial.Enabled = false;
                dtpFechaFinal.Enabled = false;
            }
            else
            {
                dtpFechaInicial.Enabled = true;
                dtpFechaFinal.Enabled = true;
            }
        }

        private void checkBoxTipoContrato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTipoContrato.Checked == true)
            {
                CboTipoContrato.Enabled = false;
                
            }
            else
            {
                CboTipoContrato.Enabled = true;
               
            }
        }

        private void checkBoxFechaVencimiento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFechaVencimiento.Checked == true)
            {
                dtpFechaVencimiento.Enabled = false;

            }
            else
            {
                dtpFechaVencimiento.Enabled = true;

            }

        }

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEstado.Checked == true)
            {
                CboEstadoConductor.Enabled = false;

            }
            else
            {
                CboEstadoConductor.Enabled = true;

            }
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if(dtpFechaFinal.Value >= dtpFechaInicial.Value)
            {
                //MessageBox.Show("dao");
            }
            else
            {
                MetroMessageBox.Show(this, "La fecha inicial no puede ser mayor que la fecha final...", "Verificacion...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // MessageBox.Show("La fecha desde no puede ser mayor que hasta");
                dtpFechaFinal.Text = "";
            }
        }
    }
}
