using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace CapaPresentacion
{
    public partial class FrmTiempos : MetroFramework.Forms.MetroForm
    {
        CapaDatos.OrigenDestino Datos_OrigenDestino = new CapaDatos.OrigenDestino();
        CapaDatos.EstadoTiempo Datos_EstadoTiempo = new CapaDatos.EstadoTiempo();
        CapaDatos.Tiempo Datos_Tiempo = new CapaDatos.Tiempo();
        CapaNegocios.DtoOrigenDestino Negocios_OrigenDestino = new CapaNegocios.DtoOrigenDestino();        
        CapaNegocios.DTOEstadoTiempo Negocio_EstadoTiempo = new CapaNegocios.DTOEstadoTiempo();
        CapaNegocios.DTOTiempos Negocio_Tiempo = new CapaNegocios.DTOTiempos();

        DataTable Dt_Tiempo = new DataTable();
        int IdOrigenDestino = 0;

        public FrmTiempos()
        {
            InitializeComponent();
        }

        public void Iniciar()
        {
            CargarGrillaOrigenDestino();
            //CargarGrillaTiempoRuta();
            CargarComboTiempo();
            GrillaTiempoRuta.DataSource = null;
            TxtBusqueda.Text = TxtTiempo.Text = TxtCodigo.Text = TxtOrigenDestino.Text = string.Empty;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        public void OcultarCabeceraGrillTiempoRuta()
        {
            GrillaTiempoRuta.Columns[0].Visible = false;
            GrillaTiempoRuta.Columns[1].Visible = false;
            GrillaTiempoRuta.Columns[3].Visible = false;
            GrillaTiempoRuta.Columns[4].Visible = false;
            GrillaTiempoRuta.Columns[5].Visible = false;
        }

        public void AgregarFilaTiempo()
        {
            if (TxtTiempo.Text.IndexOf(':') == -1 || TxtTiempo.Text.Length < 5)
            {
                MetroMessageBox.Show(this, "El Campo Tiempo Tiene un Formato invalido!...", "Por favor Verifique...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }
            else
            {
                Dt_Tiempo.Rows.Add(IdOrigenDestino, CboEstadoTiempo.SelectedValue, TxtTiempo.Text, 1, DateTime.Today, CboEstadoTiempo.SelectedValue, CboEstadoTiempo.Text,TxtOrigenDestino.Text);
                GrillaTiempoRuta.DataSource = Dt_Tiempo;
                TxtTiempo.Text = String.Empty;
            }
            
        }

        public void CargarGrillaOrigenDestino()
        {
            //GrillaTiempoRuta.DataSource = Datos_Tiempo.MostrarTiempos ();
            GrillaOrigenDestino.DataSource = Datos_OrigenDestino.MostrarOrigenDestino();
            GrillaOrigenDestino.Columns[0].Visible = false;
            GrillaOrigenDestino.Columns[2].Visible = false;
            GrillaOrigenDestino.Columns[4].Visible = false;
            //GrillaOrigenDestino.Columns[7].Visible = false;
        }

        public void CargarGrillaTiempoRuta()
        {
            GrillaTiempoRuta.DataSource = Datos_Tiempo.MostrarTiempos();
            GrillaOrigenDestino.DataSource = Datos_OrigenDestino.MostrarOrigenDestino();
            GrillaTiempoRuta.Columns[0].Visible = false;
            GrillaTiempoRuta.Columns[1].Visible = false;
            GrillaOrigenDestino.Columns[2].Visible = false;
            GrillaOrigenDestino.Columns[4].Visible = false;
            GrillaOrigenDestino.Columns[7].Visible = false;
        }

        public void CargarComboTiempo()
        {
            CboEstadoTiempo.DataSource = Datos_EstadoTiempo.Mostrar();
            CboEstadoTiempo.ValueMember = "IdEstadoTiempo";
            CboEstadoTiempo.DisplayMember = "EstadoTiempo";
        }

        public void CargarGrillaTiempoRuta(int OrigenDestino)
        {
            GrillaTiempoRuta.DataSource = Datos_Tiempo.BuscarOrigenDestino(OrigenDestino);
        }

        public int VerificarEstado(String estado)
        {
            int count_estado = 0;
            for (int i = 0; i < GrillaTiempoRuta.Rows.Count; i++)
            {
                if (GrillaTiempoRuta.Rows[i].Cells[6].Value.ToString() == estado)
                {
                    count_estado++;
                }
            }
            return count_estado;
        } 

        private void FrmTiempos_Load(object sender, EventArgs e)
        {
            Iniciar();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GrillaOrigenDestino.DataSource = Datos_OrigenDestino.BuscarOrigenDestinoXOrigenDestino(TxtBusqueda.Text);
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GrillaOrigenDestino.DataSource = Datos_OrigenDestino.BuscarOrigenDestinoXOrigenDestino(TxtBusqueda.Text);
        }

        private void GrillaOrigenDestino_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GrillaOrigenDestino_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                TxtOrigenDestino.Text = GrillaOrigenDestino.Rows[e.RowIndex].Cells[5].Value.ToString();

                IdOrigenDestino = int.Parse(GrillaOrigenDestino.Rows[e.RowIndex].Cells[0].Value.ToString());

                Dt_Tiempo = Datos_Tiempo.BuscarOrigenDestino(IdOrigenDestino);
                GrillaTiempoRuta.DataSource = Dt_Tiempo;
                OcultarCabeceraGrillTiempoRuta();
                
                
            }
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (TxtTiempo.Text == "")
            {
                MetroMessageBox.Show(this, "El campo tiempo es requerido...", "Seleccione...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("El campo tiempo es requerido");
            }
            else
            {
                if (VerificarEstado("MUY BUENO") == 0 && CboEstadoTiempo.Text == "MUY BUENO")
                {
                    AgregarFilaTiempo();
                }
                else
                {
                    if (VerificarEstado("BUENO") == 0 && CboEstadoTiempo.Text == "BUENO")
                    {
                        AgregarFilaTiempo();
                    }
                    else
                    {
                        if (VerificarEstado("REGULAR") == 0 && CboEstadoTiempo.Text == "REGULAR")
                        {
                            AgregarFilaTiempo();
                        }
                        else
                        {
                            if (VerificarEstado("MALO") == 0 && CboEstadoTiempo.Text == "MALO")
                            {
                                AgregarFilaTiempo();
                            }
                            else
                            {
                                if (VerificarEstado("MUY MALO") == 0 && CboEstadoTiempo.Text == "MUY MALO")
                                {
                                    AgregarFilaTiempo();
                                }
                                else
                                {
                                   
                                    MetroMessageBox.Show(this, "Ya se ha asignado el estado...", "por favor verifique...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            if (GrillaTiempoRuta.Rows.Count == 0)
            {
                MetroMessageBox.Show(this, "No hay Registros en la Grilla...", "por favor verifique...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                int fila = GrillaTiempoRuta.CurrentCell.RowIndex;
                int idasignacion = int.Parse(GrillaTiempoRuta.Rows[fila].Cells[0].Value.ToString());
                int idestadotiempo = int.Parse(GrillaTiempoRuta.Rows[fila].Cells[5].Value.ToString());
                DialogResult result = MessageBox.Show("¿Esta Seguro que desea eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            Datos_Tiempo.LiberarTiempoOrigenDestino(idasignacion, idestadotiempo);
                            GrillaTiempoRuta.Rows.RemoveAt(fila);
                            break;
                        }
                    case DialogResult.No:
                        {
                            break;
                        }
                }
            }
            //CargarGrillaTiempoRuta(idasignacion);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (GrillaTiempoRuta.Rows.Count == 0)
            {
                MetroMessageBox.Show(this, "No hay Elemntos que guardar...", "por favor verifique...", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
            else
            {
                int id = 0, estado_tiempo = 0;       
                for (int i = 0; i < GrillaTiempoRuta.Rows.Count; i++)
                {
                    id = int.Parse(GrillaTiempoRuta.Rows[i].Cells[0].Value.ToString());
                    estado_tiempo = int.Parse(GrillaTiempoRuta.Rows[i].Cells[5].Value.ToString());

                    if (Datos_Tiempo.BuscarExistencia(id,estado_tiempo).Rows.Count == 0)
                    {
                        Negocio_Tiempo.IdOrigenDestino = int.Parse(GrillaTiempoRuta.Rows[i].Cells[0].Value.ToString());
                        Negocio_Tiempo.IdEstadoTiempo = int.Parse(GrillaTiempoRuta.Rows[i].Cells[1].Value.ToString());
                        Negocio_Tiempo.Tiempo = GrillaTiempoRuta.Rows[i].Cells[2].Value.ToString();
                        Datos_Tiempo.GuardarTiempo(Negocio_Tiempo);
                    }                   
                    
                }
                MetroMessageBox.Show(this, "Datos Guardados Correctamente!...", "Informacion...", MessageBoxButtons.OK, MessageBoxIcon.Question);
               
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TxtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MetroMessageBox.Show(this, "Solo se permite letra...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
                e.Handled = true;
                return;
            }
        }
    }
}
