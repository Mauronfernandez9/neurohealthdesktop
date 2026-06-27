using NeuroHealthDesktop.Servicios;
using System;
using System.Windows.Forms;
using System.Linq;

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
            TipoPaciente tipo =
                (TipoPaciente)cmbTipoPaciente.SelectedItem;

            bool esGuardia = tipo == TipoPaciente.Guardia;

            chkRequiereCamilla.Enabled = esGuardia;
            txtAdultoResponsable.Enabled = !esGuardia;

            if (esGuardia)
                txtAdultoResponsable.Clear();
            else
                chkRequiereCamilla.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente =
                    CrearPacienteDesdeFormulario();

                var resultado =
                    servicioPacientes.RegistrarPaciente(paciente);

                MessageBox.Show(resultado.Mensaje);

                if (resultado.Exito)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Paciente CrearPacienteDesdeFormulario()
        {
            long dni = ObtenerDni();

            if (!dniEsValido(dni)) throw new Exception("El campo DNI no puede ser igual o menor a 0 ni estar vacio"); 

            string nombre = txtNombreApellido.Text.Trim();
            if (!EsNombreValido(nombre))
            {
                throw new Exception("El nombre solo puede contener letras.");
            }

            int edad = (int)nudEdad.Value;

            MotivoConsulta motivo =
                (MotivoConsulta)cmbMotivo.SelectedItem;

            if (string.IsNullOrEmpty(txtPresion.Text)) throw new Exception("El campo presion no puede estar vacio");

            SignosVitales signos =
                new SignosVitales(
                    (int)nudPulso.Value,
                    (double)nudTemperatura.Value,
                    txtPresion.Text.Trim(),
                    (int)nudSaturacion.Value,
                    (int)nudDolor.Value
                );




            TipoPaciente tipo =
                (TipoPaciente)cmbTipoPaciente.SelectedItem;

            if (tipo == TipoPaciente.Guardia)
            {
                return new PacienteGuardia(
                    dni,
                    nombre,
                    edad,
                    motivo,
                    signos,
                    chkRequiereCamilla.Checked
                );
            }

            if (txtAdultoResponsable.Enabled) {
                if(!ValidarAdultoResponsable()) throw new Exception("Se necesita agregar un adulto responsable...");
            }
            

            return new PacientePediatrico(
                dni,
                nombre,
                edad,
                motivo,
                signos,
                txtAdultoResponsable.Text.Trim()
            );
        }

        private long ObtenerDni()
        {

            if (string.IsNullOrEmpty(txtDni.Text)) throw new Exception("El campo DNI no puede estar vacio");

            if (!long.TryParse(txtDni.Text, out long dni))
            {
                throw new Exception(
                    "El DNI debe ser numérico."
                );
            }

            if (dni <= 0)
            {
                throw new Exception(
                    "El DNI debe ser positivo."
                );
            }

            return dni;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private bool EsNombreValido(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return false;
            
            return nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool dniEsValido(long dni)
        {
            return dni > 0;
            
        }

        private bool ValidarAdultoResponsable()
        {
            if (string.IsNullOrEmpty(txtAdultoResponsable.Text)) return false;
            return true;
        }
    }
}
