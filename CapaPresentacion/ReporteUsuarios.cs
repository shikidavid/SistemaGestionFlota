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
    public partial class ReporteUsuarios : MetroFramework.Forms.MetroForm
    {
        CapaDatos.Perfil Datos_Perfil = new CapaDatos.Perfil(); 

        public ReporteUsuarios()
        {
            InitializeComponent();
        }
        public void iniciar()
        {
            cboperfil.Text = "";
            checkBoxPerfil.Checked = false;

        }

        private void ReporteUsuarios_Load(object sender, EventArgs e)
        {
            cboperfil.DataSource = Datos_Perfil.MostrarPerfil();
            cboperfil.DisplayMember = "Perfil";
            cboperfil.ValueMember = "IdPerfil";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            iniciar();
            this.Hide();
        }

        private void checkBoxPerfil_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxPerfil.Checked == true)
            {
                cboperfil.Enabled = false;
            }
            else
            {
                cboperfil.Enabled = true;
            }

        }
    }
}
