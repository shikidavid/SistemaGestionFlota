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
using System.Data;
using CapaNegocios;
using MetroFramework;

namespace CapaPresentacion
{
    public partial class FrmAsignacionCombustible : MetroFramework.Forms.MetroForm
    {
        CapaDatos.AsignacionCombustible Datos_Asignacion = new CapaDatos.AsignacionCombustible();
        CapaDatos.ListarPlaca Datos_ListarPlaca = new CapaDatos.ListarPlaca();
        CapaDatos.TipoConductor Datos_TipoConductor = new CapaDatos.TipoConductor();
        CapaDatos.ListarConductoreActivos Datos_Conductor = new CapaDatos.ListarConductoreActivos();
        CapaNegocios.DTOAsignacionCombustible Negocios_Asignacion;
        DataTable Asignacion = new DataTable();

        int estado;
        char acction;
        int id_placa;
        int id_conductor;
        int id_TipoConductor;
        int id_asignacion;
        int nuevo_codigo_asignacion;
        int filas;
        int count_conductor = 0;

        public FrmAsignacionCombustible()
        {
            InitializeComponent();
            GrillaPlaca.DataSource = Datos_ListarPlaca.MostrarListaPlacaTodo();
            GrillaConductor.DataSource = Datos_Conductor.MostrarListaConductoresTodo();

        }
        public void Iniciar()
        {

            //CargarGrillaTiempoRuta();
            //CargarGrillaUnidadVehicular();
            //CargarComboTiempo();
           
            GrillaAsignacion.DataSource = null;
            TxtBuscarPlaca.Text = TxtPlaca.Text = TxtCodigo.Text = TxtBuscar.Text  = TxtBuscarPlaca.Text= txtBuscarConductor.Text= string.Empty;
        }

        public int VerificarPiloto()
        {
            int cantidad = GrillaAsignacion.Rows.Count;
            int count_piloto = 0;
            for (int i = 0; i < cantidad; i++)
            {
                if (int.Parse(GrillaAsignacion.Rows[i].Cells[4].Value.ToString()) == 2)
                {
                    count_piloto++;
                }                               
            }
            return count_piloto;                 
        }

        public int VerificarCopiloto()
        {
            int cantidad = GrillaAsignacion.Rows.Count;
            int count_copiloto = 0;
            for (int i = 0; i < cantidad; i++)
            {
                if (int.Parse(GrillaAsignacion.Rows[i].Cells[4].Value.ToString()) == 3)
                {
                    count_copiloto++;
                }
            }
            return count_copiloto;
        }

        public bool VerificarConductor(int codigo_conductor)
        {
            
            if (GrillaAsignacion.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                int codigo = int.Parse(GrillaAsignacion.Rows[0].Cells[2].Value.ToString());
                if (codigo != codigo_conductor)
                {
                    return true;           
                }
                else
                {
                    return false;
                }
            } 
        }

        public void OcultarCabeceraAsignacion()
        {
            GrillaAsignacion.Columns[0].Visible = false;
            GrillaAsignacion.Columns[2].Visible = false;
            GrillaAsignacion.Columns[4].Visible = false;
            GrillaAsignacion.Columns[6].Visible = false;
            GrillaAsignacion.Columns[7].Visible = false;
            //GrillaAsignacion.Columns[8].Visible = false;
        }
        public void CargarGrillaPlaca(String buscar)
        {

            GrillaPlaca.DataSource = Datos_ListarPlaca.MostrarListaPlaca(buscar);
            GrillaPlaca.Columns[2].Visible = false;
            GrillaPlaca.Columns[1].Visible = false;
        }
        
        public void CargarGrillaConductor(String buscar)
        {
            GrillaConductor.DataSource = Datos_Conductor.BuscarConductoresXApellido(buscar);
            GrillaConductor.Columns[0].Visible = false;
        }

        public void CargarGrillaConductorXDNI(String dni)
        {
            GrillaConductor.DataSource = Datos_Conductor.BuscarConductoresXDNI(dni);
            GrillaConductor.Columns[0].Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmListaPlacas f = new FrmListaPlacas();
            f.ShowDialog(this);
            //this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FrmAsignacionCombustible_Load(object sender, EventArgs e)
        {
            CboTipoConductor.DataSource = Datos_TipoConductor.MostrarTipoConductor();
            CboTipoConductor.DisplayMember = "TipoConductor";
            CboTipoConductor.ValueMember = "IdTipoConductor";
            CargarGrillaPlaca("");
            CargarGrillaConductor("");
            TxtNumero.SelectedIndex = 1;
            if (GrillaConductor.Rows.Count == 0)
            {
                MetroMessageBox.Show(this, "No hay conductores disponibles, por favor si hay unidades que hicieron sus rutas libere el estado de los conductores...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmListarConductoresActivos f = new FrmListarConductoresActivos();
            f.ShowDialog(this);
        }

        private void CboTipoConductor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaPlaca(TxtBuscarPlaca.Text);
        }

        private void GrillaDepartamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_asignacion = int.Parse(GrillaPlaca.Rows[e.RowIndex].Cells[2].Value.ToString());
                TxtPlaca.Text = GrillaPlaca.Rows[e.RowIndex].Cells[0].Value.ToString();
                id_placa = Convert.ToInt32(GrillaPlaca.Rows[e.RowIndex].Cells[2].Value.ToString());
                Asignacion = Datos_Asignacion.BuscarPlaca(id_asignacion);
                GrillaAsignacion.DataSource = Asignacion;
                OcultarCabeceraAsignacion();
            }
        }

        private void GrillaConductor_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void GrillaConductor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre, apellido;
            nombre = GrillaConductor.Rows[e.RowIndex].Cells[2].Value.ToString();
            apellido = GrillaConductor.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtBuscar.Text = nombre + " " + apellido;
            id_conductor = Convert.ToInt32(GrillaConductor.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void txtBuscarConductor_TextChanged(object sender, EventArgs e)
        {
            if (RB_DNI.Checked)
            {                
                CargarGrillaConductorXDNI(txtBuscarConductor.Text);
            }
            if (RB_Apellido.Checked)
            {
                CargarGrillaConductor(txtBuscarConductor.Text);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CboTipoConductor.SelectedIndex != 0)
            {                
                if (GrillaAsignacion.DataSource == null)
                {
                    MetroMessageBox.Show(this, "Selecciones una placa primero para podeser asignar tripulante...", "Verificacion...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                }
                else
                {
                    if (TxtBuscar.Text == "")
                    {
                        MetroMessageBox.Show(this, "Seleccione un conductor para poder asignarlo...", "Verificacion...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     
                    }
                    else
                    {
                        if (GrillaAsignacion.Rows.Count == 2)
                        {
                            MetroMessageBox.Show(this, "Ya se han asignado tripulantes, elimine algun tripulante para poder asignar al conductor seleccionado...", "Proceso...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                        else
                        {
                            if (VerificarPiloto() == 1 && CboTipoConductor.SelectedIndex == 1)
                            {
                                MetroMessageBox.Show(this, "Ya Hay un piloto asignado, eliminelo primero...", "Proceso...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                
                            }
                            else
                            {
                                if (VerificarCopiloto() == 1 && CboTipoConductor.SelectedIndex == 2)
                                {
                                    MetroMessageBox.Show(this, "Ya Hay un copiloto asignado, eliminelo primero...", "Proceso...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                
                                }
                                else
                                {
                                    if (VerificarConductor(id_conductor))
                                    {
                                        //nuevo_codigo_asignacion = int.Parse(Datos_Asignacion.BuscarId().Rows[0][0].ToString()) + 1;
                                        //Asignacion.Rows.Add(id_placa, TxtPlaca.Text, id_conductor, TxtBuscar.Text, 1, "piloto");
                                        //GrillaAsignacion.DataSource = Asignacion;
                                        Asignacion.Rows.Add(id_placa, TxtPlaca.Text, id_conductor, TxtBuscar.Text, CboTipoConductor.SelectedValue, CboTipoConductor.Text, DateTime.Today.ToString(), 1);
                                        //GrillaAsignacion.Rows.Add(nuevo_codigo_asignacion, id_placa, TxtPlaca.Text, id_conductor, TxtBuscar.Text, CboTipoConductor.SelectedValue,CboTipoConductor.SelectedText, DateTime.Today.ToString(), 1);
                                        GrillaAsignacion.DataSource = Asignacion;
                                    }
                                    else
                                    {
                                        MetroMessageBox.Show(this, "El conductor seleccionado ya esta asignado, por favor seleccione otro conductor...", "Proceso...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                      
                                    }
                                }
                            }
                            
                        }                        
                    }                    
                }                    
            }
        }

        private void GrillaConductor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RB_Apellido_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool estado = false;
            
            if (GrillaAsignacion.Rows.Count != 0)
            {
                int vehiculo = 0, conductor = 0,asignacion = 0;
                Negocios_Asignacion = new DTOAsignacionCombustible();                
                
                for (int i = 0; i < GrillaAsignacion.Rows.Count; i++)
                {
                    vehiculo = int.Parse(GrillaAsignacion.Rows[i].Cells[0].Value.ToString());
                    conductor = int.Parse(GrillaAsignacion.Rows[i].Cells[2].Value.ToString());

                    if (Datos_Asignacion.BuscarExistencia(vehiculo,conductor).Rows.Count == 0)
                    {
                        //Negocios_Asignacion.IdAsignacionCombustible = int.Parse(GrillaAsignacion.Rows[i].Cells[0].Value.ToString());
                        Negocios_Asignacion.IdUnidadVehicular = int.Parse(GrillaAsignacion.Rows[i].Cells[0].Value.ToString());
                        Negocios_Asignacion.IdConductor = int.Parse(GrillaAsignacion.Rows[i].Cells[2].Value.ToString());
                        Negocios_Asignacion.IdTipoConductor = int.Parse(GrillaAsignacion.Rows[i].Cells[4].Value.ToString());
                        Datos_Asignacion.GuardarAsignacion(Negocios_Asignacion);                        
                    }                    
                }
                MessageBox.Show("Asignacion Registrada Correctamente");
                CargarGrillaConductor("");
                Asignacion.Rows.Clear();
                GrillaAsignacion.DataSource = Asignacion;                
            }
            else
            {
                MessageBox.Show("No hay informacion que guardar, por favor verifique los datos.");
            }

            
        }

        private void GrillaPlaca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtNumero_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtNumero_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int fila = GrillaAsignacion.CurrentCell.RowIndex;
            int conductor = int.Parse(GrillaAsignacion.Rows[fila].Cells[2].Value.ToString());
            int vehiculo= int.Parse(GrillaAsignacion.Rows[fila].Cells[0].Value.ToString());
            
            DialogResult result = MessageBox.Show("¿Esta Seguro que desea eliminar el tripulante?", "Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        int estado = Datos_Asignacion.LiberarConductor(conductor, vehiculo);

                        if (estado > 0)
                        {
                            GrillaAsignacion.Rows.RemoveAt(fila);
                            CargarGrillaConductor("");
                            MessageBox.Show("Tripulante Eliminado Correctamente");
                        }
                        else
                        {
                            CargarGrillaConductor("");
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (GrillaAsignacion.DataSource != null)
            {
                for (int i = 0; i < GrillaAsignacion.Rows.Count; i++)
                {
                    int id_vehi = int.Parse(GrillaAsignacion.Rows[i].Cells[0].Value.ToString());
                    int id_cond = int.Parse(GrillaAsignacion.Rows[i].Cells[2].Value.ToString());

                    Negocios_Asignacion = new DTOAsignacionCombustible();
                    Negocios_Asignacion.IdUnidadVehicular = id_vehi;
                    Negocios_Asignacion.IdConductor = id_cond;

                    Datos_Asignacion = new CapaDatos.AsignacionCombustible();
                    Datos_Asignacion.LiberarConductor(id_cond, id_vehi);
                }

                CargarGrillaConductor("");
                Asignacion.Rows.Clear();
                GrillaAsignacion.DataSource = Asignacion;
            }
            else
            {
                MessageBox.Show("No se ha Seleccionado ninguna unidad");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtBuscarPlaca_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaPlaca(TxtBuscarPlaca.Text);
        }
    }
}
