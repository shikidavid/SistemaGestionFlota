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
    public partial class FrmAsignacionPesos : MetroFramework.Forms.MetroForm
    {
        CapaDatos.TipoVehicular Datos_TipoVehicular = new CapaDatos.TipoVehicular();
        CapaDatos.OrigenDestino Datos_OrigenDestino = new CapaDatos.OrigenDestino();
        CapaDatos.AsignacionPesos Datos_AsignacionPesos = new CapaDatos.AsignacionPesos();
        CapaDatos.UnidadVehicular Datos_UnidadVehicular = new CapaDatos.UnidadVehicular();

        CapaNegocios.DTOAsignacionPesos Negocio_AsignacionPesos = new CapaNegocios.DTOAsignacionPesos();

        int origen = 0, familia = 0;
        DataTable Dt_Pesos = new DataTable();
        DataTable Dt_Placas = new DataTable();
        public FrmAsignacionPesos()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Iniciar();
        }

        public void Iniciar()
        {    
            TxtBusqueda_OrigenDestino.Text = string.Empty;
            TxtBusqueda_TipoVehicular.Text = string.Empty;
            txtorigendestino.Text = string.Empty;
            TxtPlacafamilia.Text = string.Empty;
            txtcapacidad.Text = string.Empty;
            txtgalonaje.Text = string.Empty;

            origen = familia = 0;
            CargarGrillaAsignacionPesos();
            CargarGrillaOrigenDestino("");
            CargarGrillaTipoVehicular("");
        }

        public int BuscarExistencia(string capacidad, string galonaje)
        {
            int estado = 0;
            string cap, gal;
            for (int i = 0; i < GrillaAsignacionPeso.Rows.Count; i++)
            {
                cap = GrillaAsignacionPeso.Rows[i].Cells[2].Value.ToString();
                gal = GrillaAsignacionPeso.Rows[i].Cells[3].Value.ToString();
                if (cap == capacidad &&  gal == galonaje)
                {
                    estado = 1;
                }
            }
            return estado;
        }

        public void CargarGrillaTipoVehicular(string tipovehicular)
        {
            GrillaTipoVehicular.DataSource = Datos_TipoVehicular.BuscarTipoVehicular(tipovehicular);
            if (GrillaTipoVehicular.Rows.Count != 0)
            {
                GrillaTipoVehicular.Columns[0].Visible = false;
                GrillaTipoVehicular.Columns[2].Visible = false;
                GrillaTipoVehicular.Columns[3].Visible = false;
            }
        }

        public void CargarGrillaAsignacionPesos()
        {
            DataTable dt = Datos_AsignacionPesos.BuscarPesosXFamiliaXOrigenDestino(familia, origen);
            GrillaAsignacionPeso.DataSource = dt;

            if (dt != null)
            {
                GrillaAsignacionPeso.Columns[0].Visible = false;
                GrillaAsignacionPeso.Columns[1].Visible = false;
            }
            Dt_Pesos = dt;
        }

        public void CargarGrillaOrigenDestino(string origen)
        {
            GrillaListaOrigenDestino.DataSource = Datos_OrigenDestino.BuscarOrigenDestino(origen);
            if (GrillaListaOrigenDestino.Rows.Count != 0)
            {
                GrillaListaOrigenDestino.Columns[0].Visible = false;
                GrillaListaOrigenDestino.Columns[2].Visible = false;
                GrillaListaOrigenDestino.Columns[4].Visible = false;
                GrillaListaOrigenDestino.Columns[6].Visible = false;
                GrillaListaOrigenDestino.Columns[7].Visible = false;
                GrillaListaOrigenDestino.Columns[8].Visible = false;
            }
        }

        private void TxtBusqueda_TipoVehicular_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaTipoVehicular(TxtBusqueda_TipoVehicular.Text);
        }

        private void FrmAsignacionPesos_Load(object sender, EventArgs e)
        {
            CargarGrillaTipoVehicular("");
            CargarGrillaOrigenDestino("");
            CargarGrillaAsignacionPesos();
        }

        private void GrillaTipoVehicular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            familia = int.Parse(GrillaTipoVehicular.CurrentRow.Cells[0].Value.ToString());

            CargarGrillaAsignacionPesos();
            
            TxtPlacafamilia.Text = GrillaTipoVehicular.CurrentRow.Cells[1].Value.ToString();
        }

        private void GrillaListaOrigenDestino_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            origen = int.Parse(GrillaListaOrigenDestino.CurrentRow.Cells[0].Value.ToString());

            CargarGrillaAsignacionPesos();

            txtorigendestino.Text = GrillaListaOrigenDestino.CurrentRow.Cells[5].Value.ToString();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtPlacafamilia.Text == string.Empty)
            {
                MessageBox.Show("Seleccione una familia primero");
            }
            else
            {
                if (txtorigendestino.Text == string.Empty)
                {
                    MessageBox.Show("Seleccione un origen-destino primero");
                }
                else
                {
                    if (txtcapacidad.Text == string.Empty)
                    {
                        MessageBox.Show("El campo capacidad es requerido, por favor verifique");
                    }
                    else
                    {
                        if (txtgalonaje.Text == string.Empty)
                        {
                            MessageBox.Show("El campo galonaje es requerido");
                        }
                        else
                        {
                            if (BuscarExistencia(txtcapacidad.Text,txtgalonaje.Text) == 1)
                            {
                                MessageBox.Show("Ya hay un registro con los mismos datos");
                            }
                            else
                            {
                                Dt_Pesos.Rows.Add(familia, origen, txtcapacidad.Text, txtgalonaje.Text);
                                GrillaAsignacionPeso.DataSource = Dt_Pesos;
                                txtgalonaje.Text = txtcapacidad.Text = "";
                            }                            
                        }
                    }
                }
            }            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (GrillaAsignacionPeso.Rows.Count > 0)
            {
                Dt_Placas = Datos_UnidadVehicular.BuscarUnidadVehicularXFamilia(familia);

                for (int i = 0; i < Dt_Pesos.Rows.Count; i++)
                {
                    Negocio_AsignacionPesos.Capacidad = int.Parse(Dt_Pesos.Rows[i][2].ToString());
                    Negocio_AsignacionPesos.Galonaje = int.Parse(Dt_Pesos.Rows[i][3].ToString());
                    Negocio_AsignacionPesos.IdOrigenDestino = origen;
                    for (int j = 0; j < Dt_Placas.Rows.Count; j++)
                    {
                        Negocio_AsignacionPesos.IdUnidadVehicular = int.Parse(Dt_Placas.Rows[j][0].ToString());
                        Datos_AsignacionPesos.GuardarPesos(Negocio_AsignacionPesos);
                    }
                }
                MetroMessageBox.Show(this, "Datos Guardados Correctamente...", "Registro...", MessageBoxButtons.OK, MessageBoxIcon.Question);
               
                Iniciar();
            }
            else
            {
                MetroMessageBox.Show(this, "No hay Datos para Registrar...", "Sin Registro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }            
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            if (GrillaAsignacionPeso.Rows.Count == 0)
            {
                
                MetroMessageBox.Show(this, "No Hay datos para eliminar...", "Sin Registro...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int fila = GrillaAsignacionPeso.CurrentCell.RowIndex;
                int fam = int.Parse(GrillaAsignacionPeso.Rows[fila].Cells[0].Value.ToString());
                int origen = int.Parse(GrillaAsignacionPeso.Rows[fila].Cells[1].Value.ToString());
                int cap = int.Parse(GrillaAsignacionPeso.Rows[fila].Cells[2].Value.ToString());
                int gal = int.Parse(GrillaAsignacionPeso.Rows[fila].Cells[3].Value.ToString());
                DialogResult result = MessageBox.Show("¿Esta Seguro que desea eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            Negocio_AsignacionPesos.IdUnidadVehicular = fam;
                            Negocio_AsignacionPesos.IdOrigenDestino = origen;
                            Negocio_AsignacionPesos.Capacidad = cap;
                            Negocio_AsignacionPesos.Galonaje = gal;
                            int estado = Datos_AsignacionPesos.LiberarAsignacion(Negocio_AsignacionPesos);

                            if (estado > 0)
                            {
                                GrillaAsignacionPeso.Rows.RemoveAt(fila);

                                MessageBox.Show("Registros Eliminados Correctamente");
                            }
                            else
                            {
                                MessageBox.Show("El Registro no fue Eliminado");
                            }
                            break;
                        }
                    case DialogResult.No:
                        {
                            break;
                        }
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void TxtBusqueda_OrigenDestino_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaOrigenDestino(TxtBusqueda_OrigenDestino.Text);
        }
    }
}
