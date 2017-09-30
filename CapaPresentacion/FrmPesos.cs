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
    public partial class FrmPesos : MetroFramework.Forms.MetroForm
    {
        CapaDatos.OrigenDestino Datos_OrigenDestino = new CapaDatos.OrigenDestino();
        CapaDatos.UnidadVehicular Datos_UnidadVehicular = new CapaDatos.UnidadVehicular();
        CapaDatos.AsignacionPesos Datos_AsignacionPesos = new CapaDatos.AsignacionPesos();

        CapaNegocios.DTOAsignacionPesos Negocios_AsignacionPesos = new CapaNegocios.DTOAsignacionPesos();

        bool Estado_CbFamilia = false;

        int IdOrigenDestino,idunidadvehicular, capacidad, galonaje;
        string placa,concatenacion;

        DataTable dt_Asignacion_Pesos = new DataTable();

        public FrmPesos()
        {
            InitializeComponent();
        }
        public void Iniciarr()
        {
            CargarGrillaOrigenDestino();
            //CargarGrillaTiempoRuta();
            //CargarGrillaUnidadVehicular();
            //CargarComboTiempo();
            GrillaasignacionPeso.DataSource = null;
            TxtBusqueda.Text = TxtPlacafamilia.Text = TxtCodigo.Text = txtorigendestino.Text = txtcapacidad.Text = txtgalonaje.Text = string.Empty;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciarr();
            this.Hide();
        }

        public void CargarGrillaPesos()
        {
            dt_Asignacion_Pesos = Datos_AsignacionPesos.BuscarPesosXFamiliaXOrigenDestino(int.Parse(CbFamilia.SelectedValue.ToString()), IdOrigenDestino);
            GrillaasignacionPeso.DataSource = dt_Asignacion_Pesos;
            GrillaasignacionPeso.Columns[0].Visible = false;
            GrillaasignacionPeso.Columns[1].Visible = false;
        }

        public void CargarComboFanmilia()
        {
            CbFamilia.DataSource = Datos_UnidadVehicular.MostrarTipoVehicular();
            CbFamilia.ValueMember = "IdTipoVehiculo";
            CbFamilia.DisplayMember = "TipoVehicular";
            Estado_CbFamilia = true;
        }

        public void CargarGrillaOrigenDestino()
        {
            GrillaListaOrigenDestino.DataSource = Datos_OrigenDestino.MostrarOrigenDestino();
            GrillaListaOrigenDestino.Columns[0].Visible = false;
            GrillaListaOrigenDestino.Columns[2].Visible = false;
            GrillaListaOrigenDestino.Columns[4].Visible = false;
            GrillaListaOrigenDestino.Columns[7].Visible = false;
            GrillaListaOrigenDestino.Columns[8].Visible = false;
        }

        public void CargarGrillaUnidadVehicular(DataTable Grilla)
        {
            if (Estado_CbFamilia)
            {
                GrillaFamiliaPlaca.DataSource = Grilla;                
            }
            if (Grilla != null)
            {
                GrillaFamiliaPlaca.Columns[0].Visible = false;
                GrillaFamiliaPlaca.Columns[4].Visible = false;
                GrillaFamiliaPlaca.Columns[5].Visible = false;
            }
        }

        public void Iniciar()
        {
            CargarGrillaOrigenDestino();
            CargarComboFanmilia();
            Chk_Placa.Checked = false;
            TxtBusqueda.Enabled = false;
            //CargarCabeceraPesos();
        }

        private void FrmPesos_Load(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void CbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Estado_CbFamilia)
            {
                CargarGrillaUnidadVehicular(Datos_UnidadVehicular.BuscarUnidadVehicularXFamilia(int.Parse(CbFamilia.SelectedValue.ToString())));
                CargarGrillaPesos();
            }            
        }

        private void Chk_Placa_CheckedChanged(object sender, EventArgs e)
        {
            GrillaFamiliaPlaca.DataSource = null;
            if (Chk_Placa.Checked)
            {
                CbFamilia.Enabled = false;
                TxtBusqueda.Enabled = true;
                TxtBusqueda.Text = string.Empty;
                ChkAsignacionFamiliar.Checked = false;            
            }
            else
            {
                CbFamilia.Enabled = true;
                TxtBusqueda.Enabled = false;
                TxtBusqueda.Text = string.Empty;
                CargarGrillaUnidadVehicular(null);
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (Chk_Placa.Enabled)
            {
                CargarGrillaUnidadVehicular(Datos_UnidadVehicular.BuscarUnidadVehicularXPlaca(TxtBusqueda.Text));
                if (GrillaFamiliaPlaca.Rows.Count > 0)
                {
                    dt_Asignacion_Pesos = Datos_AsignacionPesos.BuscarPesosXPlacaXOrigenDestino(GrillaFamiliaPlaca.Rows[0].Cells[1].Value.ToString(), IdOrigenDestino);
                    GrillaasignacionPeso.DataSource = dt_Asignacion_Pesos;
                    GrillaasignacionPeso.Columns[0].Visible = false;
                    GrillaasignacionPeso.Columns[1].Visible = false;
                }               
            }
            else
            {
                CargarGrillaUnidadVehicular(null);
            }
        }

        private void ChkAsignacionFamiliar_CheckedChanged(object sender, EventArgs e)
        {            
            if (ChkAsignacionFamiliar.Checked)
            {
                if (GrillaFamiliaPlaca.Rows.Count == 0)
                {
                    MessageBox.Show("No hay Informacion filtrada, Por favor Verifique!");
                    ChkAsignacionFamiliar.Checked = false;                 
                }
                else
                {
                    if (!CbFamilia.Enabled)
                    {
                        MessageBox.Show("El Combo Familia esta desactivado, Por Favor Verifique!");
                        ChkAsignacionFamiliar.Checked = false;
                    }
                    else
                    {
                        TxtPlacafamilia.Text = CbFamilia.Text;
                    }
                }
            }
            else
            {
                TxtPlacafamilia.Text = string.Empty;
            }
        }

        private void TxtBusqueda_OrigenDestino_TextChanged(object sender, EventArgs e)
        {
            GrillaListaOrigenDestino.DataSource = Datos_OrigenDestino.BuscarOrigenDestino(TxtBusqueda_OrigenDestino.Text);
        }

        private void GrillaListaOrigenDestino_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                        
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            int fila = GrillaasignacionPeso.CurrentCell.RowIndex;
            int unidad = int.Parse(GrillaasignacionPeso.Rows[fila].Cells[0].Value.ToString());
            int origen = int.Parse(GrillaasignacionPeso.Rows[fila].Cells[1].Value.ToString());
            int cap = int.Parse(GrillaasignacionPeso.Rows[fila].Cells[4].Value.ToString());
            int gal = int.Parse(GrillaasignacionPeso.Rows[fila].Cells[5].Value.ToString());
            DialogResult result = MessageBox.Show("¿Esta Seguro que desea eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        Negocios_AsignacionPesos.IdUnidadVehicular = unidad;
                        Negocios_AsignacionPesos.IdOrigenDestino = origen;
                        Negocios_AsignacionPesos.Capacidad = cap;
                        Negocios_AsignacionPesos.Galonaje = gal;
                        int estado = Datos_AsignacionPesos.LiberarAsignacion(Negocios_AsignacionPesos);

                        if (estado > 0)
                        {
                            GrillaasignacionPeso.Rows.RemoveAt(fila);
                            
                            MessageBox.Show("Tripulante Eliminado Correctamente");
                        }
                        else
                        {
                            MessageBox.Show("El Tripulante no fue Eliminado");
                        }
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
            }
        }

        private void GrillaListaOrigenDestino_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                IdOrigenDestino = int.Parse(GrillaListaOrigenDestino.Rows[e.RowIndex].Cells[0].Value.ToString());
                concatenacion = GrillaListaOrigenDestino.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtorigendestino.Text = GrillaListaOrigenDestino.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (CbFamilia.Enabled)
                {
                    CargarGrillaPesos();
                }
                else
                {
                    if (GrillaFamiliaPlaca.Rows.Count > 0)
                    {
                        dt_Asignacion_Pesos = Datos_AsignacionPesos.BuscarPesosXPlacaXOrigenDestino(GrillaFamiliaPlaca.Rows[0].Cells[1].Value.ToString(), IdOrigenDestino);
                        GrillaasignacionPeso.DataSource = dt_Asignacion_Pesos;
                        GrillaasignacionPeso.Columns[0].Visible = false;
                        GrillaasignacionPeso.Columns[1].Visible = false;
                    }                    
                }
            }            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GrillaasignacionPeso.Rows.Count; i++)
            {
                idunidadvehicular = int.Parse(GrillaasignacionPeso.Rows[i].Cells[0].Value.ToString());
                IdOrigenDestino = int.Parse(GrillaasignacionPeso.Rows[i].Cells[1].Value.ToString());
                capacidad = int.Parse(GrillaasignacionPeso.Rows[i].Cells[4].Value.ToString());
                galonaje = int.Parse(GrillaasignacionPeso.Rows[i].Cells[5].Value.ToString());

                Negocios_AsignacionPesos.IdUnidadVehicular = idunidadvehicular;
                Negocios_AsignacionPesos.IdOrigenDestino = IdOrigenDestino;
                Negocios_AsignacionPesos.Capacidad = capacidad;
                Negocios_AsignacionPesos.Galonaje = galonaje;

                if (Datos_AsignacionPesos.BuscarExistencia(Negocios_AsignacionPesos).Rows.Count == 0)
                {
                    Datos_AsignacionPesos.GuardarPesos(Negocios_AsignacionPesos);
                }
            }
            dt_Asignacion_Pesos = null;
            GrillaasignacionPeso.DataSource = dt_Asignacion_Pesos;
            MessageBox.Show("Datos Guardados Correctamete");
        }

        private void GrillaFamiliaPlaca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dt_Asignacion_Pesos = Datos_AsignacionPesos.BuscarPesosXPlacaXOrigenDestino(GrillaFamiliaPlaca.Rows[e.RowIndex].Cells[1].Value.ToString(), IdOrigenDestino);
            //GrillaasignacionPeso.DataSource = dt_Asignacion_Pesos;
            //GrillaasignacionPeso.Columns[0].Visible = false;
            //GrillaasignacionPeso.Columns[1].Visible = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtcapacidad.Text == string.Empty)
            {
                MessageBox.Show("El Campo Capacidad es Requerido, Por Favor Verifique!");
            }
            else
            {
                if (txtgalonaje.Text == string.Empty)
                {
                    MessageBox.Show("El Campo Galonaje es Requerido, Por Favor Verifique!");
                }
                else
                {
                    if (GrillaFamiliaPlaca.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay Ninguna placa en la grilla, Por favor Verifique");
                    }
                    else
                    {
                        if (TxtBusqueda.Text != string.Empty)
                        {
                            if (GrillaFamiliaPlaca.Rows.Count != 0)
                            {
                                if (GrillaFamiliaPlaca.Rows.Count > 1)
                                {
                                    MessageBox.Show("Hay muchas placas en la grilla si Ud. desea agregar por familia desactive la opcion por placa e intente de nuevo");
                                }
                                else
                                {
                                    idunidadvehicular = int.Parse(GrillaFamiliaPlaca.Rows[0].Cells[0].Value.ToString());
                                    placa = GrillaFamiliaPlaca.Rows[0].Cells[1].Value.ToString();
                                    dt_Asignacion_Pesos.Rows.Add(idunidadvehicular, IdOrigenDestino, placa, concatenacion, txtcapacidad.Text, txtgalonaje.Text);
                                    GrillaasignacionPeso.DataSource = dt_Asignacion_Pesos;
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("No hay placas para agregar");
                            }
                        }
                        else
                        {
                            //registro por familia
                        }
                    }
                }
            }
        }
    }
}
