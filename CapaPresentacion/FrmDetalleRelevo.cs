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
    public partial class FrmDetalleRelevo : MetroFramework.Forms.MetroForm
    {
        CapaDatos.Relevo Datos_Relevo = new CapaDatos.Relevo();
        CapaDatos.RelevoUnidad Datos_RelevoUnidad = new CapaDatos.RelevoUnidad();

        CapaNegocios.DTORelevoUnidad Negocios_RelevoUnidad = new CapaNegocios.DTORelevoUnidad();

        DataTable dt = new DataTable();
        
        int origen;
        int placa;

   

        public FrmDetalleRelevo()
        {
            InitializeComponent();
        }

        public string kilometraje, tanqueo;



        public void CargarCombo()
        {
            CbRelevo.DataSource = Datos_Relevo.BuscarRelevoXPlacaXOrigen(placa,origen);
            CbRelevo.DisplayMember = "Relevo";
        }

        public void CargarGrilla()
        {
            GrillaRelevoUnidad.DataSource = Datos_RelevoUnidad.BuscarRelevoUnidad(placa, origen);
            GrillaRelevoUnidad.Columns[0].Visible = false;
            GrillaRelevoUnidad.Columns[1].Visible = false;

            if (GrillaRelevoUnidad.Rows.Count == 0)
            {
                txttotaltanqueo.Text = "0";
                TxtTotalKilometraje.Text = "0";
            }
            else
            {
                txttotaltanqueo.Text = CalcularTanqueo(Datos_RelevoUnidad.BuscarRelevoUnidad(placa, origen)).ToString();
                TxtTotalKilometraje.Text = Math.Round(CalcularKilometraje(Datos_RelevoUnidad.BuscarRelevoUnidad(placa, origen)), 2).ToString();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroButton1.DialogResult = DialogResult.OK;
            tanqueo = txttotaltanqueo.Text;
            kilometraje = TxtTotalKilometraje.Text;  
        }

        private void FrmDetalleRelevo_Load(object sender, EventArgs e)
        {
            origen = FrmCombustible.ObtenerOrigen();
            placa = FrmCombustible.ObtenerPlaca();

            CargarCombo();
            CargarGrilla();
        }

        public int BuscarExistencia()
        {
            string relevo;
            int count=0;
            for (int i = 0; i < GrillaRelevoUnidad.Rows.Count; i++)
            {
                relevo = GrillaRelevoUnidad.Rows[i].Cells[2].Value.ToString();
                if (relevo == CbRelevo.Text)
                {
                    count++;
                    kilometraje = GrillaRelevoUnidad.Rows[i].Cells[3].Value.ToString();
                    tanqueo = GrillaRelevoUnidad.Rows[i].Cells[4].Value.ToString();
                }
            }
            return count;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtKilometraje.Text == string.Empty)
            {
                MessageBox.Show("el campo kilometraje es requerido");                
            }
            else
            {
                if (TxtTanqueo.Text == string.Empty)
                {
                    MessageBox.Show("El campo tanqueo es requerido");
                }
                else
                {
                    int estado = 0;
                    Negocios_RelevoUnidad.IdOrigenDestino = origen;
                    Negocios_RelevoUnidad.IdUnidadVehicular = placa;
                    Negocios_RelevoUnidad.Relevo = CbRelevo.Text;
                    Negocios_RelevoUnidad.Kilometraje = double.Parse(TxtKilometraje.Text.Replace('.',','));
                    Negocios_RelevoUnidad.Tanqueo = double.Parse(TxtTanqueo.Text.Replace('.', ','));

                    if (BuscarExistencia() == 1)
                    {
                        estado = Datos_RelevoUnidad.ModificarRelevoUnidad(Negocios_RelevoUnidad);
                    }
                    else
                    {
                        estado = Datos_RelevoUnidad.GuardarRelevoUnidad(Negocios_RelevoUnidad);
                    }


                    if (estado == 1)
                    {
                        MessageBox.Show("Datos Guardados Correctamente");
                    }

                    CargarGrilla();
                }
            }            
            
        }

        public double CalcularTanqueo(DataTable dt)
        {
            double total = 0, temp = 0;
            
            List<double> lista = new List<double>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(double.Parse(dt.Rows[i][4].ToString()));
            }
            LstTiempos.Items.Clear();
            for (int i = 0; i < lista.Count - 1; i++)
            {                
                temp = lista[i + 1] - lista[i];
                total = total + temp;
                LstTiempos.Items.Add("\n" + temp.ToString());
            }
            return total;
        }

        private void CbRelevo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarExistencia();

            TxtKilometraje.Text = kilometraje;
            TxtTanqueo.Text = tanqueo;
        }

        private void CbRelevo_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void CbRelevo_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void CbRelevo_TextChanged(object sender, EventArgs e)
        {
            
        }

        public double CalcularKilometraje(DataTable dt)
        {
            double total = 0;
            int count = dt.Rows.Count;

            List<double> lista = new List<double>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(double.Parse(dt.Rows[i][3].ToString()));
            }

            total = double.Parse(lista[count - 1].ToString()) - double.Parse(lista[0].ToString());
            
            return total;
        }
    }
}
