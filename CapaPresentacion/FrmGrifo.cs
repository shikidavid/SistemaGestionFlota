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
    public partial class FrmGrifo : MetroFramework.Forms.MetroForm
    {
        CapaDatos.Grifo Datos_Grifo = new CapaDatos.Grifo();
        CapaNegocios.DTOGrifos Negocio_Grifo = new DTOGrifos();
        int estado;
        char acction;

        public FrmGrifo()
        {
            InitializeComponent();
            Iniciar();
        }
        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtRuc.Enabled = false;
            TxtGrifo.Enabled = false;
            TxtPrecio.Enabled = false;
            TxtTelefono.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtReferencia.Enabled = false;

            TxtRuc.Text = "";
            TxtGrifo.Text = "";
            TxtPrecio.Text = "";
            TxtTelefono.Text = "";
            TxtDireccion.Text = "";
            TxtReferencia.Text = "";
            TxtBusqueda.Text = "";


            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaGrifo.DataSource = null;
            CargarGrilla();
        }
                
        public void CargarGrilla()
        {
            GrillaGrifo.DataSource = Datos_Grifo.MostraGrifo();
            GrillaGrifo.Columns[0].Visible = false;
        }

        public Boolean ValidarRUC()
        {
            if (TxtRuc.Text.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ValidarExistenciaRUC()
        {
            double ruc = Convert.ToDouble(TxtRuc.Text);
            DataTable dt = Datos_Grifo.BuscarRuc(ruc);
            if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void FrmGrifo_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtRuc.Enabled = true;
            TxtGrifo.Enabled = true;
            TxtPrecio.Enabled = true;
            TxtTelefono.Enabled = true;
            TxtDireccion.Enabled = true;
            TxtReferencia.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtRuc.Text != "")
            {
                if (TxtGrifo.Text != "")
                {
                    if (TxtPrecio.Text != "")
                    {
                        if (ValidarRUC())
                        {
                            if (ValidarExistenciaRUC())
                            {
                                Negocio_Grifo.Ruc = Convert.ToDouble(TxtRuc.Text.ToString());
                                Negocio_Grifo.Grifo = TxtGrifo.Text;
                                Negocio_Grifo.Precio = Convert.ToDecimal(TxtPrecio.Text.Replace('.', ','));
                                Negocio_Grifo.Telefono = TxtTelefono.Text;
                                Negocio_Grifo.Direccion = TxtDireccion.Text;
                                Negocio_Grifo.Referencia = TxtReferencia.Text;

                                switch (acction)
                                {
                                    case 'n':
                                        estado = Datos_Grifo.GuardarGrifo(Negocio_Grifo);
                                        break;
                                    case 'm':
                                        Negocio_Grifo.IdGrifos = int.Parse(TxtCodigo.Text);
                                        estado = Datos_Grifo.ModificarGrifo(Negocio_Grifo);
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
                                MessageBox.Show("El RUC " + TxtRuc.Text + " ya existe");
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "El campo RUC debe tener 11 digitos...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "El campo precio es obligatorio...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El campo grifo es obligatorio...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          
                }
            }
            else
            {
                MetroMessageBox.Show(this, "El campo ruc es obligatorio...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     
            }
            
         
            


            
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaGrifo.DataSource = Datos_Grifo.BuscarGrifo(TxtBusqueda.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaGrifo.DataSource = Datos_Grifo.BuscarGrifo(TxtBusqueda.Text);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void GrillaGrifo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void TxtRuc_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtRuc_KeyDown(object sender, KeyEventArgs e)
        {
             
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                switch (e.KeyChar)
                {
                    case '.':
                        e.Handled = false;
                        break;
                    case ',':
                        e.Handled = false;
                        break;
                    case '\b':
                        e.Handled = false;
                        break;
                    default:
                        e.Handled = true;
                        break;
                }
            }            
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void GrillaGrifo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                TxtCodigo.Enabled = false;
                TxtRuc.Enabled = true;
                TxtGrifo.Enabled = true;
                TxtPrecio.Enabled = true;
                TxtTelefono.Enabled = true;
                TxtDireccion.Enabled = true;
                TxtReferencia.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';


                TxtReferencia.Text = GrillaGrifo.Rows[e.RowIndex].Cells[6].Value.ToString();
                TxtDireccion.Text = GrillaGrifo.Rows[e.RowIndex].Cells[5].Value.ToString();
                TxtTelefono.Text = GrillaGrifo.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtPrecio.Text = GrillaGrifo.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtGrifo.Text = GrillaGrifo.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtRuc.Text = GrillaGrifo.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtCodigo.Text = GrillaGrifo.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }
    }
}
