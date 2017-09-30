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
    public partial class FrmImportarData : MetroFramework.Forms.MetroForm
    {
        public FrmImportarData()
        {
            InitializeComponent();
        }
        public void iniciar()
        {
            TxtBuscar.Text = "";
        }
        SqlConnection conexion = new SqlConnection("Data Source = ANALISTA - PC; Initial Catalog = GestionFlota; Integrated Security = true");
        //SqlConnection conexion = new SqlConnection("Data Source = localhost; Initial Catalog = GestionFlota; Integrated Security = true");

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            iniciar();
            this.Hide();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TxtBuscar.Text = ofd.FileName;
                btnimportar.Enabled = true;
                
            }
        }

        private void btnimportar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string database = conexion.Database.ToString();
            try
            {
                string sql1 = string.Format("ALTER DATABASE[" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, conexion);
                cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE[" + database + "] FROM DISK='" + TxtBuscar.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, conexion);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE[" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, conexion);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            iniciar();
            this.Hide();
        }
    }
}
