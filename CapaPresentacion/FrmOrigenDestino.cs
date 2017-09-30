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
    public partial class FrmOrigenDestino : MetroFramework.Forms.MetroForm
    {
        CapaDatos.OrigenDestino Datos_OrigenDestino = new OrigenDestino();
        CapaNegocios.DtoOrigenDestino Negocio_OrigenDestino = new DtoOrigenDestino();
        int estado;
        char acction;

        public FrmOrigenDestino()
        {
            InitializeComponent();
            Iniciar();
        }
        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtDestino.Enabled = false;
            TxtAbreDestino.Enabled = false;
            TxtAbreOrigen.Enabled = false;
            TxtOrigen.Enabled = false;
            TxtObservacion.Enabled = false;
            TxtLista.Enabled = false;
            CboTipoRuta.Enabled = false;
            txtkilometraje.Enabled = false;
            TxtDestino.Text = "";
            TxtAbreDestino.Text = "";
            TxtAbreOrigen.Text = "";
            TxtOrigen.Text = "";
            TxtObservacion.Text = "";
            TxtLista.Text = "";
            TxtBuscar.Text = "";
            txtkilometraje.Text= "";
            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaOrigenDestino.DataSource = null;
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            GrillaOrigenDestino.DataSource = Datos_OrigenDestino.MostrarOrigenDestino();
            GrillaOrigenDestino.Columns[0].Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void FrmOrigenDestino_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtLista.Enabled = false;
            TxtOrigen.Enabled = true;
            TxtObservacion.Enabled = true;
            TxtAbreOrigen.Enabled = false;
            TxtAbreDestino.Enabled = false;
            TxtDestino.Enabled = true;
            CboTipoRuta.Enabled = true;
            txtkilometraje.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
            CboTipoRuta.SelectedIndex = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtOrigen.Text != "")
            {
                if (TxtDestino.Text != "")
                {
                    if (CboTipoRuta.SelectedIndex != 0)
                    {
                        Negocio_OrigenDestino.Origen = TxtOrigen.Text;
                        Negocio_OrigenDestino.AbreO = TxtAbreOrigen.Text;
                        Negocio_OrigenDestino.Destino = TxtDestino.Text;
                        Negocio_OrigenDestino.AbreD = TxtAbreDestino.Text;
                        Negocio_OrigenDestino.Observacion = TxtObservacion.Text;
                        Negocio_OrigenDestino.Concatenacion = TxtLista.Text;
                        Negocio_OrigenDestino.Kilometraje = Convert.ToInt32(txtkilometraje.Text.ToString());

                        Negocio_OrigenDestino.Ruta = CboTipoRuta.SelectedItem.ToString();
                        switch (acction)
                        {
                            case 'n':
                                estado = Datos_OrigenDestino.GuardarOrigenDestino(Negocio_OrigenDestino);
                                break;
                            case 'm':
                                Negocio_OrigenDestino.IdOrigenDestino = int.Parse(TxtCodigo.Text);
                                estado = Datos_OrigenDestino.ModificarOrigenDestino(Negocio_OrigenDestino);
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
                        MetroMessageBox.Show(this, "El campo ruta es obligatorio...", "Informacion...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El campo destino es obligatorio...", "Informacion...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                }
            }
            else
            {
                MetroMessageBox.Show(this, "El campo origen es obligatorio...", "Informacion...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            
        }

        private void GrillaOrigenDestino_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            GrillaOrigenDestino.DataSource = Datos_OrigenDestino.BuscarOrigenDestino(TxtBuscar.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaOrigenDestino.DataSource = Datos_OrigenDestino.BuscarOrigenDestino(TxtBuscar.Text);
        }

        private void TxtOrigen_TextChanged(object sender, EventArgs e)
        {
            int len = TxtOrigen.Text.Length;
            if (len >= 3)
            {
                TxtAbreOrigen.Text = TxtOrigen.Text.Substring(0, 3).ToUpper();
            }
            else
            {
                TxtAbreOrigen.Text = "";
            }
        }

        private void TxtAbreDestino_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void TxtDestino_TextChanged(object sender, EventArgs e)
        {
            int len = TxtDestino.Text.Length;
            if (len >= 3)
            {
                TxtAbreDestino.Text = TxtDestino.Text.Substring(0, 3).ToUpper();
            }
            else
            {
                TxtAbreDestino.Text = "";
            }
        }

        private void TxtAbreOrigen_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void CboTipoRuta_SelectedValueChanged(object sender, EventArgs e)
        {
            int len_origen, len_destino;
            len_origen = TxtAbreOrigen.Text.Length;
            len_destino = TxtAbreDestino.Text.Length;

            if (CboTipoRuta.SelectedIndex != 0)
            {
                switch (CboTipoRuta.SelectedIndex)
                {
                    case 1:
                        if (len_origen == 3 && len_destino == 3)
                        {
                            TxtLista.Text = (TxtAbreOrigen.Text + "-" + TxtAbreDestino.Text + "-PRI").ToUpper();
                        }
                        break;
                    case 2:
                        if (len_origen == 3 && len_destino == 3)
                        {
                            TxtLista.Text = (TxtAbreOrigen.Text + "-" + TxtAbreDestino.Text + "-AL1").ToUpper();
                        }
                        break;
                    case 3:
                        if (len_origen == 3 && len_destino == 3)
                        {
                            TxtLista.Text = (TxtAbreOrigen.Text + "-" + TxtAbreDestino.Text + "-AL2").ToUpper();
                        }
                        break;
                    case 4:
                        if (len_origen == 3 && len_destino == 3)
                        {
                            TxtLista.Text = (TxtAbreOrigen.Text + "-" + TxtAbreDestino.Text + "-AL3").ToUpper();
                        }
                        break;
                }
            }
            else
            {
                TxtLista.Text = "";
            }
        }

        private void GrillaOrigenDestino_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtCodigo.Enabled = false;
                TxtOrigen.Enabled = true;
                TxtDestino.Enabled = true;
                TxtAbreOrigen.Enabled = false;
                TxtAbreDestino.Enabled = false;
                TxtObservacion.Enabled = true;
                TxtLista.Enabled = false;
                CboTipoRuta.Enabled = true;
                txtkilometraje.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                TxtLista.Text = GrillaOrigenDestino.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtkilometraje.Text = GrillaOrigenDestino.Rows[e.RowIndex].Cells[8].Value.ToString();
                TxtObservacion.Text = GrillaOrigenDestino.Rows[e.RowIndex].Cells[7].Value.ToString();
                TxtAbreDestino.Text = GrillaOrigenDestino.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtAbreOrigen.Text = GrillaOrigenDestino.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtDestino.Text = GrillaOrigenDestino.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtOrigen.Text = GrillaOrigenDestino.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaOrigenDestino.Rows[e.RowIndex].Cells[0].Value.ToString();
                CboTipoRuta.Text = GrillaOrigenDestino.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void GrillaOrigenDestino_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TxtOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MetroMessageBox.Show(this, "Solo se permite letra...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
                e.Handled = true;
                return;
            }
        }

        private void TxtDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MetroMessageBox.Show(this, "Solo se permite letra...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Handled = true;
                return;
            }
        }

        private void txtkilometraje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permite numeros...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                e.Handled = true;
                return;
            }
        }
    }
}
