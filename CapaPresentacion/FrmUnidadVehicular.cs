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
using MetroFramework;

namespace CapaPresentacion
{
    public partial class FrmUnidadVehicular : MetroFramework.Forms.MetroForm
    {
        CapaDatos.TipoVehicular Datos_TipoVehicular = new CapaDatos.TipoVehicular();
        CapaDatos.EstadoVehicular Datos_EstadoVehicular = new CapaDatos.EstadoVehicular();

        CapaDatos.UnidadVehicular Datos_UnidadVehicular = new CapaDatos.UnidadVehicular();
        CapaNegocios.DTOUnidadVehicular Negocio_UnidadVehicular = new DTOUnidadVehicular();
        int estado;
        char acction;

        public FrmUnidadVehicular()
        {
            InitializeComponent();
            Iniciar();
        }
        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            CboEstado.Enabled = false;
            TxtPlaca.Enabled = false;
            TxtFurjon.Enabled = false;
            TxtModelo.Enabled = false;
            TxtEje.Enabled = false;
            TxtAño.Enabled = false;
            TxtTelefono.Enabled = false;
            TxtTanque.Enabled = false;
            TxtPeso.Enabled = false;
            CboTipo.Enabled = false;
            TxtDescripcion.Enabled = false;
            TxtPlaca.Text = "";
            TxtFurjon.Text = "";
            TxtModelo.Text = "";
            TxtEje.Text = "0";
            TxtAño.Text = "0";
            TxtTelefono.Text = "";
            TxtTanque.Text = "0";
            TxtPeso.Text = "0";
            TxtDescripcion.Text = "";
            TxtBusqueda.Text = "";
            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaUnidad.DataSource = null;
            estado = 0;
            CargarGrilla();
            CboEstado.SelectedValue = 0;
            CboTipo.SelectedValue = 0;
        }
        public void CargarGrilla()
        {

            GrillaUnidad.DataSource = Datos_UnidadVehicular.MostrarUnidadVehicular();
            GrillaUnidad.Columns[0].Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void FrmUnidadVehicular_Load(object sender, EventArgs e)
        {
            CboTipo.DataSource = Datos_TipoVehicular.MostrarTipoVehicular();
            CboTipo.DisplayMember = "TipoVehicular";
            CboTipo.ValueMember = "IdTipoVehiculo";


            CboEstado.DataSource = Datos_EstadoVehicular.MostrarEstadoVehicular();
            CboEstado.DisplayMember = "EstadoVehicular";
            CboEstado.ValueMember = "IdEstadoVehicular";
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            CboEstado.Enabled = true;
            CboTipo.Enabled = true;
            TxtPlaca.Enabled = true;
            TxtFurjon.Enabled = true;
            TxtModelo.Enabled = true;
            TxtEje.Enabled = true;
            TxtAño.Enabled = true;
            TxtTelefono.Enabled = true;
            TxtTanque.Enabled = true;
            TxtPeso.Enabled = true;
            TxtDescripcion.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtPlaca.Text != "")
            {
                if (TxtTelefono.Text != "")
                {
                    if (TxtTanque.Text != "")
                    {
                        if (TxtPeso.Text != "")
                        {
                            if (Convert.ToInt32(CboEstado.SelectedValue) != 0 && Convert.ToInt32(CboTipo.SelectedValue) != 0)
                            {
                                Negocio_UnidadVehicular.Placa = TxtPlaca.Text;
                                Negocio_UnidadVehicular.PlacaFurjon = TxtFurjon.Text;
                                Negocio_UnidadVehicular.Modelo = TxtModelo.Text;
                                
                                Negocio_UnidadVehicular.NEje = Convert.ToInt32(TxtEje.Text);
                                Negocio_UnidadVehicular.Año = Convert.ToInt32(TxtAño.Text);
                                Negocio_UnidadVehicular.NTelefono = TxtTelefono.Text;
                                Negocio_UnidadVehicular.CapTanque = Convert.ToInt32(TxtTanque.Text);
                                Negocio_UnidadVehicular.PesoTara = Convert.ToInt32(TxtPeso.Text);
                                Negocio_UnidadVehicular.Descripcion = TxtDescripcion.Text;

                                Negocio_UnidadVehicular.IdEstadoVehicular = Convert.ToInt32(CboEstado.SelectedValue);
                                Negocio_UnidadVehicular.IdTipoVehiculo = Convert.ToInt32(CboTipo.SelectedValue);

                                switch (acction)
                                {
                                    case 'n':
                                        estado = Datos_UnidadVehicular.GuardarUnidadVehicular(Negocio_UnidadVehicular);

                                        break;
                                    case 'm':
                                        Negocio_UnidadVehicular.IdUnidadVehicular = int.Parse(TxtCodigo.Text);
                                        estado = Datos_UnidadVehicular.ModificarUnidadVehicular(Negocio_UnidadVehicular);
                                        break;
                                }
                                Iniciar();            
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "debe seleccionar el tipo y el estado para poder guardar...", "Registro...", MessageBoxButtons.OK, MessageBoxIcon.None);
                               
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Debe llenar el campo tara para poder guardar...", "Registro...", MessageBoxButtons.OK, MessageBoxIcon.None);
                            
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Debe llenar el campo tanque para poder guardar...", "Registro...", MessageBoxButtons.OK, MessageBoxIcon.None);
                      
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Debe llenar el campo telefono para poder guardar...", "Registro...", MessageBoxButtons.OK, MessageBoxIcon.None);
                    
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Debe llenar el campo placa para poder guardar...", "Registro...", MessageBoxButtons.OK, MessageBoxIcon.None);
               
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

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaUnidad.DataSource = Datos_UnidadVehicular.BuscarUnidadVehicular(TxtBusqueda.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaUnidad.DataSource = Datos_UnidadVehicular.BuscarUnidadVehicular(TxtBusqueda.Text);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void GrillaUnidad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void GrillaUnidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                TxtCodigo.Enabled = false;
                TxtPlaca.Enabled = true;
                TxtFurjon.Enabled = true;
                TxtModelo.Enabled = true;
                TxtEje.Enabled = true;
                TxtAño.Enabled = true;
                TxtTelefono.Enabled = true;
                TxtTanque.Enabled = true;
                TxtPeso.Enabled = true;
                TxtDescripcion.Enabled = true;
                CboTipo.Enabled = true;
                CboEstado.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                CboEstado.Text = GrillaUnidad.Rows[e.RowIndex].Cells[11].Value.ToString();
                CboTipo.Text = GrillaUnidad.Rows[e.RowIndex].Cells[10].Value.ToString();
                TxtDescripcion.Text = GrillaUnidad.Rows[e.RowIndex].Cells[9].Value.ToString();
                TxtPeso.Text = GrillaUnidad.Rows[e.RowIndex].Cells[8].Value.ToString();
                TxtTanque.Text = GrillaUnidad.Rows[e.RowIndex].Cells[7].Value.ToString();
                TxtTelefono.Text = GrillaUnidad.Rows[e.RowIndex].Cells[6].Value.ToString();
                TxtAño.Text = GrillaUnidad.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtEje.Text = GrillaUnidad.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtModelo.Text = GrillaUnidad.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtFurjon.Text = GrillaUnidad.Rows[e.RowIndex].Cells[5].Value.ToString();
                TxtPlaca.Text = GrillaUnidad.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaUnidad.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permite numeros...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void TxtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permite numeros...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void TxtTanque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permite numeros...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permite numeros...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                e.Handled = true;
                return;
            }
        }

        private void TxtEje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
