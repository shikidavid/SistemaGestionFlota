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
    public partial class FrmLiquidar : MetroFramework.Forms.MetroForm
    {
        public FrmLiquidar()
        {
            InitializeComponent();
        }

        //private void BtnSalir_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //}
        public void iniciar()
        {
            txtplaca.Text = "";
            //dtfechainicial.Text = "";
            //dtfechafinal.Text = "";
            metroCheckBoxTodo.Checked = false;
            txtnumero.Text = "";
            checkescaneo.Checked = false;
            txtscaneo.Text = "";
            txtobservacion.Text = "";
            txtvueltas.Text = "";
            txtcantidadconsumo.Text = "";
            txtexcesoconsumo.Text = "";
            txtkilometraje.Text = "";
            txttiempo.Text = "";
           


        }
        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            iniciar();
            this.Hide();
        }

        private void dtfechafinal_ValueChanged(object sender, EventArgs e)
        {
        //    if (dtfechafinal.Value >= dtfechainicial.Value)
        //    {
        //        //MessageBox.Show("dao");
        //    }
        //    else 
        //    {
        //        MetroMessageBox.Show(this, "La fecha inicial no puede ser mayor que la fecha final...", "Verificacion...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        // MessageBox.Show("La fecha desde no puede ser mayor que hasta");
        //        dtfechafinal.Text = "";
        //    }
        }

        private void metroCheckBoxTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBoxTodo.Checked == true)
            {
                txtnumero.Enabled = false;

            }
            else
            {
                txtnumero.Enabled = true;

            }
        }

        private void checkescaneo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkescaneo.Checked == true)
            {
                txtscaneo.Enabled = false;

            }
            else
            {
                txtscaneo.Enabled = true;

            }
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
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
