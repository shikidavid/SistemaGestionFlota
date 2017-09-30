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
    public partial class FrmProvincia : MetroFramework.Forms.MetroForm
    {
        CapaDatos.Departamento Datos_Departamento = new CapaDatos.Departamento();

        CapaDatos.Provincia Datos_Provincia = new CapaDatos.Provincia();
        CapaNegocios.DTOProvincia Negocio_Provincia = new DTOProvincia();
        int estado;
        char acction;

        public FrmProvincia()
        {
            InitializeComponent();
            Iniciar();
        }

        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtProvincia.Enabled = false;
            CboDepartamento.Enabled = false;
            TxtProvincia.Text = "";
            TxtBusqueda.Text = "";
            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaProvincia.DataSource = null;
            CargarGrilla();
        }
        public void CargarGrilla()
        {

            GrillaProvincia.DataSource = Datos_Provincia.MostrarProvincia();
            GrillaProvincia.Columns[0].Visible = false;
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void FrmProvincia_Load(object sender, EventArgs e)
        {
            CboDepartamento.DataSource = Datos_Departamento.MostrarDepartamento();
            CboDepartamento.DisplayMember = "Departamento";
            CboDepartamento.ValueMember = "IdDepartamento";

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           
            {
                Negocio_Provincia.Provincia = TxtProvincia.Text;
                Negocio_Provincia.IdDepartamento = Convert.ToInt32(CboDepartamento.SelectedValue);

                switch (acction)
                {
                    case 'n':
                        estado = Datos_Provincia.GuardarProvincia(Negocio_Provincia);
                        break;
                    case 'm':
                        Negocio_Provincia.IdProvincia = int.Parse(TxtCodigo.Text);
                        estado = Datos_Provincia.ModificarProvincia(Negocio_Provincia);
                        break;
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
        }


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtProvincia.Enabled = true;
            CboDepartamento.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaProvincia.DataSource = Datos_Provincia.BuscarProvincia(TxtBusqueda.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaProvincia.DataSource = Datos_Provincia.BuscarProvincia(TxtBusqueda.Text);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void GrillaProvincia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void CboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GrillaProvincia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                TxtCodigo.Enabled = false;
                TxtProvincia.Enabled = true;
                CboDepartamento.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';


                CboDepartamento.Text = GrillaProvincia.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtProvincia.Text = GrillaProvincia.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaProvincia.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void TxtProvincia_KeyPress(object sender, KeyPressEventArgs e)
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
