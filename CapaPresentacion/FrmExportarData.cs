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
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FrmExportarData : MetroFramework.Forms.MetroForm
    {
        CapaDatos.Conexion Datos_Conexion = new CapaDatos.Conexion();
        CapaDatos.Seguridad Datos_Seguridad = new CapaDatos.Seguridad();

        int estado;
        char acction;
        string fecha;
        string hora;

        public FrmExportarData()
        {
            InitializeComponent();
        }
        public void iniciar()
        {
            TxtBuscar.Text = "";
            TxtBuscar.Enabled = false;
        }

        
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            iniciar();
            this.Hide();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            if (TxtBuscar.Text == string.Empty)
            {
                MessageBox.Show("Seleccione una Carpeta");
            }
            else
            {
                estado = Datos_Seguridad.BackUp(TxtBuscar.Text);
                if (estado > 0)
                {
                    MessageBox.Show("Copia de Seguridad creada correctamente");
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            var fbd = new SaveFileDialog();
            DialogResult result = fbd.ShowDialog();
            
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                fecha = DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString();
                hora = DateTime.Now.ToShortTimeString();
                hora = hora.Replace(":", "");
                TxtBuscar.Text = fbd.FileName + "\\" + "Backup_" + fecha + "_" + hora + ".bak"; 
                BtnSeleccionar.Enabled = true;
            }
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            iniciar();
            this.Hide();
        }
    }
}
