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
            // TODO: Actualizar la cola de espera y la lista de admitidos.
            dgvColaEspera.DataSource = null;
            dgvPacientesAdmitidos.DataSource = null;
        }

        private async void btnEvaluarPaciente_Click(object sender, EventArgs e)
        {
            // Fragmento orientativo provisto para simular tarea en segundo plano.
            btnEvaluarPaciente.Enabled = false;
            progressBarEvaluacion.Visible = true;
            progressBarEvaluacion.Style = ProgressBarStyle.Marquee;
            lblEstado.Text = "Aquí se evaluará el siguiente paciente.";

            await Task.Run(() =>
            {
                Thread.Sleep(1000);
            });

            progressBarEvaluacion.Visible = false;
            btnEvaluarPaciente.Enabled = true;
            lblEstado.Text = "Evaluación pendiente de implementar.";
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá el formulario para registrar un paciente.");
        }

        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá el formulario de observaciones.");
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá el formulario de estadísticas.");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarGrillas();
            lblEstado.Text = "Aquí se actualizarán los datos mostrados.";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPacientesAdmitidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // TODO: Aplicar color según el nivel de urgencia.
        }
    }
}
