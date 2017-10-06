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
    public partial class FrmRegistroRelevo : MetroFramework.Forms.MetroForm
    {
        CapaDatos.TipoVehicular Datos_TipoVehicular = new CapaDatos.TipoVehicular();
        CapaDatos.OrigenDestino Datos_OrigenDestino = new CapaDatos.OrigenDestino();
        CapaDatos.Relevo Datos_Relevo = new CapaDatos.Relevo();

        CapaNegocios.DTORelevos Negocios_Relevo = new CapaNegocios.DTORelevos();

        DataTable Dt_Relevo = new DataTable();

        int IdTipoVehiculo = 0;
        int IdOrigenDestino = 0;

        public FrmRegistroRelevo()
        {
            InitializeComponent();
            Iniciar();
        }
        public void Iniciar()
        {
            TxtTipo.Text = "";
            TxtRelevo.Text = "";
            GrillaRelevo.Text = "";
            TxtOrigen.Text = "";
            TxtOrigenDestino.Text = "";
            CargarGrillaTipoVehicular("");
            CargarGrillaOrigenDestino("");
            CargarGrillaRelevo(null);
        }

        public void CargarGrillaTipoVehicular(string Tipo)
        {
            GrillaTipoVehicular.DataSource = Datos_TipoVehicular.BuscarTipoVehicular(Tipo);
            GrillaTipoVehicular.Columns[0].Visible = false;
            GrillaTipoVehicular.Columns[3].Visible = false;
        }

        public void CargarGrillaOrigenDestino(string origen)
        {
            GrillaOrigenDestino.DataSource = Datos_OrigenDestino.BuscarOrigenDestino(origen);
            GrillaOrigenDestino.Columns[0].Visible = false;
            GrillaOrigenDestino.Columns[2].Visible = false;
            GrillaOrigenDestino.Columns[4].Visible = false;
            GrillaOrigenDestino.Columns[7].Visible = false;
        }

        public void CargarGrillaRelevo(DataTable Datos)
        {
            Dt_Relevo = Datos;
            GrillaRelevo.DataSource = Dt_Relevo;
            if (Datos != null)
            {               
                GrillaRelevo.Columns[0].Visible = false;
                GrillaRelevo.Columns[1].Visible = false;
                GrillaRelevo.Columns[2].Visible = false;
                GrillaRelevo.Columns[4].Visible = false;
            }           
        }

        public int BuscarCoicidencia(string relevo)
        {
            int count = 0;
            for (int i = 0; i < GrillaRelevo.Rows.Count; i++)
            {
                if (GrillaRelevo.Rows[i].Cells[3].Value.ToString() == relevo)
                {
                    count++;
                }                
            }
            return count;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void GrillaTipoVehicular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxtTipo.Text = GrillaTipoVehicular.Rows[e.RowIndex].Cells[1].Value.ToString();
                IdTipoVehiculo = int.Parse(GrillaTipoVehicular.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (TxtTipo.Text != string.Empty && TxtOrigen.Text != string.Empty)
                {
                    CargarGrillaRelevo(Datos_Relevo.BuscarRelevo(IdTipoVehiculo, IdOrigenDestino));
                }
            }
        }

        public void AgregarFilaRelevo()
        {
           
        }

        private void TxtTipoVehicular_TextChanged_1(object sender, EventArgs e)
        {
            CargarGrillaTipoVehicular(TxtTipoVehicular.Text);
        }

        private void TxtOrigenDestino_TextChanged_1(object sender, EventArgs e)
        {
            GrillaOrigenDestino.DataSource = Datos_OrigenDestino.BuscarOrigenDestino(TxtOrigenDestino.Text);
        }

        private void GrillaOrigenDestino_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {                
                TxtOrigen.Text = GrillaOrigenDestino.Rows[e.RowIndex].Cells[5].Value.ToString();
                IdOrigenDestino = int.Parse(GrillaOrigenDestino.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (TxtTipo.Text != string.Empty && TxtOrigen.Text != string.Empty)
                {
                    CargarGrillaRelevo(Datos_Relevo.BuscarRelevo(IdTipoVehiculo, IdOrigenDestino));
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtTipo.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "El Campo Tipo-Vehicular es requerido", "Campo Requerido",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TxtOrigen.Text == string.Empty)
                {
                    MetroMessageBox.Show(this, "El Campo Origen-Destino es requerido", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (TxtRelevo.Text == string.Empty)
                    {
                        MetroMessageBox.Show(this, "El Campo Relevo es requerido", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (BuscarCoicidencia(TxtRelevo.Text) == 0)
                        {
                            Dt_Relevo.Rows.Add(IdTipoVehiculo, IdOrigenDestino, DateTime.Now, TxtRelevo.Text, 1);
                            CargarGrillaRelevo(Dt_Relevo);
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "El Registro " + TxtRelevo.Text + " ya existe, por favor verifique", "Registro Duplicados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
           
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            Iniciar();
            this.Hide();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (GrillaRelevo.Rows.Count > 0)
            {
                for (int i = 0; i < GrillaRelevo.Rows.Count; i++)
                {
                    Negocios_Relevo.IdTipoVehiculo = int.Parse(GrillaRelevo.Rows[i].Cells[0].Value.ToString());
                    Negocios_Relevo.IdOrigenDestino = int.Parse(GrillaRelevo.Rows[i].Cells[1].Value.ToString());
                    Negocios_Relevo.Relevo = GrillaRelevo.Rows[i].Cells[3].Value.ToString();

                    if (Datos_Relevo.BuscarRelevoExistencia(Negocios_Relevo.IdTipoVehiculo, Negocios_Relevo.IdOrigenDestino, Negocios_Relevo.Relevo).Rows.Count == 0)
                    {
                        Datos_Relevo.GuardarRelevo(Negocios_Relevo);
                    }
                }
                MetroMessageBox.Show(this, "Datos Guardados Correctamente!!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Iniciar();
            }
            else
            {
                MetroMessageBox.Show(this, "No hay registros para guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (GrillaRelevo.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros a eliminar");
            }
            else
            {
                int fila = GrillaRelevo.CurrentCell.RowIndex;
                int TipoVehiculo = int.Parse(GrillaRelevo.Rows[fila].Cells[0].Value.ToString());
                int Origen = int.Parse(GrillaRelevo.Rows[fila].Cells[1].Value.ToString());
                string Relevo = GrillaRelevo.Rows[fila].Cells[3].Value.ToString();

                Negocios_Relevo.IdTipoVehiculo = TipoVehiculo;
                Negocios_Relevo.IdOrigenDestino = Origen;
                Negocios_Relevo.Relevo = Relevo;

                DialogResult result = MetroMessageBox.Show(this, "¿Esta Seguro que desea eliminar el relevo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            int estado = Datos_Relevo.LiberarRelevo(Negocios_Relevo);

                            if (estado > 0)
                            {
                                GrillaRelevo.Rows.RemoveAt(fila);

                                MetroMessageBox.Show(this, "Relevo Eliminado Correctamente...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                            }
                            else
                            {
                                MetroMessageBox.Show(this, "El Relevo no fue Eliminado...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void TxtTipoVehicular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MetroMessageBox.Show(this, "Solo se permite letra...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                e.Handled = true;
                return;
            }
        }

        private void TxtOrigenDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MetroMessageBox.Show(this, "Solo se permite letra...", "Advertencia...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void TxtRelevo_KeyPress(object sender, KeyPressEventArgs e)
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
