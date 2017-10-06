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
    public partial class FrmUsuario : MetroFramework.Forms.MetroForm
    {
        CapaDatos.Perfil Datos_Perfil = new CapaDatos.Perfil();

        CapaDatos.Usuario Datos_Usuario = new CapaDatos.Usuario();
        CapaNegocios.DTOUsuario Negocio_Usuario = new DTOUsuario();
        int estado;
        char acction;


        public FrmUsuario()
        {
            InitializeComponent();
            Iniciar();
        }
        public void Iniciar()
        {
            TxtCodigo.Enabled = false;
            TxtUsuario.Enabled = false;
            TxtContraseño.Enabled = false;
            TxtContraseñaRepetida.Enabled = false;
            TxtNombre.Enabled = false;
            TxtApellido.Enabled = false;
            TxtDireccion.Enabled = false;
            DtFechanacimiento.Enabled = false;
            CboPerfil.Enabled = false;
            CboSexo.Enabled = false;
            TxtUsuario.Text = "";
            TxtContraseño.Text = "";
            TxtContraseñaRepetida.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDireccion.Text = "";
            TxtBuscar.Text = "";
            BtnNuevo.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = false;
            GrillaUsuario.DataSource = null;
            CargarGrilla();
            CboSexo.SelectedItem = 1;
        }
        public void CargarGrilla()
        {
            GrillaUsuario.DataSource = Datos_Usuario.MostrarUsuarios();
            GrillaUsuario.Columns[0].Visible = false;
        }

        public bool VerificarExistenciaUsuario(string usuario)
        {
            DataTable dt = new DataTable();
            dt = Datos_Usuario.BuscarUsuario(usuario);
            if (dt.Rows.Count > 0)
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

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CboPerfil.DataSource = Datos_Perfil.MostrarPerfil();
            CboPerfil.DisplayMember = "Perfil";
            CboPerfil.ValueMember = "IdPerfil";
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigo.Enabled = false;
            TxtUsuario.Enabled = true;
            TxtContraseño.Enabled = true;
            TxtContraseñaRepetida.Enabled = true;
            TxtNombre.Enabled = true;
            TxtApellido.Enabled = true;
            TxtDireccion.Enabled = true;
            DtFechanacimiento.Enabled = true;
            CboPerfil.Enabled = true;
            CboSexo.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnGuardar.Enabled = true;

            acction = 'n';
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == string.Empty || TxtContraseño.Text == string.Empty || TxtContraseñaRepetida.Text == string.Empty || TxtNombre.Text == string.Empty || TxtApellido.Text == string.Empty || TxtDireccion.Text == string.Empty || CboPerfil.Text == "Seleccione" || CboSexo.Text == "Seleccione")
            {
                MessageBox.Show("Debe Registrar todos los datos");
            }
            else
            {
                if (VerificarExistenciaUsuario(TxtUsuario.Text))
                {
                    MessageBox.Show("El Usuario ya existe");
                }
                else
                {
                    Negocio_Usuario.Usuario = TxtUsuario.Text;
                    Negocio_Usuario.Password = Datos_Usuario.Encriptar(TxtContraseño.Text);
                    Negocio_Usuario.Nombre = TxtNombre.Text;
                    Negocio_Usuario.Apellido = TxtApellido.Text;
                    Negocio_Usuario.Direccion = TxtDireccion.Text;
                    Negocio_Usuario.FechaNacimiento = DtFechanacimiento.Value;
                    Negocio_Usuario.IdPerfil = Convert.ToInt32(CboPerfil.SelectedValue);
                    Negocio_Usuario.Sexo = CboSexo.SelectedItem.ToString();

                    switch (acction)
                    {
                        case 'n':
                            estado = Datos_Usuario.GuardarUsuario(Negocio_Usuario);
                            break;
                        case 'm':
                            Negocio_Usuario.IdUsuario = int.Parse(TxtCodigo.Text);
                            estado = Datos_Usuario.ModificarUsuario(Negocio_Usuario);
                            break;
                    }

                    try
                    {
                        if (estado == 1)
                        {
                            MetroMessageBox.Show(this, "Datos Guardados Correctamente!!...", "Informacion...", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            Iniciar();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR!!! : " + ex.Message);
                    }
                }
            }            
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            GrillaUsuario.DataSource = Datos_Usuario.BuscarUsuario(TxtBuscar.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GrillaUsuario.DataSource = Datos_Usuario.BuscarUsuario(TxtBuscar.Text);
        }

        private void GrillaUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void CboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MetroMessageBox.Show(this, "Solo se permite letra...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                e.Handled = true;
                return;
            }
        }

        private void GrillaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                TxtCodigo.Enabled = false;
                TxtUsuario.Enabled = true;
                TxtContraseño.Enabled = true;
                TxtContraseñaRepetida.Enabled = true;
                TxtNombre.Enabled = true;
                TxtApellido.Enabled = true;
                TxtDireccion.Enabled = true;
                DtFechanacimiento.Enabled = true;
                CboPerfil.Enabled = true;
                CboSexo.Enabled = true;
                BtnNuevo.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;

                acction = 'm';

                CboSexo.Text = GrillaUsuario.Rows[e.RowIndex].Cells[7].Value.ToString();
                CboPerfil.Text = GrillaUsuario.Rows[e.RowIndex].Cells[8].Value.ToString();
                DtFechanacimiento.Text = GrillaUsuario.Rows[e.RowIndex].Cells[6].Value.ToString();
                TxtDireccion.Text = GrillaUsuario.Rows[e.RowIndex].Cells[5].Value.ToString();
                TxtApellido.Text = GrillaUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();
                TxtNombre.Text = GrillaUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtContraseño.Text = GrillaUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
                TxtUsuario.Text = GrillaUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtCodigo.Text = GrillaUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            TxtContraseño.Focus();
        }

        private void TxtContraseño_Leave(object sender, EventArgs e)
        {
            TxtContraseñaRepetida.Focus();
        }

        private void TxtContraseñaRepetida_Leave(object sender, EventArgs e)
        {
            TxtNombre.Focus();
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            TxtApellido.Focus();
        }

        private void TxtApellido_Leave(object sender, EventArgs e)
        {
            TxtDireccion.Focus();
        }
    }
}
