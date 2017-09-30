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
using MetroFramework.Forms;
using MetroFramework.Drawing;
using MetroFramework.Controls;
using System.Drawing;
using MetroFramework.Interfaces;
using MetroFramework.Components;


namespace CapaPresentacion
{
    public partial class FrmEstadoVehicular : MetroFramework.Forms.MetroForm
    {
        CapaDatos.EstadoVehicular Datos_EstadoVehicular = new EstadoVehicular();
        CapaNegocios.DTOEstadoVehicular Negocio_EstadoVehicular = new DTOEstadoVehicular();
        int estado;
        char acction;

        public FrmEstadoVehicular()
        {
            InitializeComponent();
            Iniciar();
        }
        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtEstado.Enabled = false;
            TxtEstado.Text = "";
            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaEstadoVehicular.DataSource = null;
            CargarGrilla();
        }

        public void CargarGrilla()
        {
           
            GrillaEstadoVehicular.DataSource = Datos_EstadoVehicular.MostrarEstadoVehicularGrilla();
            GrillaEstadoVehicular.Columns[0].Visible = false;
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtEstado.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (TxtEstado.Text != "")
            {

                Negocio_EstadoVehicular.EstadoVehicular = TxtEstado.Text;

                switch (acction)
                {
                    case 'n':
                        estado = Datos_EstadoVehicular.GuardarEstadoVehicular(Negocio_EstadoVehicular);
                        break;
                    case 'm':
                        Negocio_EstadoVehicular.IdEstadoVehicular = int.Parse(TxtCodigo.Text);
                        estado = Datos_EstadoVehicular.ModificarEstadoVehicular(Negocio_EstadoVehicular);
                        break;
                }


                try
                {
                    if (estado == 1)
                    {
                        MetroMessageBox.Show(this, "Datos Guardados Correctamente!!...", "Registro...", MessageBoxButtons.OK, MessageBoxIcon.Question);
      
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
                MetroMessageBox.Show(this, "El campo Estado Vehicular es obligatorio...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
            }
            }

        private void GrillaEstadoVehicular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaEstadoVehicular.DataSource = Datos_EstadoVehicular.BuscarEstadoVehicular(TxtBusqueda.Text);
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            //GrillaEstadoVehicular.DataSource = Datos_EstadoVehicular.BuscarEstadoVehicular(TxtBusqueda.Text);
        }

        private void FrmEstadoVehicular_Load(object sender, EventArgs e)
        {

        }

        private void GrillaEstadoVehicular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                TxtCodigo.Enabled = false;
                TxtEstado.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                TxtEstado.Text = GrillaEstadoVehicular.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaEstadoVehicular.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }

        private void TxtBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            GrillaEstadoVehicular.DataSource = Datos_EstadoVehicular.BuscarEstadoVehicular(TxtBusqueda.Text);
        }

        private void MetroCancelar_Click(object sender, EventArgs e)
        {
            //MetroCancelar.BackColor = System.Drawing.Color.Coral;
            //MetroCancelar.BackColor = System.Drawing.Color.Coral;
            
        }

        private void TxtEstado_KeyPress(object sender, KeyPressEventArgs e)
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
