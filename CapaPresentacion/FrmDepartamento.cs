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
    public partial class FrmDepartamento : MetroFramework.Forms.MetroForm
    {
        CapaDatos.Departamento Datos_Departamento = new Departamento();
        CapaNegocios.DTODepartamento Negocio_Departamento = new DTODepartamento();
        int estado;
        char acction;

        public FrmDepartamento()
        {
            InitializeComponent();
            Iniciar();
        }

        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtDepartamento.Enabled = false;

            TxtDepartamento.Text = "";
            TxtBusqueda.Text = "";

            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaDepartamento.DataSource = null;
            CargarGrilla();
        }

        public void CargarGrilla()
        {

            GrillaDepartamento.DataSource = Datos_Departamento.MostrarDepartamento();
            GrillaDepartamento.Columns[0].Visible = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtDepartamento.Enabled = true;

            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtDepartamento.Text != "")
            { 
                Negocio_Departamento.Departamento = TxtDepartamento.Text;

            switch (acction)
            {
                case 'n':
                    estado = Datos_Departamento.GuardarDepartamento(Negocio_Departamento);
                    break;
                case 'm':
                    Negocio_Departamento.IdDepartamento = int.Parse(TxtCodigo.Text);
                    estado = Datos_Departamento.ModificarDepartamento(Negocio_Departamento);
                    break;
            }


            try
            {
                if (estado == 1)
                {
                        MetroMessageBox.Show(this, "Datos Guardados Correctamente!!...", "Datos...", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        
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
                MetroMessageBox.Show(this, "El campo Departamento es obligatorio!!...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void GrillaDepartamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaDepartamento.DataSource = Datos_Departamento.BuscarDepartamento(TxtBusqueda.Text);
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaDepartamento.DataSource = Datos_Departamento.BuscarDepartamento(TxtBusqueda.Text);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void GrillaDepartamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtCodigo.Enabled = false;
                TxtDepartamento.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                TxtDepartamento.Text = GrillaDepartamento.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaDepartamento.Rows[e.RowIndex].Cells[0].Value.ToString();

            }

        }

        private void TxtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
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
