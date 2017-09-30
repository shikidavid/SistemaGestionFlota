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
    public partial class FrmEstadoCivil : MetroFramework.Forms.MetroForm
    {

        CapaDatos.EstadoCivil Datos_EstadoCivil = new EstadoCivil();
        CapaNegocios.DTOEstadoCivil Negocio_EstadoCivil = new DTOEstadoCivil();
        int estado;
        char acction;

        public FrmEstadoCivil()
        {
            InitializeComponent();
            Iniciar();
        }

        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtEstadoCivil.Enabled = false;
            TxtEstadoCivil.Text = "";
            TxtBusqueda.Text = "";
            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaEstadoCivil.DataSource = null;
            CargarGrilla();
        }
        public void CargarGrilla()
        {

            GrillaEstadoCivil.DataSource = Datos_EstadoCivil.MostrarEstadoCivil();
            GrillaEstadoCivil.Columns[0].Visible = false;
        }

        private void FrmEstadoCivil_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtEstadoCivil.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtEstadoCivil.Text != "")
            { 
                Negocio_EstadoCivil.EstadoCivil = TxtEstadoCivil.Text;

            switch (acction)
            {
                case 'n':
                    estado = Datos_EstadoCivil.GuardarEstadoCivil(Negocio_EstadoCivil);
                    break;
                case 'm':
                    Negocio_EstadoCivil.IdEstadocivil = int.Parse(TxtCodigo.Text);
                    estado = Datos_EstadoCivil.ModificarEstadoCivil(Negocio_EstadoCivil);
                    break;
            }


            try
            {
                if (estado == 1)
                {
                MetroMessageBox.Show(this, "Datos Guardados Correctamente...", "Registro...", MessageBoxButtons.OK, MessageBoxIcon.Question);

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
                MetroMessageBox.Show(this, "El campo Estado Civil es obligatorio...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
            }
        }

        private void GrillaEstadoCivil_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaEstadoCivil.DataSource = Datos_EstadoCivil.BuscarEstadoCivil(TxtBusqueda.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaEstadoCivil.DataSource = Datos_EstadoCivil.BuscarEstadoCivil(TxtBusqueda.Text);
        }

        private void GrillaEstadoCivil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void GrillaEstadoCivil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtCodigo.Enabled = false;
                TxtEstadoCivil.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                TxtEstadoCivil.Text = GrillaEstadoCivil.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaEstadoCivil.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }

        private void TxtEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
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
