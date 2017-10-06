using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaReportes;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmComprobante frmcomprobante = new FrmComprobante();
        public FrmEstadoConductor frmestadoconductor = new FrmEstadoConductor();
        public FrmConductores frmconductores = new FrmConductores();
        public FrmDepartamento frmdepartamento = new FrmDepartamento();
        public FrmDistrito frmdistrito = new FrmDistrito();
        public FrmEstadoCivil frmestadocivil = new FrmEstadoCivil();
        public FrmEstadoVehicular frmestadovehicular = new FrmEstadoVehicular();
        public FrmGrifo frmgrifo = new FrmGrifo();
        public FrmOrigenDestino frmorigendestino = new FrmOrigenDestino();
        public FrmPerfil frmperfil = new FrmPerfil();
        public FrmUnidadVehicular frmunidadvehicular = new FrmUnidadVehicular();
        public FrmTipoVehicular frmtipovehicular = new FrmTipoVehicular();
        public FrmTipoContrato frmtipocontrato = new FrmTipoContrato();
        public FrmSubTipoVehicular frmsubtipovehicular = new FrmSubTipoVehicular();
        public FrmProvincia frmprovinciaa = new FrmProvincia();
        public FrmUsuario frmusuarios = new FrmUsuario();
        public FrmTraspaso frmtraspaso = new FrmTraspaso();
        public FrmTraspasoReparto frmtraspasorepartoss = new FrmTraspasoReparto();
        public FrmAsignacionCombustible frmasignacioncombustible = new FrmAsignacionCombustible();
        public FrmAsignacionReparto frmasignacionreparto = new FrmAsignacionReparto();
        public FrmLogin frmloginn = new FrmLogin();
        public FrmCombustible frmcombustible = new FrmCombustible();
        public FrmLiquidar frmliquidar = new FrmLiquidar();
        public FrmExportarData frmexportardata = new FrmExportarData();
        public FrmImportarData frmimportardata = new FrmImportarData();
        public FrmTiempos frmtiempos = new FrmTiempos();
        public FrmPesos frmpesos = new FrmPesos();
        public FrmRelleno frmrelleno = new FrmRelleno();
        //public ReporteConductoresLista reporteconductoreslista = new ReporteConductoresLista();
        public ReporteConductoresGeneral reporteconductoresgeneral = new ReporteConductoresGeneral();
        public ReportesUnidadesVehiculares reporteunidadvehicular = new ReportesUnidadesVehiculares();
        public FrmRegistroRelevo frmregistrorelevo = new FrmRegistroRelevo();
        public Form1 frm1 = new Form1();
        public ReporteRutas reporterutas = new ReporteRutas();
        public ReporteUsuarios reporteusuario = new ReporteUsuarios();
        public FrmSeguimientoLlamadas seguimientollamada = new FrmSeguimientoLlamadas();
        public FrmAsignacionPesos asignacionpeso = new FrmAsignacionPesos();
        public ReporteControlCombustible reportecontrolcombustible = new ReporteControlCombustible();

        public FrmPrincipal()
        {
            InitializeComponent();
            

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Status_NombreUsuario.Text = FrmLogin.ObtenerUsuario();
            Status_PerfilNombre.Text = FrmLogin.ObtenerPerfil();
            
        }

        private void comprobanteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmcomprobante.MdiParent = this;
            
            
            frmcomprobante.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void estadoConductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmestadoconductor.MdiParent = this;
            frmestadoconductor.Show();
        }

        private void conductoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconductores.MdiParent = this;
            frmconductores.Show();

        }

        private void departamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmdepartamento.MdiParent = this;
            frmdepartamento.Show();

        }

        private void distritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdistrito.MdiParent = this;
            frmdistrito.Show();
        }

        private void estadoCivilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmestadocivil.MdiParent = this;
            frmestadocivil.Show();
        }

        private void estadoVehicularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmestadovehicular.MdiParent = this;
            frmestadovehicular.Show();
        }

        private void grifoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmgrifo.MdiParent = this;
            frmgrifo.Show();

        }

        private void origenDestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmorigendestino.MdiParent = this;
            frmorigendestino.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmperfil.MdiParent = this;
            frmperfil.Show();

        }

        private void unidadVehicularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmunidadvehicular.MdiParent = this;
            frmunidadvehicular.Show();
                
        }

        private void tipoVehicularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtipovehicular.MdiParent = this;
            frmtipovehicular.Show();
        }

        private void tipoContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtipocontrato.MdiParent = this;
            frmtipocontrato.Show();

        }

        private void subTipoVehicularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsubtipovehicular.MdiParent = this;
            frmsubtipovehicular.Show();
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmprovinciaa.MdiParent = this;
            frmprovinciaa.Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmusuarios.MdiParent = this;
            frmusuarios.Show();
        }

        private void traspasoCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtraspaso.MdiParent = this;
            frmtraspaso.Show ();
        }

        private void traspasoRepartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtraspasorepartoss.MdiParent = this;
            frmtraspasorepartoss.Show();
        }

        private void asignacionCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmasignacioncombustible.MdiParent = this;
            frmasignacioncombustible.Show();
        }

        private void asignacionRepartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmasignacionreparto.MdiParent = this;
            frmasignacionreparto.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmloginn.MdiParent = this;
            frmloginn.Show();

        }

        private void combustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcombustible.MdiParent = this;
            frmcombustible.Show();
        }

        private void flotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmliquidar.MdiParent = this;
            frmliquidar.Show();
        }

        private void exportarBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmexportardata.MdiParent = this;
            frmexportardata.Show();
        }

        private void importatrBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmimportardata.MdiParent = this;
            frmimportardata.Show();
        }

        private void asignacionTiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtiempos.MdiParent = this;
            frmtiempos.Show();
        }

        private void asignacionPesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmpesos.MdiParent = this;
            //frmpesos.Show();
            asignacionpeso.MdiParent = this;
            asignacionpeso.Show();
        }

        private void registroRellenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrelleno.MdiParent = this;
            frmrelleno.Show();
        }

        private void listaConductoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            reporteconductoresgeneral.MdiParent = this;
            reporteconductoresgeneral.Show();
            //reporteconductoreslista.MdiParent = this;
            //reporteconductoreslista.Show();
        }

        private void unidadesVehicularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteunidadvehicular.MdiParent = this;
            reporteunidadvehicular.Show();
        }

        private void asignacionRelevosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmregistrorelevo.MdiParent = this;
            frmregistrorelevo.Show();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void rutasTiemposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporterutas.MdiParent = this;
            reporterutas.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteusuario.MdiParent = this;
            reporteusuario.Show();
        }

        private void seguimientoLlamadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seguimientollamada.MdiParent = this;
            seguimientollamada.Show();
        }

        private void reportesCombustiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportecontrolcombustible.MdiParent = this;
            reportecontrolcombustible.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmloginn.Show();
            this.Hide();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    //Status_Fecha.Text = DateTime.Now.ToString("G");
        //}


    }
}
