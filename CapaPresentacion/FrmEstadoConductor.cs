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
    public partial class FrmEstadoConductor : MetroFramework.Forms.MetroForm
    {
        CapaDatos.EstadoConductor Datos_EstadoConductor =  new EstadoConductor();
        CapaNegocios.DTOEstadoConductor Negocio_EstadoConductor = new DTOEstadoConductor();
        int estado;
        char acction;

        public FrmEstadoConductor()
        {
            InitializeComponent();
            Iniciar();
        }

        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtEstado.Enabled = false;
            TxtEstado.Text = "";
            TxtBusqueda.Text = "";
            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaEstadoConductore.DataSource = null;
            CargarGrilla();
        }

        public void CargarGrilla()
        {            
            GrillaEstadoConductore.DataSource = Datos_EstadoConductor.MostarEstadoConductor();
            GrillaEstadoConductore.Columns[0].Visible = false;
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
                Negocio_EstadoConductor.EstadoConductor = TxtEstado.Text;

            switch (acction)
            {
                case 'n':
                    estado = Datos_EstadoConductor.GuardarEstadoConductor(Negocio_EstadoConductor);
                    break;
                case 'm':
                    Negocio_EstadoConductor.IdEstadoconductor = int.Parse(TxtCodigo.Text);
                    estado = Datos_EstadoConductor.ModificarEstadoConductor(Negocio_EstadoConductor);
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
                MetroMessageBox.Show(this, "El campo Estado es obligatorio...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Question);
                
            }
        }

        private void GrillaEstadoConductore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GrillaEstadoConductore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                TxtCodigo.Enabled = false;
                TxtEstado.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                TxtEstado.Text = GrillaEstadoConductore.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaEstadoConductore.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaEstadoConductore.DataSource = Datos_EstadoConductor.BuscarEstadoConductor(TxtBusqueda.Text);
        }

        private void TxtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaEstadoConductore.DataSource = Datos_EstadoConductor.BuscarEstadoConductor(TxtBusqueda.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmEstadoConductor_Load(object sender, EventArgs e)
        {

        }

        private void FrmEstadoConductor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void GrillaEstadoConductore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                TxtCodigo.Enabled = false;
                TxtEstado.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                TxtEstado.Text = GrillaEstadoConductore.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaEstadoConductore.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }

        private void TxtEstado_KeyPress(object sender, KeyPressEventArgs e)
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
