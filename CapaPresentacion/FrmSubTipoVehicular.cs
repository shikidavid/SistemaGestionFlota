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
    public partial class FrmSubTipoVehicular : MetroFramework.Forms.MetroForm
    {
        CapaDatos.SubTipoVehicular Datos_SubTipoVehicular = new SubTipoVehicular();
        CapaNegocios.DTOSubTipoVehicular Negocio_SubTipoVehicular = new DTOSubTipoVehicular();
        int estado;
        char acction;

        public FrmSubTipoVehicular()
        {
            InitializeComponent();
            Iniciar();
        }
        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtSubTipoVehicular.Enabled = false;
            TxtDescripcion.Enabled = false;
            TxtSubTipoVehicular.Text = "";
            TxtDescripcion.Text = "";
            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaSubTipoVehicular.DataSource = null;
            CargarGrilla();
        }
        public void CargarGrilla()
        {

            GrillaSubTipoVehicular.DataSource = Datos_SubTipoVehicular.MostrarSubTipoVehicularGrilla();
            GrillaSubTipoVehicular.Columns[0].Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmSubTipoVehicular_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtSubTipoVehicular.Enabled = true;
            TxtDescripcion.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            Negocio_SubTipoVehicular.Descripcion = TxtDescripcion.Text;

            if (TxtSubTipoVehicular.Text != "")
            {
                Negocio_SubTipoVehicular.SubTipoVehicular = TxtSubTipoVehicular.Text;


                switch (acction)
                {
                    case 'n':
                        estado = Datos_SubTipoVehicular.GuardarSubTipoVehicular(Negocio_SubTipoVehicular);
                        break;
                    case 'm':
                        Negocio_SubTipoVehicular.IdSubTipoVehicular = int.Parse(TxtCodigo.Text);
                        estado = Datos_SubTipoVehicular.ModificarSubTipoVehicular(Negocio_SubTipoVehicular);
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
                MetroMessageBox.Show(this, "El campo SubTipo es obligatori...", "Informacion...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaSubTipoVehicular.DataSource = Datos_SubTipoVehicular.BuscarSubTipoVehicular(TxtBusqueda.Text);
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaSubTipoVehicular.DataSource = Datos_SubTipoVehicular.BuscarSubTipoVehicular(TxtBusqueda.Text);
        }

        private void GrillaSubTipoVehicular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void GrillaSubTipoVehicular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtCodigo.Enabled = false;
                TxtSubTipoVehicular.Enabled = true;
                TxtDescripcion.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                TxtDescripcion.Text = GrillaSubTipoVehicular.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtSubTipoVehicular.Text = GrillaSubTipoVehicular.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaSubTipoVehicular.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }
    }
}
