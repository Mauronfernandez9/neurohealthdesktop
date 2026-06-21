using NeuroHealthDesktop.Servicios;
using System;
using System.Windows.Forms;

namespace NeuroHealthDesktop.Forms
{
    public partial class FrmObservaciones : Form
    {
        private ServicioObservaciones servicioObservaciones;

        public FrmObservaciones(ServicioObservaciones servicioObservaciones)
        {
            InitializeComponent();
            this.servicioObservaciones = servicioObservaciones;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                long dni = ObtenerDni();

                var resultado = servicioObservaciones.AgregarObservacion(
                    dni,
                    txtObservacion.Text.Trim()
                );

                MessageBox.Show(resultado.Mensaje);

                if (resultado.Exito)
                {
                    txtObservacion.Clear();
                    CargarObservaciones(dni);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                long dni = ObtenerDni();

                CargarObservaciones(dni);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarObservaciones(long dni)
        {
            lstObservaciones.Items.Clear();

            var observaciones =
                servicioObservaciones.ObtenerObservacionesPorPaciente(dni);

            foreach (var obs in observaciones)
            {
                lstObservaciones.Items.Add(
                    $"{obs.Fecha:dd/MM/yyyy HH:mm} - {obs.Texto}"
                );
            }

            if (observaciones.Count == 0)
            {
                lstObservaciones.Items.Add(
                    "No hay observaciones para este paciente."
                );
            }
        }

        private long ObtenerDni()
        {
            if (!long.TryParse(txtDni.Text, out long dni))
            {
                throw new Exception(
                    "Debe ingresar un DNI válido."
                );
            }

            if (dni <= 0)
            {
                throw new Exception(
                    "El DNI debe ser mayor que cero."
                );
            }

            return dni;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
