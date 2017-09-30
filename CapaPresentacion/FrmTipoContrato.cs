using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;
using MetroFramework;

namespace CapaPresentacion
{
    public partial class FrmTipoContrato : MetroFramework.Forms.MetroForm
    {
        CapaDatos.TipoContrato Datos_TipoContrato = new TipoContrato();
        CapaNegocios.DTOTipoContrato Negocio_TipoContrato = new DTOTipoContrato();
        int estado;
        char acction;

        public FrmTipoContrato()
        {
            InitializeComponent();
            Iniciar();
        }
        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            Txttipocontrato.Enabled = false;
            Txttipocontrato.Text = "";
            TxtBusqueda.Text = "";
            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaTipoContrato.DataSource = null;
            CargarGrilla();
        }

        public void CargarGrilla()
        {

            GrillaTipoContrato.DataSource = Datos_TipoContrato.MostrarTipoContrato();
            GrillaTipoContrato.Columns[0].Visible = false;
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
            
        }

        private void FrmTipoContrato_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            Txttipocontrato.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (Txttipocontrato.Text != "")
            {
                Negocio_TipoContrato.TipoContrato = Txttipocontrato.Text;

            switch (acction)
            {
                case 'n':
                    estado = Datos_TipoContrato.GuardarTipoContrato(Negocio_TipoContrato);
                    break;
                case 'm':
                    Negocio_TipoContrato.IdTipoContrato = int.Parse(TxtCodigo.Text);
                    estado = Datos_TipoContrato.ModificarTipoContrato(Negocio_TipoContrato);
                    break;
            }


            try
            {
                if (estado == 1)
                {
                        MetroMessageBox.Show(this, "Datos Guardados Correctamente!!...", "Informacion...", MessageBoxButtons.OK, MessageBoxIcon.Question);
                       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!! : " + ex.Message);
            }

            Iniciar();

        }
            else
            {
                MetroMessageBox.Show(this, "El campo Tipo Contrato es obligatorio...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        }

        private void GrillaTipoContrato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaTipoContrato.DataSource = Datos_TipoContrato.BuscarTipoContrato(TxtBusqueda.Text);
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaTipoContrato.DataSource = Datos_TipoContrato.BuscarTipoContrato(TxtBusqueda.Text);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void GrillaTipoContrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                TxtCodigo.Enabled = false;
                Txttipocontrato.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                Txttipocontrato.Text = GrillaTipoContrato.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaTipoContrato.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void FrmTipoContrato_FormClosing(object sender, FormClosingEventArgs e)
        {
            Iniciar();
            this.Hide();
            e.Cancel = true;
        }

        private void Txttipocontrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MetroMessageBox.Show(this, "Solo se permite letra...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
                e.Handled = true;
                return;
            }
        }
    }
}
