using MetroFramework;
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
    public partial class FrmSeguimientoLlamadas : MetroFramework.Forms.MetroForm
    {
        CapaDatos.SeguimientoLlamada Datos_SeguimientoLlamada = new CapaDatos.SeguimientoLlamada();
        CapaDatos.OrigenDestino Datos_OrigenDestino = new CapaDatos.OrigenDestino();
        public FrmSeguimientoLlamadas()
        {
            
            InitializeComponent();
            Iniciar();
        }
        public void Iniciar()
        {
            CboTipoLlamada.Text = "Seleccione";
            CboUbicacion.Text = "Seleccione";
            CboOcurrencia.Text = "Seleccione";
            CboEstado.Text = "Seleccione";
            cboestadoviaje.Text = "Seleccione";
            cboorigendestino.Text = "Seleccione";
            TxtHora.Enabled = false;
            CheckBoxHora.Checked = false;
            CheckBoxPesoBalanza.Checked = false;
            CheckBoxTelefono.Checked = false;
            TxtPesoBalanza.Enabled = false;
            CboTelefono.Enabled = false;
            TxtBuscarPlaca.Text = "";
            metroDateTime1.Enabled = false;
            CboTelefono.Text = "";
            TxtHora.Text = "";
            TxtPesoBalanza.Text = "";



        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void FrmSeguimientoLlamadas_Load(object sender, EventArgs e)
        {
            CboTipoLlamada.DataSource = Datos_SeguimientoLlamada.MostrarTipoLlamada();
            CboTipoLlamada.DisplayMember = "Nombre";
            CboTipoLlamada.ValueMember = "IdTipoLlamada";
            CboTipoLlamada.Text = "Seleccione";


            CboUbicacion.DataSource = Datos_SeguimientoLlamada.MostrarUbicacionLlamada();
            CboUbicacion.DisplayMember = "Nombre";
            CboUbicacion.ValueMember = "IdUbicacion";
            CboUbicacion.Text = "Seleccione";

            CboOcurrencia.DataSource = Datos_SeguimientoLlamada.MostrarOcurrenciaLlamada();
            CboOcurrencia.DisplayMember = "Nombre";
            CboOcurrencia.ValueMember = "IdOcurrencia";
            CboOcurrencia.Text = "Seleccione";

            CboEstado.DataSource = Datos_SeguimientoLlamada.MostrarEstadoLlamada();
            CboEstado.DisplayMember = "Nombre";
            CboEstado.ValueMember = "IdEstadoLlamada";
            CboEstado.Text = "Seleccione";

            cboestadoviaje.DataSource = Datos_SeguimientoLlamada.MostrarEstadoViaje();
            cboestadoviaje.DisplayMember = "Nombre";
            cboestadoviaje.ValueMember = "IdEstadoViaje";
            cboestadoviaje.Text = "Seleccione";

            cboorigendestino.DataSource = Datos_OrigenDestino.MostrarOrigenDestino();
            cboorigendestino.DisplayMember = "Concatenacion";
            cboorigendestino.ValueMember = "IdOrigenDestino";
            cboorigendestino.Text = "Seleccione";

            Iniciar();
        }

        private void CheckBoxHora_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxHora.Checked == true)
            {
                TxtHora.Enabled = true;

            }
            else
            {
                TxtHora.Enabled = false;
            }
        }

        private void CheckBoxPesoBalanza_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxPesoBalanza.Checked == true)
            {
                TxtPesoBalanza.Enabled = true;
            }
            else
            {
                TxtPesoBalanza.Enabled = false;
            }
        }

        private void CheckBoxTelefono_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxTelefono.Checked == true)
            {
                CboTelefono.Enabled = true;
            }
            else
            {
                CboTelefono.Enabled = false;

            }
        }

        private void TxtPesoBalanza_KeyDown(object sender, KeyEventArgs e)
        {
            //if (TxtPesoBalanza.Text.IndexOf('.') != -1)
            //{
            //    TxtPesoBalanza.Text = TxtPesoBalanza.Text.Replace('.', ',');
            //}
        }

        private void TxtHora_Click(object sender, EventArgs e)
        {
            if (TxtHora.MaxLength == 5)
            {
                if (TxtHora.Text.IndexOf(':') == -1)
                {
                   

                }
                else
                {
                    
                }

            }
            else
            {
                MetroMessageBox.Show(this, "El campo tiempo no tiene el formato correcto...", "Verificacion...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CboTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}
