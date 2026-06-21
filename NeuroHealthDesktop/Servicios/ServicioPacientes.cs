using System.Collections.Generic;
using System.Linq;

namespace NeuroHealthDesktop.Servicios
{
    public class ServicioPacientes
    {
        private Queue<Paciente> colaEspera;
        private List<Paciente> pacientesAdmitidos;

        private IRepositorioPacientes repositorioPacientes;
        private IServicioTriaje servicioTriaje;

        public ServicioPacientes(
            IRepositorioPacientes repositorioPacientes,
            IServicioTriaje servicioTriaje)
        {
            this.repositorioPacientes = repositorioPacientes;
            this.servicioTriaje = servicioTriaje;

            colaEspera = new Queue<Paciente>();
            pacientesAdmitidos = new List<Paciente>();

            CargarDatosInicialesDesdeRepositorio();
        }

        private void CargarDatosInicialesDesdeRepositorio()
        {
            var pacientes = repositorioPacientes.ObtenerTodos();

            foreach (var paciente in pacientes)
            {
                if (paciente.Nivel == NivelUrgencia.SinEvaluar)
                    colaEspera.Enqueue(paciente);
                else
                    pacientesAdmitidos.Add(paciente);
            }
        }

        public ResultadoOperacion<Paciente> RegistrarPaciente(Paciente paciente)
        {
            if (paciente == null)
            {
                return ResultadoOperacion<Paciente>.Error(
                    "Paciente inválido."
                );
            }

            if (repositorioPacientes.ExisteDni(paciente.Dni))
            {
                return ResultadoOperacion<Paciente>.Error(
                    "Ya existe un paciente con ese DNI."
                );
            }

            colaEspera.Enqueue(paciente);
            repositorioPacientes.Agregar(paciente);

            return ResultadoOperacion<Paciente>.Correcto(
                "Paciente registrado correctamente.",
                paciente
            );
        }

        public List<Paciente> ObtenerColaEspera()
        {
            return colaEspera.ToList();
        }

        public List<Paciente> ObtenerPacientesAdmitidos()
        {
            return new List<Paciente>(pacientesAdmitidos);
        }

        public List<Paciente> ObtenerTodos()
        {
            return repositorioPacientes.ObtenerTodos();
        }

        public ResultadoOperacion<Paciente> EvaluarSiguientePaciente()
        {
            if (colaEspera.Count == 0)
            {
                return ResultadoOperacion<Paciente>.Error(
                    "No hay pacientes en espera."
                );
            }

            Paciente paciente = colaEspera.Dequeue();

            paciente.Nivel = servicioTriaje.Clasificar(
                paciente.Signos
            );

            pacientesAdmitidos.Add(paciente);

            repositorioPacientes.Actualizar(paciente);

            return ResultadoOperacion<Paciente>.Correcto(
                $"Paciente clasificado como {paciente.Nivel}.",
                paciente
            );
        }

        public ResultadoOperacion<Paciente> BuscarPacientePorDni(long dni)
        {
            var paciente = repositorioPacientes.BuscarPorDni(dni);

            if (paciente == null)
            {
                return ResultadoOperacion<Paciente>.Error(
                    "Paciente no encontrado."
                );
            }

            return ResultadoOperacion<Paciente>.Correcto(
                "Paciente encontrado.",
                paciente
            );
        }

        public List<Paciente> FiltrarPorNivel(NivelUrgencia nivel)
        {
            return pacientesAdmitidos
                .Where(p => p.Nivel == nivel)
                .ToList();
        }

        public int ContarEnEspera()
        {
            return colaEspera.Count;
        }

        public int ContarAdmitidos()
        {
            return pacientesAdmitidos.Count;
        }

        public int ContarPorNivel(NivelUrgencia nivel)
        {
            return pacientesAdmitidos.Count(
                p => p.Nivel == nivel
            );
        }

        public double CalcularEdadPromedioAdmitidos()
        {
            if (pacientesAdmitidos.Count == 0)
                return 0;

            return pacientesAdmitidos.Average(
                p => p.Edad
            );
        }

        public double CalcularPorcentajeCriticos()
        {
            if (pacientesAdmitidos.Count == 0)
                return 0;

            int criticos = pacientesAdmitidos.Count(
                p => p.Nivel == NivelUrgencia.Rojo
            );

            return (double)criticos * 100 /
                   pacientesAdmitidos.Count;
        }
    }
}