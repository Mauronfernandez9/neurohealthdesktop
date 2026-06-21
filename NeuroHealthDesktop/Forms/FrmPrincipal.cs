using NeuroHealthDesktop.Repositorios;
using NeuroHealthDesktop.Servicios;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroHealthDesktop.Forms
{
    public partial class FrmPrincipal : Form
    {
        private IRepositorioPacientes repositorioPacientes;
        private IRepositorioObservaciones repositorioObservaciones;
        private IServicioTriaje servicioTriaje;
        private ServicioPacientes servicioPacientes;
        private ServicioObservaciones servicioObservaciones;

        public FrmPrincipal()
        {
            InitializeComponent();

            InicializarDependencias();
            ConfigurarGrillas();
            ActualizarGrillas();

            lblEstado.Text = "Sistema iniciado. Funcionalidad pendiente de implementar.";
            progressBarEvaluacion.Visible = false;
        }

        private void InicializarDependencias()
        {
            // TODO: Crear repositorios, servicios y conectar dependencias.
            repositorioPacientes = new RepositorioPacientesArchivo();
            repositorioObservaciones = new RepositorioObservacionesArchivo();
            servicioTriaje = new ServicioTriaje();

            servicioPacientes = new ServicioPacientes(repositorioPacientes, servicioTriaje);
            servicioObservaciones = new ServicioObservaciones(repositorioObservaciones, repositorioPacientes);
        }

        private void ConfigurarGrillas()
        {
            // TODO: Configurar columnas de las grillas.
        }

        private void ConfigurarGrillaPacientes(DataGridView grilla, bool mostrarNivelTexto)
        {
            // TODO: Configurar una grilla de pacientes.
        }

        private void ActualizarGrillas()
        {
            dgvColaEspera.DataSource = null;
            dgvPacientesAdmitidos.DataSource = null;

            dgvColaEspera.DataSource =
                servicioPacientes.ObtenerColaEspera();

            dgvPacientesAdmitidos.DataSource =
                servicioPacientes.ObtenerPacientesAdmitidos();
        }

        private async void btnEvaluarPaciente_Click(object sender, EventArgs e)
        {
            btnEvaluarPaciente.Enabled = false;

            progressBarEvaluacion.Visible = true;
            progressBarEvaluacion.Style = ProgressBarStyle.Marquee;

            lblEstado.Text = "Evaluando paciente...";

            await Task.Run(() =>
            {
                Thread.Sleep(2000);
            });

            var resultado =
                servicioPacientes.EvaluarSiguientePaciente();

            progressBarEvaluacion.Visible = false;
            btnEvaluarPaciente.Enabled = true;

            lblEstado.Text = resultado.Mensaje;

            ActualizarGrillas();

            if (!resultado.Exito)
            {
                MessageBox.Show(
                    resultado.Mensaje,
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            FrmRegistrarPaciente frmRegistrarPaciente = new FrmRegistrarPaciente(servicioPacientes);
            frmRegistrarPaciente.ShowDialog();
            this.ActualizarGrillas();
        }

        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            FrmObservaciones frmObservacion = new FrmObservaciones(servicioObservaciones);
            frmObservacion.ShowDialog();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas(servicioPacientes);
            frmEstadisticas.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarGrillas();
            lblEstado.Text = "Datos actualizados.";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPacientesAdmitidos_CellFormatting(
     object sender,
     DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPacientesAdmitidos.Rows[e.RowIndex].DataBoundItem
                is Paciente paciente)
            {
                switch (paciente.Nivel)
                {
                    case NivelUrgencia.Rojo:
                        dgvPacientesAdmitidos.Rows[e.RowIndex]
                            .DefaultCellStyle.BackColor = Color.LightCoral;
                        break;

                    case NivelUrgencia.Amarillo:
                        dgvPacientesAdmitidos.Rows[e.RowIndex]
                            .DefaultCellStyle.BackColor = Color.Khaki;
                        break;

                    case NivelUrgencia.Verde:
                        dgvPacientesAdmitidos.Rows[e.RowIndex]
                            .DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                }
            }
        }

        private void dgvColaEspera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
