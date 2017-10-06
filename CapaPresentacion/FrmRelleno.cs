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
using MetroFramework.Forms;

namespace CapaPresentacion
{
    public partial class FrmRelleno : MetroFramework.Forms.MetroForm
    {
        CapaDatos.TipoVehicular Datos_TipoVehicular = new CapaDatos.TipoVehicular();
        CapaDatos.OrigenDestino Datos_OrigenDestino = new CapaDatos.OrigenDestino();

        CapaDatos.RellenoCombustible Datos_Relleno = new CapaDatos.RellenoCombustible();
        CapaNegocios.DTORelleno Negocio_Relleno = new DTORelleno();


        int estado;
        char acction;


        public FrmRelleno()
        {
            InitializeComponent();
            Iniciar();
        }
        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtLugar1.Enabled = false;
            TxtLugar2.Enabled = false;
            CboRuta.Enabled = false;
            cbfamilia.Enabled = false;

            TxtLugar1.Text = "";
            TxtLugar2.Text = "";
            TxtBusqueda.Text = "";
            cbfamilia.Text = "Seleccione";
            CboRuta.Text = "Seleccione";

            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaRelleno.DataSource = null;
            CargarGrilla();
        }

        
        public void CargarGrilla()
        {

            GrillaRelleno.DataSource = Datos_Relleno.MostrarRellenoCombustible();
            GrillaRelleno.Columns[0].Visible = false;
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void FrmRelleno_Load(object sender, EventArgs e)
        {
            cbfamilia.DataSource = Datos_TipoVehicular.MostrarTipoVehicular();
            cbfamilia.DisplayMember = "TipoVehicular";
            cbfamilia.ValueMember = "IdTipoVehiculo";
            cbfamilia.Text = "Seleccione";

            CboRuta.DataSource = Datos_OrigenDestino.MostrarOrigenDestino();
            CboRuta.DisplayMember = "Concatenacion";
            CboRuta.ValueMember = "IdOrigenDestino";
            CboRuta.Text = "Seleccione";
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtLugar1.Enabled = true;
            TxtLugar2.Enabled = true;
            CboRuta.Enabled = true;
            cbfamilia.Enabled = true;


            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (CboRuta.Text == "Seleccione" || cbfamilia.Text == "Seleccione" || TxtLugar1.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar los campos obligatorios");
            }
            else
            {
                Negocio_Relleno.Lugar1 = TxtLugar1.Text;
                Negocio_Relleno.Lugar2 = TxtLugar2.Text;
                Negocio_Relleno.IdTipoVehiculo = Convert.ToInt32(cbfamilia.SelectedValue);
                Negocio_Relleno.IdOrigenDestino = Convert.ToInt32(CboRuta.SelectedValue);

                switch (acction)
                {
                    case 'n':
                        estado = Datos_Relleno.GuardarRelleno(Negocio_Relleno);

                        break;
                    case 'm':
                        Negocio_Relleno.IdRelleno = int.Parse(TxtCodigo.Text);

                        estado = Datos_Relleno.ModificaRellenoCombustible(Negocio_Relleno);

                        break;
                }


                try
                {
                    if (estado == 1)
                    {
                        MetroMessageBox.Show(this, "Datos Guardados Correctamente...", "Registro...", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    Iniciar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR!!! : " + ex.Message);
                }

            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaRelleno.DataSource = Datos_Relleno.BuscarRellenoCombustible(TxtBusqueda.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaRelleno.DataSource = Datos_Relleno.BuscarRellenoCombustible(TxtBusqueda.Text);
        }

        private void GrillaRelleno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                TxtCodigo.Enabled = false;
                TxtLugar1.Enabled = true;
                TxtLugar2.Enabled = true;
                cbfamilia.Enabled = true;
                CboRuta.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                TxtLugar2.Text = GrillaRelleno.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtLugar1.Text = GrillaRelleno.Rows[e.RowIndex].Cells[3].Value.ToString();
                CboRuta.Text = GrillaRelleno.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbfamilia.Text = GrillaRelleno.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaRelleno.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void TxtLugar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar))&& (e.KeyChar != (char)Keys.Back)&&(e.KeyChar !=(char)Keys.Space))
            {
                MetroMessageBox.Show(this, "Solo se permite letra...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
                e.Handled = true;
                return;
            }
        }

        private void TxtLugar2_KeyPress(object sender, KeyPressEventArgs e)
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
