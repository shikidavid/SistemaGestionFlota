using CapaNegocios;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmTipoVehicular : MetroFramework.Forms.MetroForm
    {
        CapaDatos.SubTipoVehicular Datos_SubTipoVehicular = new CapaDatos.SubTipoVehicular();

        CapaDatos.TipoVehicular Datos_TipoVehicular = new CapaDatos.TipoVehicular();
        CapaNegocios.DTOTipoVehicular Negocio_TipoVehicular = new DTOTipoVehicular();
        int estado;
        char acction;

        public FrmTipoVehicular()
        {
            InitializeComponent();

            Iniciar();
        }
        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtTipoVehicular.Enabled = false;
            TxtDescripcion.Enabled = false;
            CboSubTipoVehicular.Enabled = false;

            TxtCodigo.Text = "";
            TxtTipoVehicular.Text = "";
            TxtDescripcion.Text = "";
            TxtBusqueda.Text = "";

            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaTipoVehicular.DataSource = null;
            CboSubTipoVehicular.SelectedValue = 0;
            CargarGrilla();
        }
        public void CargarGrilla()
        {

            GrillaTipoVehicular.DataSource = Datos_TipoVehicular.MostrarTipoVehicular();
            GrillaTipoVehicular.Columns[0].Visible = false;
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void FrmTipoVehicular_Load(object sender, EventArgs e)
        {
            CboSubTipoVehicular.DataSource = Datos_SubTipoVehicular.MostrarSubTipoVehicular();
            CboSubTipoVehicular.DisplayMember = "SubTipoVehicular";
            CboSubTipoVehicular.ValueMember = "IdSubTipoVehicular";

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Negocio_TipoVehicular.TipoVehicular = TxtTipoVehicular.Text;
            Negocio_TipoVehicular.Descripcion = TxtDescripcion.Text;
            Negocio_TipoVehicular.IdSubTipoVehicular = Convert.ToInt32(CboSubTipoVehicular.SelectedValue);

            switch (acction)
            {
                case 'n':
                    if (TxtTipoVehicular.Text == "" || Convert.ToInt32(CboSubTipoVehicular.SelectedValue) == 0)
                    {
                        estado = 0;
                    }
                    else
                    {
                        estado = Datos_TipoVehicular.GuardarTipoVehicular(Negocio_TipoVehicular);
                    }
                    break;
                case 'm':
                    if (TxtTipoVehicular.Text == "" || Convert.ToInt32(CboSubTipoVehicular.SelectedValue) == 0)
                    {
                        estado = 0;
                    }
                    else
                    {
                        Negocio_TipoVehicular.IdTipoVehiculo = int.Parse(TxtCodigo.Text);
                        estado = Datos_TipoVehicular.ModificarTipoVehicular(Negocio_TipoVehicular);
                    }
                    break;
            }


            try
            {
                if (estado == 1)
                {
                    MessageBox.Show("Datos Guardados Correctamente!!");
                }
                else
                {
                    MessageBox.Show("Hay Campos Obligatorios Tipos y SubTipo .");
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
            TxtTipoVehicular.Enabled = true;
            TxtDescripcion.Enabled = true;
            CboSubTipoVehicular.Enabled = true;


            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaTipoVehicular.DataSource = Datos_TipoVehicular.BuscarTipoVehicular(TxtBusqueda.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaTipoVehicular.DataSource = Datos_TipoVehicular.BuscarTipoVehicular(TxtBusqueda.Text);
        }

        private void GrillaTipoVehicular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void GrillaTipoVehicular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void GrillaTipoVehicular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                TxtCodigo.Enabled = false;
                TxtTipoVehicular.Enabled = true;
                TxtDescripcion.Enabled = true;
                CboSubTipoVehicular.Enabled = true;

                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';


                CboSubTipoVehicular.Text = GrillaTipoVehicular.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtDescripcion.Text = GrillaTipoVehicular.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtTipoVehicular.Text = GrillaTipoVehicular.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaTipoVehicular.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
        }

        private void FrmTipoVehicular_FormClosing(object sender, FormClosingEventArgs e)
        {
            Iniciar();
            this.Hide();
            e.Cancel = true;
        }

        private void FrmTipoVehicular_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FrmTipoVehicular_MaximumSizeChanged(object sender, EventArgs e)
        {

        }

        private void FrmTipoVehicular_SizeChanged(object sender, EventArgs e)
        {

        }

        private void FrmTipoVehicular_MaximizedBoundsChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Resize(object sender, EventArgs e)
        {

        }

        private void FrmTipoVehicular_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void FrmTipoVehicular_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void FrmTipoVehicular_AutoSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("ss");
        }

        private void FrmTipoVehicular_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void GrillaTipoVehicular_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                TxtCodigo.Enabled = false;
                TxtTipoVehicular.Enabled = true;
                TxtDescripcion.Enabled = true;
                CboSubTipoVehicular.Enabled = true;

                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';


                CboSubTipoVehicular.Text = GrillaTipoVehicular.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtDescripcion.Text = GrillaTipoVehicular.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtTipoVehicular.Text = GrillaTipoVehicular.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaTipoVehicular.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
        }

        
    }
}
