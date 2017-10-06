using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CapaNegocios;
using MetroFramework;

namespace CapaPresentacion
{
    public partial class FrmCombustible : MetroFramework.Forms.MetroForm
    {
        FrmLiquidar frmliquidar = new FrmLiquidar();

        CapaDatos.OrigenDestino Datos_OrigenDestino = new CapaDatos.OrigenDestino();
        CapaDatos.Combustible Datos_Combustible = new CapaDatos.Combustible();
        CapaDatos.AsignacionCombustible Datos_Asignacioncombustible = new CapaDatos.AsignacionCombustible();
        CapaDatos.Conductores Datos_Conductor = new CapaDatos.Conductores();
        CapaDatos.Relevo Datos_Relevo = new CapaDatos.Relevo();
        CapaDatos.Grifo Datos_Grifo = new CapaDatos.Grifo();
        CapaDatos.RellenoCombustible Datos_RellenoCombustible = new CapaDatos.RellenoCombustible();
        CapaDatos.Tiempo Datos_Tiempo = new CapaDatos.Tiempo();
        CapaDatos.AsignacionPesos Datos_AsignacionPesos = new CapaDatos.AsignacionPesos();

        CapaNegocios.DTOCombustible Negocios_Combustible = new DTOCombustible();

        static int origen;
        static int placa;

        int familia;
        int IdUnidadVehicular = 0;
        int pil = 0, copil = 0;
        int estado;
        char acction;
        int user;
        int detalle = 0;

        int Estado_CbOrigen = 0;
        bool estado_detalle = false;

        public FrmCombustible()
        {
            InitializeComponent();
            iniciar();
        }

        public void CalcularGalonaje(double balanza,double galonaje_fisico)
        {
            double capacidad;
            double galonaje_terorico;
            double exceso = 0;
            DataTable dt_pesos = new DataTable();
            dt_pesos = Datos_AsignacionPesos.BuscarPesosXFamiliaXOrigenDestino(familia, origen);
            
            for (int i = dt_pesos.Rows.Count; i > 0; i--)
            {
                galonaje_terorico = double.Parse(dt_pesos.Rows[i - 1][3].ToString());
                capacidad = double.Parse(dt_pesos.Rows[i - 1][2].ToString());
                if (balanza >= capacidad)
                {
                    txtestadoconsumo.Text = galonaje_terorico.ToString();
                    exceso = galonaje_fisico - galonaje_terorico;
                    txtexcesoconsumo.Text = exceso.ToString();
                    break;
                }
            }
            if (exceso > 0)
            {
                LblEstado.Text = "Exceso";
                LblEstado.ForeColor = Color.Red;
            }
            if (exceso == 0)
            {
                LblEstado.Text = "Normal";
                LblEstado.ForeColor = Color.Blue;
            }
            if (exceso < 0)
            {
                LblEstado.Text = "Ahorro";
                LblEstado.ForeColor = Color.Green;
            }
        }

        public void Calculartiempo(string hora_evaluada)
        {
            DataTable dt = new DataTable();
            dt = Datos_Tiempo.BuscarOrigenDestino(origen);

            int j = 0;
            TimeSpan H_Max,H_Min,H_evaluada;
            TimeSpan minuto = new TimeSpan(0, 0, 1);
            string hora;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                j = i + 1;
                if (i==4)
                {
                    H_Max = new TimeSpan(168, 0, 0);
                }
                else
                {
                    hora = dt.Rows[j][2].ToString();
                    H_Max = new TimeSpan(int.Parse(hora.Substring(0, 2)), int.Parse(hora.Substring(3, 2)), 0);
                    H_Max = H_Max - minuto;
                }
                

               hora = dt.Rows[i][2].ToString();

                H_Min = new TimeSpan(int.Parse(hora.Substring(0, 2)), int.Parse(hora.Substring(3, 2)), 0);
                H_Min = H_Min - minuto;

                H_evaluada = new TimeSpan(int.Parse(hora_evaluada.Substring(0, 2)), int.Parse(hora_evaluada.Substring(3, 2)), 0);

                if (i == 0)
                {
                    if (H_evaluada <= H_Max)
                    {
                        txtestadotiempo.Text = dt.Rows[i][6].ToString();
                        break;
                    }
                    else
                    {
                        
                    }
                }               
                else
                {                    
                    if (H_evaluada <= H_Max && H_evaluada >= H_Min)
                    {
                        txtestadotiempo.Text = dt.Rows[i][6].ToString();
                        break;
                    }
                    else
                    {
                        
                    }
                }
            }
        }



        public void iniciar()
        {            
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            TxtBusqueda.Text = "";


            if (cbOrigenDestino.Items.Count>0)
            {
                cbOrigenDestino.SelectedIndex = -1;
            }
            
            //cboestadotiemporuta.SelectedIndex = -1;
            
            BtnRelevo.Enabled = false;            
            LblEstado.Text = "";
            txtnumeroguias.Enabled = false;
            
        }

        public void CargarGrilla()
        {
            GrillaAsignacionCombustible.DataSource = Datos_Combustible.MostrarPlacaCombustible();
            GrillaAsignacionCombustible.Columns[0].Visible = false;
            GrillaAsignacionCombustible.Columns[6].Visible = false;
            GrillaAsignacionCombustible.Columns[9].Visible = false;
            GrillaAsignacionCombustible.Columns[2].Visible = false;
            GrillaAsignacionCombustible.Columns[8].Visible = false;
        }

        public void CargarGrillaDetalle(int id_placa)
        {
            GrillaDetallePorUnidad.DataSource = Datos_Combustible.MostrarRegistroCombustibleXUnidad(id_placa);
            GrillaDetallePorUnidad.Columns[0].Visible = false;
            //GrillaDetallePorUnidad.Columns[1].Visible = false;
            //GrillaDetallePorUnidad.Columns[2].Visible = false;
            GrillaDetallePorUnidad.Columns[3].Visible = false;
            GrillaDetallePorUnidad.Columns[4].Visible = false;
            //GrillaDetallePorUnidad.Columns[5].Visible = false;
            GrillaDetallePorUnidad.Columns[6].Visible = false;
            GrillaDetallePorUnidad.Columns[7].Visible = false;
            GrillaDetallePorUnidad.Columns[8].Visible = false;
            GrillaDetallePorUnidad.Columns[9].Visible = false;
            GrillaDetallePorUnidad.Columns[10].Visible = false;
            GrillaDetallePorUnidad.Columns[11].Visible = false;
            GrillaDetallePorUnidad.Columns[12].Visible = false;
            //GrillaDetallePorUnidad.Columns[13].Visible = false;
            GrillaDetallePorUnidad.Columns[14].Visible = false;

            for (int i = 0; i < GrillaDetallePorUnidad.Rows.Count; i++)
            {
                if (GrillaDetallePorUnidad.Rows[i].Cells[13].Value.ToString() == "COMPLETO")
                {
                    GrillaDetallePorUnidad.Rows[i].Cells[13].Style.BackColor = Color.Green;
                    GrillaDetallePorUnidad.Rows[i].Cells[13].Style.ForeColor = Color.White;
                }
                if (GrillaDetallePorUnidad.Rows[i].Cells[13].Value.ToString() == "INCOMPLETO")
                {
                    GrillaDetallePorUnidad.Rows[i].Cells[13].Style.BackColor = Color.Yellow;
                    GrillaDetallePorUnidad.Rows[i].Cells[13].Style.ForeColor = Color.Black;
                }
            }

            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            iniciar();
            CargarGrilla();
            this.Hide();
        }

        private void FrmCombustible_Load(object sender, EventArgs e)
        {
            
            cbOrigenDestino.DataSource = Datos_OrigenDestino.MostrarOrigenDestino();
            cbOrigenDestino.DisplayMember = "Concatenacion";
            cbOrigenDestino.ValueMember = "IdOrigenDestino";
            cbOrigenDestino.Text = "Seleccione";
            Estado_CbOrigen = 1;


            //cboGrifo.DataSource = Datos_Grifo.MostraGrifo();
            //cboGrifo.DisplayMember = "Grifo";
            //cboGrifo.ValueMember = "IdGrifos";
            //cboGrifo.Text = "Seleccione";


            //cborelleno1.DataSource = Datos_Grifo.MostraGrifo();
            //cborelleno1.DisplayMember = "Grifo";
            //cborelleno1.ValueMember = "IdGrifos";
            
            //cborelleno1.Text = "Seleccione";

            //cborelleno2.DataSource = Datos_Grifo.MostraGrifo();
            //cborelleno2.DisplayMember = "Grifo";
            //cborelleno2.ValueMember = "IdGrifos";
            //cborelleno2.Text = "Seleccione";


            cboestadotiemporuta.DataSource = Datos_Combustible.MostrarEstadoRutaTiempo();
            cboestadotiemporuta.DisplayMember = "Nombre";
            cboestadotiemporuta.ValueMember = "IdEstadoRutaTiempo";
            cboestadotiemporuta.Text = "Seleccione";
            //cboestadotiemporuta.Items.Insert(0, "Seleccione");
            //cboestadotiemporuta.SelectedIndex = 0;


            iniciar();
            CargarGrilla();
            LblEstado.Text = "";

            CargarGrillaDetalle(placa);
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
           
            GrillaAsignacionCombustible.DataSource = Datos_Combustible.BuscarPlacaCombustible(TxtBusqueda.Text);
            
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
            if(checkBox1.Checked == true)
            {
                //cborelleno1.Enabled = true;
                txtcantidad1.Enabled = true;
                txtcantidad1.Text = "";
                origen = int.Parse(cbOrigenDestino.SelectedValue.ToString());
                dt = Datos_RellenoCombustible.BuscarRellenoCombustibleXTipoVehicularXOrigenDestino(familia, origen);
                if (dt.Rows.Count > 0)
                {
                    txtrelleno1.Text = dt.Rows[0][4].ToString();
                    Txtconsumocombustible.Enabled = false;
                }
                else
                {
                    MetroMessageBox.Show(this, "No hay Relleno para el Origen Seleccionado...", "Verificacion...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                    checkBox1.Checked = false;
                }
            }
            else
            {
                //cborelleno1.Enabled = false;
                //cborelleno1.Text = "Seleccione";
                txtcantidad1.Enabled = false;
                txtcantidad1.Text = "";
                txtrelleno1.Text = "";
                Txtconsumocombustible.Enabled = true;

                checkBox2.Checked = false;
                //cborelleno2.Enabled = false;
                //cborelleno2.Text = "Seleccione";
                txtcantidad2.Enabled = false;
                txtcantidad2.Text = string.Empty;
                txtrelleno2.Text = "";
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (checkBox1.Checked == true)
            {
                if (checkBox2.Checked == true)
                {
                    //cborelleno2.Enabled = true;
                    txtcantidad2.Enabled = true;
                    origen = int.Parse(cbOrigenDestino.SelectedValue.ToString());
                    dt = Datos_RellenoCombustible.BuscarRellenoCombustibleXTipoVehicularXOrigenDestino(familia, origen);
                    if (dt.Rows.Count > 0)
                    {
                        txtrelleno2.Text = dt.Rows[0][5].ToString();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "No hay Relleno para el Origen Seleccionado...", "Verificacion...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        checkBox2.Checked = false;
                    }

                }
                else
                {
                    //cborelleno2.Enabled = false;
                    //cborelleno2.Text = "Seleccione";
                    txtcantidad2.Enabled = false;
                    txtcantidad2.Text = string.Empty;
                    txtrelleno2.Text = "";

                }
            }
            else
            {
                checkBox2.Checked = false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (cbOrigenDestino.Text != string.Empty && cbOrigenDestino.SelectedValue != null)
            {
                origen = int.Parse(cbOrigenDestino.SelectedValue.ToString());

                FrmDetalleRelevo frmdetallerelevo = new FrmDetalleRelevo();
                DialogResult DR_DetalleRelevo = frmdetallerelevo.ShowDialog();

                if (DR_DetalleRelevo == DialogResult.OK)
                {
                    TxtConsumo.Text = frmdetallerelevo.tanqueo;
                    TxtKilometraje.Text = frmdetallerelevo.kilometraje;
                }
            }
            else
            {
                MessageBox.Show("Seleccione Origen-Destino");
            }
        }

        private void GrillaAsignacionCombustible_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                iniciar();
                pil = copil = 0;             



                int piloto = 0, copiloto = 0, vehiculo = 0;
                DataTable dt = new DataTable();
                dt = Datos_Asignacioncombustible.BuscarPlaca(int.Parse(GrillaAsignacionCombustible.Rows[e.RowIndex].Cells[0].Value.ToString()));

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][5].ToString() == "Piloto")
                    {
                        piloto = int.Parse(dt.Rows[i][2].ToString());
                        pil = piloto;
                    }
                    if (dt.Rows[i][5].ToString() == "Copiloto")
                    {
                        copiloto = int.Parse(dt.Rows[i][2].ToString());
                        copil = copiloto;
                    }
                }
                DataTable dt_temp = Datos_Conductor.BuscarConductorXID(piloto);

                if (dt_temp.Rows.Count > 0)
                {
                    TxtPiloto.Text = dt_temp.Rows[0][3].ToString() + " " + dt_temp.Rows[0][2].ToString();
                }
                else
                {
                    TxtPiloto.Text = string.Empty;
                }
                dt_temp = Datos_Conductor.BuscarConductorXID(copiloto);
                if (dt_temp.Rows.Count > 0)
                {
                    TxtCopiloto.Text = dt_temp.Rows[0][3].ToString() + " " + dt_temp.Rows[0][2].ToString();
                }
                else
                {
                    TxtCopiloto.Text = string.Empty;
                }
                txttelefono.Text = GrillaAsignacionCombustible.Rows[e.RowIndex].Cells[3].Value.ToString();

                vehiculo = int.Parse(GrillaAsignacionCombustible.Rows[e.RowIndex].Cells[6].Value.ToString());



                if (Datos_Relevo.BuscarRelevo(vehiculo).Rows.Count > 0)
                {
                    //TxtConsumo.Enabled = false;
                    //cbOrigenDestino.Enabled = false;
                    BtnRelevo.Enabled = true;
                    TxtKilometraje.Enabled = false;

                    //TxtConsumo.Text = TxtKilometraje.Text = "0";
                }
                else
                {
                    //TxtConsumo.Enabled = true;
                    //cbOrigenDestino.Enabled = true;
                    BtnRelevo.Enabled = false;
                    TxtKilometraje.Enabled =  false;
                    TxtConsumo.Text = TxtKilometraje.Text = "0";
                }

                placa = int.Parse(GrillaAsignacionCombustible.Rows[e.RowIndex].Cells[0].Value.ToString());
                familia = int.Parse(GrillaAsignacionCombustible.Rows[e.RowIndex].Cells[6].Value.ToString());

                //Dt_Tiempo = Datos_Tiempo.BuscarOrigenDestino(IdOrigenDestino);
                //GrillaTiempoRuta.DataSource = Dt_Tiempo;
                //GrillaDetallePorUnidad = Datos_Combustible.MostrarRegistroCombustibleXUnidad(IdUnidadVehicular);
                //GrillaAsignacionCombustible.DataSource = GrillaDetallePorUnidad;

                CargarGrillaDetalle(placa);

            }
            estado_detalle = false;     
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {

            iniciar();
            this.Hide();
        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            frmliquidar.ShowDialog();
        }

        public static int ObtenerOrigen()
        {
            return origen;
        }

        public static int ObtenerPlaca()
        {
            return placa;
        }

        private void cbOrigenDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Estado_CbOrigen == 0)
            {

            }
            else
            {
                if (cbOrigenDestino.Items.Count == 0)
                {

                }
                else
                {
                    DataTable dt = new DataTable();
                    if (cbOrigenDestino.SelectedValue != null)
                    {
                        origen = int.Parse(cbOrigenDestino.SelectedValue.ToString());
                        dt = Datos_Relevo.BuscarRelevo(familia, origen);
                        if (dt.Rows.Count == 0)
                        {
                            dt = Datos_OrigenDestino.BuscarOrigenDestino(origen);
                            txtkilometrajepororigen.Text = dt.Rows[0][8].ToString();
                        }
                        else
                        {
                            txtkilometrajepororigen.Text = "0";
                        }
                    }
                                     
                }
            }
        }

        private void TxtConsumo_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtkilometrajepororigen_TextChanged(object sender, EventArgs e)
        {
            //origendestino = int.Parse(cbOrigenDestino.SelectedValue.ToString());
            //txtkilometrajepororigen.Text = Datos_RellenoCombustible.MostrarKilometrajeXorigenDestino(origendestino).Rows[1].ToString();

        }

        private void txttiempo_TextChanged(object sender, EventArgs e)
        {
            if (txttiempo.TextLength == 5)
            {
                if (txttiempo.Text.IndexOf(':') == -1)
                {
                    MetroMessageBox.Show(this, "El campo tiempo no tiene el formato correcto...", "Verificacion...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                else
                {
                    Calculartiempo(txttiempo.Text);
                }

            }
            else
            {
                txtestadotiempo.Text = "";
            }
            
        }

        private void txtestadogeneral_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtestadotiempo_TextChanged(object sender, EventArgs e)
        {
            if (txtestadotiempo.Text == "MUY BUENO")
            {
                txtestadotiempo.BackColor = System.Drawing.Color.Teal;
               // LblEstado.ForeColor = Color.Red;
                txtestadotiempo.ForeColor = Color.Black;
            

        }
            else if (txtestadotiempo.Text == "BUENO")
            {
                txtestadotiempo.BackColor = System.Drawing.Color.SkyBlue;
            }
            else if (txtestadotiempo.Text == "REGULAR")
            {
                txtestadotiempo.BackColor = System.Drawing.Color.Yellow;
            }
            else if (txtestadotiempo.Text == "MALO")
            {
                txtestadotiempo.BackColor = System.Drawing.Color.Orange;
            }
            else if (txtestadotiempo.Text == "MUY MALO")
            {
                txtestadotiempo.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                txtestadotiempo.BackColor = System.Drawing.Color.White;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (cbOrigenDestino.Text == "Seleccione")
            {
                MessageBox.Show("Seleccione un origen y destino");
            }
            else
            {
                Negocios_Combustible.IdOrigenDestino = origen;
                Negocios_Combustible.IdUnidadVehicular = placa;
                Negocios_Combustible.IdEstadoRutaTiempo = int.Parse(cboestadotiemporuta.SelectedValue.ToString());
                if (txtcantidad1.Text == string.Empty)
                {
                    Negocios_Combustible.Cantidad1 = 0;
                }
                else
                {
                    Negocios_Combustible.Cantidad1 = double.Parse(txtcantidad1.Text);
                }
                if (txtcantidad2.Text == string.Empty)
                {
                    Negocios_Combustible.Cantidad2 = 0;
                }
                else
                {
                    Negocios_Combustible.Cantidad2 = double.Parse(txtcantidad2.Text);
                }
                Negocios_Combustible.PesoBalanza = double.Parse(TxtPesoBalanza.Text);
                Negocios_Combustible.Consumo = double.Parse(Txtconsumocombustible.Text);
                Negocios_Combustible.Tiempo = txttiempo.Text;
                Negocios_Combustible.Observacion = txtobservacion.Text;

                if (TxtPesoBalanza.Text == string.Empty || Txtconsumocombustible.Text == string.Empty || txttiempo.Text == string.Empty)
                {
                    Negocios_Combustible.IdEstadoCombustible = 2;
                }
                else
                {
                    Negocios_Combustible.IdEstadoCombustible = 1;
                }
                Negocios_Combustible.IdUsuario = FrmLogin.ObtenerId();

                string mensaje = null;

                if (estado_detalle)
                {
                    if (FrmLogin.ObtenerId() == user)
                    {
                        Negocios_Combustible.IdCombustible = detalle;
                        mensaje = Datos_Combustible.ModificarCombustible(Negocios_Combustible, pil, copil);
                    }
                    else
                    {
                        MessageBox.Show("No puedes modificar este registro, solo el usuario: " + FrmLogin.ObtenerUsuario() + " puede modificarlo");
                    }
                }
                else
                {
                    mensaje = Datos_Combustible.GuardarCombustible(Negocios_Combustible, pil, copil);
                }
                
                MessageBox.Show(mensaje);

                CargarGrillaDetalle(placa);
            }            
            
        }

        private void txtcantidad1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Txtconsumocombustible_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcantidad1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                if (txtcantidad2.Text == string.Empty)
                {
                    Txtconsumocombustible.Text = txtcantidad1.Text;
                }
                else
                {
                    if (txtcantidad1.Text.IndexOf('.') != -1)
                    {
                        txtcantidad1.Text = txtcantidad1.Text.Replace('.', ',');
                    }                    
                    if (txtcantidad2.Text.IndexOf('.') != -1)
                    {
                        txtcantidad2.Text = txtcantidad2.Text.Replace('.', ',');
                    }

                    Txtconsumocombustible.Text = (double.Parse(txtcantidad1.Text) + double.Parse(txtcantidad2.Text)).ToString();
                }
            }
        }

        private void txtcantidad2_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                if (txtcantidad1.Text.IndexOf('.') != -1)
                {
                    txtcantidad1.Text = txtcantidad1.Text.Replace('.', ',');
                }
                if (txtcantidad2.Text.IndexOf('.') != -1)
                {
                    txtcantidad2.Text = txtcantidad2.Text.Replace('.', ',');
                }

                Txtconsumocombustible.Text = (double.Parse(txtcantidad1.Text) + double.Parse(txtcantidad2.Text)).ToString();
                
            }
        }

        private void TxtPesoBalanza_KeyDown(object sender, KeyEventArgs e)
        {
            double tara = 0,resta = 0;
            if (Keys.Enter == e.KeyCode)
            {
                if (TxtPesoBalanza.Text == string.Empty)
                {
                    txtnumeroguias.Text = string.Empty;
                    MessageBox.Show("Debe digitar una cantidad valida");
                }
                else
                {
                    if (TxtPesoBalanza.Text.IndexOf('.')!=-1)
                    {
                        TxtPesoBalanza.Text = TxtPesoBalanza.Text.Replace('.', ',');
                    }
                    tara = double.Parse(GrillaAsignacionCombustible.CurrentRow.Cells[5].Value.ToString());
                    resta = double.Parse(TxtPesoBalanza.Text) - tara;
                    if (resta > 0)
                    {
                        txtnumeroguias.Text = resta.ToString();
                    }
                    else
                    {
                        resta = resta * -1;
                        txtnumeroguias.Text = resta.ToString();
                    }
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void GrillaDetallePorUnidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            estado_detalle = true;

            DataTable dt_temp, conductores, tipo_conductor;
            dt_temp = new DataTable();
            conductores = new DataTable();

            dt_temp = (DataTable)GrillaDetallePorUnidad.DataSource;
            int fila = e.RowIndex;

            cbOrigenDestino.SelectedValue = int.Parse(dt_temp.Rows[fila][4].ToString());

            conductores = Datos_Combustible.BuscarConductorXCombustible(int.Parse(dt_temp.Rows[fila][0].ToString()));

            TxtPiloto.Text = TxtCopiloto.Text = txtobservacion.Text =  string.Empty;
            for (int i = 0; i < conductores.Rows.Count; i++)
            {
                if (conductores.Rows[i][2].ToString() == "Piloto")
                {
                    tipo_conductor = Datos_Conductor.BuscarConductorXID(int.Parse(conductores.Rows[i][1].ToString()));
                    TxtPiloto.Text = tipo_conductor.Rows[0][3].ToString() + " " + tipo_conductor.Rows[0][2].ToString();
                }
                if (conductores.Rows[i][2].ToString() == "Copiloto")
                {
                    tipo_conductor = Datos_Conductor.BuscarConductorXID(int.Parse(conductores.Rows[i][1].ToString()));
                    TxtCopiloto.Text = tipo_conductor.Rows[0][3].ToString() + " " + tipo_conductor.Rows[0][2].ToString();
                }
            }

            if (double.Parse(dt_temp.Rows[e.RowIndex][6].ToString()) > 0 )
            {
                txtcantidad1.Text = dt_temp.Rows[e.RowIndex][6].ToString();
       
            }
            if (double.Parse(dt_temp.Rows[e.RowIndex][7].ToString()) > 0)
            {
                txtcantidad2.Text = dt_temp.Rows[e.RowIndex][7].ToString();
            }

            TxtPesoBalanza.Text = dt_temp.Rows[e.RowIndex][8].ToString();
            Txtconsumocombustible.Text = dt_temp.Rows[e.RowIndex][9].ToString();
            if (dt_temp.Rows[e.RowIndex][10].ToString() != string.Empty)
            {
                txttiempo.Text = dt_temp.Rows[e.RowIndex][10].ToString();            }

            if (dt_temp.Rows[e.RowIndex][12].ToString() != string.Empty)
            {
                txtobservacion.Text = dt_temp.Rows[e.RowIndex][12].ToString();
            }

            user = int.Parse(GrillaDetallePorUnidad.Rows[e.RowIndex].Cells[14].Value.ToString());
            detalle = int.Parse(GrillaDetallePorUnidad.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void LnkVerificar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbOrigenDestino.Text == "Seleccione")
            {
                MessageBox.Show("Seleccione un ORIGEN-DESTINO");
            }
            else
            {
                if (TxtPesoBalanza.Text == string.Empty || Txtconsumocombustible.Text == string.Empty)
                {
                    MessageBox.Show("Los campos PESO BALANZA y COMSUMO son REQUERIDOS");
                }
                else
                {
                    CalcularGalonaje(double.Parse(TxtPesoBalanza.Text), double.Parse(Txtconsumocombustible.Text));
                }
            }                       
        }
    }
}
