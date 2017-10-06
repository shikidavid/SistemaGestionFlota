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
    public partial class FrmPerfil : MetroFramework.Forms.MetroForm
    {
        CapaDatos.Perfil Datos_Perfil = new Perfil();
        CapaNegocios.DTOPerfil Negocio_Perfil = new DTOPerfil();
        int estado;
        char acction;

        public FrmPerfil()
        {
            InitializeComponent();
            Iniciar();
        }
        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtPerfil.Enabled = false;
            TxtPerfil.Text = "";
            TxtBusqueda.Text = "";
            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaPerfil.DataSource = null;
            CargarGrilla();
        }

        public void CargarGrilla()
        {

            GrillaPerfil.DataSource = Datos_Perfil.MostrarPerfil();
            GrillaPerfil.Columns[0].Visible = false;
        }

        public bool VerificarExistenciaPerfil(string perfil)
        {
            DataTable dt = new DataTable();
            dt = Datos_Perfil.BuscarPerfil(perfil);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtPerfil.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (VerificarExistenciaPerfil(TxtPerfil.Text))
            {
                MessageBox.Show("El Perfil ya existe");
            }
            else
            {


                Negocio_Perfil.Perfil = TxtPerfil.Text;

                switch (acction)
                {
                    case 'n':
                        estado = Datos_Perfil.GuardarPerfil(Negocio_Perfil);
                        break;
                    case 'm':
                        Negocio_Perfil.IdPerfil = int.Parse(TxtCodigo.Text);
                        estado = Datos_Perfil.ModificarPerfil(Negocio_Perfil);
                        break;
                }


                try
                {
                    if (estado == 1)
                    {
                        MetroMessageBox.Show(this, "Datos Guardados Correctamente!!...", "Registro...", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    Iniciar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR!!! : " + ex.Message);
                }
            }
            
        }

        private void GrillaPerfil_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaPerfil.DataSource = Datos_Perfil.BuscarPerfil(TxtBusqueda.Text);
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaPerfil.DataSource = Datos_Perfil.BuscarPerfil(TxtBusqueda.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {

        }

        private void GrillaPerfil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 1)
            {
                TxtCodigo.Enabled = false;
                TxtPerfil.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                TxtPerfil.Text = GrillaPerfil.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaPerfil.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }

        private void TxtPerfil_KeyPress(object sender, KeyPressEventArgs e)
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
