using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        CapaDatos.Usuario Datos_Usuario = new CapaDatos.Usuario();
        FrmPrincipal frm_principal;
        DataTable usuarios;
        static string usuario_global;
        static string perfil_global;
        static int id_global;

        public FrmLogin()
        {
            InitializeComponent();
        }

        public void Logueo()
        {
            usuarios = new DataTable();
            usuarios = Datos_Usuario.Login(TxtUsuario.Text, Datos_Usuario.Encriptar(TxtPassword.Text));
            if (usuarios.Rows.Count > 0)
            {
                MessageBox.Show("Usuario correcto! \n Bienvenido: " + usuarios.Rows[0][3].ToString());
                id_global = int.Parse(usuarios.Rows[0][0].ToString());
                usuario_global = usuarios.Rows[0][3].ToString() + " " + usuarios.Rows[0][4].ToString();
                perfil_global = usuarios.Rows[0][10].ToString();
                frm_principal = new FrmPrincipal();
                frm_principal.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("usuario y/o password incorrecots");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtUsuario.Text = String.Empty;
            TxtPassword.Text = String.Empty;
        }

        private void LnkSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta Seguro que desea Salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (result)
            {              
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:

                    break;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Logueo();
        }

        public static int ObtenerId()
        {
            return id_global;
        }

        public static String ObtenerUsuario()
        {
            return usuario_global;
        }

        public static String ObtenerPerfil()
        {
            return perfil_global;
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logueo();
            }
        }
    }
}
