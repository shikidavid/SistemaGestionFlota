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
    public partial class FrmConductores : MetroFramework.Forms.MetroForm
    {
        CapaDatos.Conductores Datos_Conductor = new CapaDatos.Conductores();
        CapaDatos.EstadoCivil Datos_EstadoCivil = new CapaDatos.EstadoCivil();
        CapaDatos.EstadoConductor Datos_EstadoConductor = new CapaDatos.EstadoConductor();
        CapaDatos.Departamento Datos_Departamento = new CapaDatos.Departamento();
        CapaDatos.Provincia Datos_Provincia = new CapaDatos.Provincia();
        CapaDatos.Distrito Datos_Distrito = new CapaDatos.Distrito();

        CapaDatos.Conductores Datos_Conductores = new CapaDatos.Conductores();
        CapaNegocios.DTOConductor Negocio_Conductores = new DTOConductor();
        int estado;
        bool estado_departamento = false, estado_provincia = false, estado_distrito = false;
        char acction;
        char estado_cb_departamento = '0';
        

        public FrmConductores()
        {
            InitializeComponent();
            Iniciar();
        }

        public void Iniciarr()
        {
            // CargarGrillaOrigenDestino();
            //CargarGrillaTiempoRuta();
            //CargarComboTiempo();
           // GrillaConductores.DataSource = null;
            TxtBusqueda.Text =  string.Empty;
        }

        public bool ValidarDNI(string dni)
        {
            DataTable dt = Datos_Conductor.BuscarDNI(dni);
            if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LlenarDepartamento()
        {
            CboDepartamento.DataSource = Datos_Departamento.MostrarDepartamento();
            CboDepartamento.DisplayMember = "Departamento";
            CboDepartamento.ValueMember = "IdDepartamento";
        }

        public void VaciarDepartamento()
        {
            CboDepartamento.DataSource = null;
            CboDepartamento.Text = "Seleccione";
        }

        public void LlenarProvincia()
        {
            CboProvincia.DataSource = Datos_Provincia.BuscarProvinciaXDepartamento(int.Parse(CboDepartamento.SelectedValue.ToString()));
            CboProvincia.DisplayMember = "Provincia";
            CboProvincia.ValueMember = "IdProvincia";
        }

        public void VaciarProvincia()
        {
            CboProvincia.DataSource = null;
            CboProvincia.Text = "Seleccione";
        }

        public void LlenarDistrito()
        {
            CboDistrito.DataSource = Datos_Distrito.BuscarDistritoXProvincia(int.Parse(CboProvincia.SelectedValue.ToString()));
            CboDistrito.DisplayMember = "Distrito";
            CboDistrito.ValueMember = "IdDistrito";
        }

        public void VaciarDistrito()
        {
            CboDistrito.DataSource = null;
            CboDistrito.Text = "Seleccione";
        }

        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtDNI.Enabled = false;
            TxtApellido.Enabled = false;
            TxtNombre.Enabled = false;
            TxtLicencia.Enabled = false;
            TxtCategoria.Enabled = false;
            TxtClase.Enabled = false;
            DTfechavencimiento.Enabled = false;
            CboCivil.Enabled = false;
            TxtTelefonopersonal.Enabled = false;
            TxtTelefonoemergente.Enabled = false;
            TxtDireccion.Enabled = false;
            CboDepartamento.Enabled = false;
            CboProvincia.Enabled = false;
            CboDistrito.Enabled = false;
            TxtDirecciondos.Enabled = false;
            DtFechacontrato.Enabled = false;
            DTfechafincontrato.Enabled = false;
            CboEstadoConductor.Enabled = false;
            CboContrato.Enabled = false;

            TxtDNI.Text = "";
            TxtApellido.Text = "";
            TxtNombre.Text = "";
            TxtLicencia.Text = "";
            TxtCategoria.Text = "";
            TxtClase.Text = "";
            DTfechafincontrato.Text = "";
            CboCivil.Text = "";
            TxtTelefonopersonal.Text = "";
            TxtTelefonoemergente.Text = "";
            CboDepartamento.Text = "";
            CboProvincia.Text = "";
            TxtDireccion.Text = "";
            CboDistrito.Text = "";
            TxtDirecciondos.Text = "";
            DtFechacontrato.Text = "";
            DTfechafincontrato.Text = "";
            CboEstadoConductor.Text = "";
            CboContrato.Text = "";
            TxtBusqueda.Text = "";

            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;

            GrillaConductores.DataSource = null;
            CargarGrilla();
            estado_distrito = false;
            estado_provincia = false;
            VaciarDepartamento();            
        }
        public void CargarGrilla()
        {
            GrillaConductores.DataSource = Datos_Conductores.MostrarConductores();
            GrillaConductores.Columns[0].Visible = false;
            GrillaConductores.Columns[10].Visible = false;
            GrillaConductores.Columns[11].Visible = false;
            GrillaConductores.Columns[12].Visible = false;
            GrillaConductores.Columns[13].Visible = false;
            GrillaConductores.Columns[14].Visible = false;
            GrillaConductores.Columns[15].Visible = false;
            GrillaConductores.Columns[16].Visible = false;
            GrillaConductores.Columns[17].Visible = false;
            GrillaConductores.Columns[19].Visible = false;
            GrillaConductores.Columns[21].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Iniciarr();
            this.Hide();
        }

        private void FrmConductores_Load(object sender, EventArgs e)
        {
            CboContrato.DataSource = Datos_Conductor.MostrarTipoContrato();
            CboContrato.DisplayMember = "TipoContrato";
            CboContrato.ValueMember = "IdTipoContrato";

            CboCivil.DataSource = Datos_Conductor.MostrarEstadoCivil();
            CboCivil.DisplayMember = "EstadoCivil";
            CboCivil.ValueMember = "IdEstadoCivil";

            CboEstadoConductor.DataSource = Datos_Conductor.MostrarEstadoConductor();
            CboEstadoConductor.DisplayMember = "EstadoConductor";
            CboEstadoConductor.ValueMember = "IdEstadoconductor";

            //CboDepartamento.DataSource = Datos_Departamento.MostrarDepartamento();
            //CboDepartamento.DisplayMember = "Departamento";
            //CboDepartamento.ValueMember = "IdDepartamento";


            //CboProvincia.DataSource = Datos_Provincia.MostrarProvincia();
            //CboProvincia.DisplayMember = "Provincia";
            //CboProvincia.ValueMember = "IdProvincia";

            //CboDistrito.DataSource = Datos_Distrito.MostrarDistrito();
            //CboDistrito.DisplayMember = "Distrito";
            //CboDistrito.ValueMember = "IdDistrito";


            //foreach (DataGridViewColumn c in GrillaConductores.Columns)
            //{
            //    c.DefaultCellStyle.Font = new Font("Arial", 11F, GraphicsUnit.Pixel);
            //}
            VaciarDepartamento();
            //estado_provincia = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtDNI.Enabled = true;
            TxtApellido.Enabled = true;
            TxtNombre.Enabled = true;
            TxtLicencia.Enabled = true;
            TxtCategoria.Enabled = true;
            TxtClase.Enabled = true;
            DTfechavencimiento.Enabled = true;
            CboCivil.Enabled = true;
            TxtTelefonopersonal.Enabled = true;
            TxtTelefonoemergente.Enabled = true;
            TxtDireccion.Enabled = true;
            CboDepartamento.Enabled = true;
            CboProvincia.Enabled = true;
            CboDistrito.Enabled = true;
            TxtDirecciondos.Enabled = true;
            DtFechacontrato.Enabled = true;
            DTfechafincontrato.Enabled = true;
            CboContrato.Enabled = true;
            CboEstadoConductor.Enabled = true;

            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
            estado_cb_departamento = '1';
            LlenarDepartamento();
            estado_provincia = true;
            
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaConductores.DataSource = Datos_Conductores.BuscarConductor(TxtBusqueda.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaConductores.DataSource = Datos_Conductores.BuscarConductor(TxtBusqueda.Text);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {           
            Iniciar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Negocio_Conductores.DNI = TxtDNI.Text;
            Negocio_Conductores.Apellido = TxtApellido.Text;
            Negocio_Conductores.Nombre = TxtNombre.Text;
            Negocio_Conductores.Licencia = TxtLicencia.Text;
            Negocio_Conductores.Categoria = TxtCategoria.Text;

            Negocio_Conductores.Clase = TxtClase.Text;
            Negocio_Conductores.Fecha_Vencimiento = DTfechavencimiento.Value;
            Negocio_Conductores.IdEstadoCivil = Convert.ToInt32(CboCivil.SelectedValue);

            Negocio_Conductores.Telefono = TxtTelefonopersonal.Text;
            Negocio_Conductores.Telefono2 = TxtTelefonoemergente.Text;
            Negocio_Conductores.Direccion_Actual = TxtDireccion.Text;

            Negocio_Conductores.IdDistrito = Convert.ToInt32(CboDistrito.SelectedValue);
            Negocio_Conductores.Direccion = TxtDirecciondos.Text;
            Negocio_Conductores.Fecha_Contrato = DtFechacontrato.Value;
            Negocio_Conductores.Fecha_Fin = DTfechafincontrato.Value;

            Negocio_Conductores.IdEstadoconductor = Convert.ToInt32(CboEstadoConductor.SelectedValue);
            Negocio_Conductores.IdTipoContrato = Convert.ToInt32(CboContrato.SelectedValue);

            switch (acction)
            {
                case 'n':
                    if (ValidarDNI(TxtDNI.Text))
                    {
                        estado = Datos_Conductores.GuardarConductores(Negocio_Conductores);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "El DNI ya existe, por favor!!...", "Verifique...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }                    
                    break;
                case 'm':
                    Negocio_Conductores.IdConductor = int.Parse(TxtCodigo.Text);
                    estado = Datos_Conductores.ModificarConductores(Negocio_Conductores);
                    break;
            }

            try
            {
                if (estado == 1)
                {
                    MetroMessageBox.Show(this, "Datos Guardados Correctamente!!...", "Guardado...", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    
                }
            }
            catch (Exception ex)
            {
                //MetroMessageBox.Show(this, "Datos Guardados Correctamente!!...", "Guardado...", MessageBoxButtons.OK, MessageBoxIcon.Question);
                MessageBox.Show("ERROR!!! : " + ex.Message);
            }
            Iniciar();

            
            
        }

        private void GrillaConductores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void CboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (estado_provincia)
            {
                LlenarProvincia();
                estado_distrito = true;
            }
        }

        

        private void CboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (estado_distrito)
            {
                LlenarDistrito();
            }
        }

        private void TxtTelefonopersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permite numeros...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                e.Handled = true;
                return;
            }
        }

        private void TxtTelefonoemergente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permite numeros...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                e.Handled = true;
                return;
            }
        }

        private void TxtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MetroMessageBox.Show(this, "Solo se permite numeros...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void GrillaConductores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtCodigo.Enabled = false;
                TxtDNI.Enabled = true;
                TxtApellido.Enabled = true;
                TxtNombre.Enabled = true;
                TxtLicencia.Enabled = true;
                TxtCategoria.Enabled = true;
                TxtClase.Enabled = true;
                DTfechavencimiento.Enabled = true;
                CboCivil.Enabled = true;
                TxtTelefonopersonal.Enabled = true;


                TxtTelefonoemergente.Enabled = true;
                TxtDireccion.Enabled = true;
                CboDepartamento.Enabled = true;
                CboProvincia.Enabled = true;
                CboDistrito.Enabled = true;
                TxtDirecciondos.Enabled = true;
                DtFechacontrato.Enabled = true;
                DTfechafincontrato.Enabled = true;
                CboContrato.Enabled = true;
                CboEstadoConductor.Enabled = true;


                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                CboDistrito.Text = GrillaConductores.Rows[e.RowIndex].Cells[17].Value.ToString();
                CboCivil.Text = GrillaConductores.Rows[e.RowIndex].Cells[16].Value.ToString();
                CboContrato.Text = GrillaConductores.Rows[e.RowIndex].Cells[15].Value.ToString();
                CboEstadoConductor.Text = GrillaConductores.Rows[e.RowIndex].Cells[14].Value.ToString();
                DTfechafincontrato.Text = GrillaConductores.Rows[e.RowIndex].Cells[13].Value.ToString();
                DtFechacontrato.Text = GrillaConductores.Rows[e.RowIndex].Cells[12].Value.ToString();
                TxtDirecciondos.Text = GrillaConductores.Rows[e.RowIndex].Cells[11].Value.ToString();
                TxtDireccion.Text = GrillaConductores.Rows[e.RowIndex].Cells[10].Value.ToString();
                TxtTelefonoemergente.Text = GrillaConductores.Rows[e.RowIndex].Cells[9].Value.ToString();
                TxtTelefonopersonal.Text = GrillaConductores.Rows[e.RowIndex].Cells[8].Value.ToString();
                DTfechavencimiento.Text = GrillaConductores.Rows[e.RowIndex].Cells[7].Value.ToString();
                TxtClase.Text = GrillaConductores.Rows[e.RowIndex].Cells[6].Value.ToString();
                TxtCategoria.Text = GrillaConductores.Rows[e.RowIndex].Cells[5].Value.ToString();
                TxtLicencia.Text = GrillaConductores.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtNombre.Text = GrillaConductores.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtApellido.Text = GrillaConductores.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtDNI.Text = GrillaConductores.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaConductores.Rows[e.RowIndex].Cells[0].Value.ToString();

                LlenarDepartamento();
                CboDepartamento.SelectedValue = int.Parse(GrillaConductores.Rows[e.RowIndex].Cells[17].Value.ToString());


                LlenarProvincia();
                CboProvincia.SelectedValue = int.Parse(GrillaConductores.Rows[e.RowIndex].Cells[19].Value.ToString());
                LlenarDistrito();
                CboDistrito.SelectedValue = int.Parse(GrillaConductores.Rows[e.RowIndex].Cells[21].Value.ToString());

                estado_provincia = true;
                estado_distrito = true;
            }

        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MetroMessageBox.Show(this, "Solo se permite letra...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                e.Handled = true;
                return;
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MetroMessageBox.Show(this, "Solo se permite letra...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Handled = true;
                return;
            }
        }

        private void BtnNuevo_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void CboDepartamento_Click(object sender, EventArgs e)
        {
            
            //CboDepartamento.DataSource = Datos_Departamento.MostrarDepartamento();
            //CboDepartamento.DisplayMember = "Departamento";
            //CboDepartamento.ValueMember = "IdDepartamento";
        }
    }
}
