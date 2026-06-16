using NeuroHealthDesktop.Servicios;
using System;
using System.Windows.Forms;

namespace NeuroHealthDesktop.Forms
{
    public partial class FrmRegistrarPaciente : Form
    {
        private ServicioPacientes servicioPacientes;

        public FrmRegistrarPaciente(ServicioPacientes servicioPacientes)
        {
            InitializeComponent();
            this.servicioPacientes = servicioPacientes;
            CargarCombos();
            ConfigurarEstadoInicial();
        }

        private void CargarCombos()
        {
            // TODO: Cargar combos con los valores de los enums.
            cmbMotivo.DataSource = Enum.GetValues(typeof(MotivoConsulta));
            cmbTipoPaciente.DataSource = Enum.GetValues(typeof(TipoPaciente));
        }

        private void ConfigurarEstadoInicial()
        {
            // TODO: Definir estado inicial del formulario.
            cmbTipoPaciente.SelectedItem = TipoPaciente.Guardia;
        }

        private void cmbTipoPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Habilitar controles según tipo de paciente.
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO: Crear paciente y llamar al servicio.
            MessageBox.Show("Aquí se registrará el paciente.");
        }

        private Paciente CrearPacienteDesdeFormulario()
        {
            // TODO: Leer datos y crear PacienteGuardia o PacientePediatrico.
            throw new NotImplementedException("Completar creación del paciente desde el formulario.");
        }

        private long ObtenerDni()
        {
            // TODO: Obtener y validar DNI.
            return 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
