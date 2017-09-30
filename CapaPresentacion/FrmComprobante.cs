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
    public partial class FrmComprobante : MetroFramework.Forms.MetroForm
    {
        CapaDatos.Comprobante Datos_Comprobante = new Comprobante();
        CapaNegocios.DTOComprobante Negocio_Comprobanter = new DTOComprobante();
        int estado;
        char acction;

        public FrmComprobante()
        {
            InitializeComponent();
            Iniciar();
        }

        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            Txtcomprobante.Enabled = false;
            txtdescripcion.Enabled = false;
            Txtcomprobante.Text = "";
            txtdescripcion.Text = "";
            TxtBusqueda.Text = "";

            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaComprobante.DataSource = null;
            CargarGrilla();
        }

        public void CargarGrilla()
        {

            GrillaComprobante.DataSource = Datos_Comprobante.MostrarComprobante();
            GrillaComprobante.Columns[0].Visible = false;
        }

        private void FrmComprobante_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            Txtcomprobante.Enabled = true;
            txtdescripcion.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Negocio_Comprobanter.Descripcion = txtdescripcion.Text;

            if (Txtcomprobante.Text != "")
            { 
                Negocio_Comprobanter.Comprobante = Txtcomprobante.Text;
           

           

            switch (acction)
            {
                case 'n':
                    estado = Datos_Comprobante.GuardarComprobante(Negocio_Comprobanter);
                    break;
                case 'm':
                    Negocio_Comprobanter.IdComprobante = int.Parse(TxtCodigo.Text);
                    estado = Datos_Comprobante.ModificarComprobante(Negocio_Comprobanter);
                    break;
            }


            try
            {
                if (estado == 1)
                {
                        MetroMessageBox.Show(this, "Datos Guardados Correctamente!!...", "Proceso...", MessageBoxButtons.OK, MessageBoxIcon.Question);
     
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
                MetroMessageBox.Show(this, "El campo Comprobante es obligatorio!!...", "Proceso...", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
        }

        private void GrillaComprobante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaComprobante.DataSource = Datos_Comprobante.BuscarComprobante(TxtBusqueda.Text);
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaComprobante.DataSource = Datos_Comprobante.BuscarComprobante(TxtBusqueda.Text);

        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void GrillaComprobante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtCodigo.Enabled = false;
                Txtcomprobante.Enabled = true;
                txtdescripcion.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                txtdescripcion.Text = GrillaComprobante.Rows[e.RowIndex].Cells[2].Value.ToString();
                Txtcomprobante.Text = GrillaComprobante.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaComprobante.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void Txtcomprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MetroMessageBox.Show(this, "Solo se permite letra...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Question);
               
                e.Handled = true;
                return;
            }
        }
    }
}
