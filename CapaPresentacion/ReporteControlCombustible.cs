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
    public partial class ReporteControlCombustible : MetroFramework.Forms.MetroForm
    {
        public ReporteControlCombustible()
        {
            InitializeComponent();
        }
        public void iniciar()
        {
            CheckBoxPlacaTodo.Checked = false;
            TxtPlaca.Text = "";

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            iniciar();
            this.Hide();
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBoxPlacaTodo.Checked == true)
            {
                TxtPlaca.Enabled = false;
                TxtPlaca.Text = "";

            }
            else
            {
                TxtPlaca.Enabled = true;
            }
        }

        private void CheckBoxTodosTiempo_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBoxTodosTiempo.Checked == true)
            {

            }
        }
    }
}
