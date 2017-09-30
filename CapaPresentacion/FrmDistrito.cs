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
    public partial class FrmDistrito : MetroFramework.Forms.MetroForm
    {
        CapaDatos.Provincia Datos_Provincia = new CapaDatos.Provincia();

        CapaDatos.Distrito Datos_Distrito = new CapaDatos.Distrito();
        CapaNegocios.DTODistrito Negocio_Distrito = new DTODistrito();
        int estado;
        char acction;

        public FrmDistrito()
        {
            InitializeComponent();
            Iniciar();
        }

        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtDistrito.Enabled = false;
            CboProvincia.Enabled = false;
            TxtDistrito.Text = "";
            TxtBusqueda.Text = "";
            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaDistrito.DataSource = null;
            CargarGrilla();
        }
        public void CargarGrilla()
        {

            GrillaDistrito.DataSource = Datos_Distrito.MostrarDistrito();
            GrillaDistrito.Columns[0].Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void FrmDistrito_Load(object sender, EventArgs e)
        {
            CboProvincia.DataSource = Datos_Provincia.MostrarProvincia();
            CboProvincia.DisplayMember = "Provincia";
            CboProvincia.ValueMember = "IdProvincia";

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Negocio_Distrito.Distrito = TxtDistrito.Text;
            Negocio_Distrito.IdProvincia = Convert.ToInt32(CboProvincia.SelectedValue);

            switch (acction)
            {
                case 'n':
                    estado = Datos_Distrito.GuardarDistrito(Negocio_Distrito);
                    break;
                case 'm':
                    Negocio_Distrito.IdDistrito = int.Parse(TxtCodigo.Text);
                    estado = Datos_Distrito.ModificarDistrito(Negocio_Distrito);
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtDistrito.Enabled = true;
            CboProvincia.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaDistrito.DataSource = Datos_Distrito.BuscarDistrito(TxtBusqueda.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaDistrito.DataSource = Datos_Distrito.BuscarDistrito(TxtBusqueda.Text);
        }

        private void GrillaDistrito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void GrillaDistrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                TxtCodigo.Enabled = false;
                TxtDistrito.Enabled = true;
                CboProvincia.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';


                CboProvincia.Text = GrillaDistrito.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtDistrito.Text = GrillaDistrito.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaDistrito.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void TxtDistrito_KeyPress(object sender, KeyPressEventArgs e)
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
