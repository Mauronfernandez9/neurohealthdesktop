using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuroHealthDesktop.Servicios
{
    public class ServicioObservaciones
    {
        private IRepositorioObservaciones repositorioObservaciones;
        private IRepositorioPacientes repositorioPacientes;

        public ServicioObservaciones(
            IRepositorioObservaciones repositorioObservaciones,
            IRepositorioPacientes repositorioPacientes)
        {
            this.repositorioObservaciones = repositorioObservaciones;
            this.repositorioPacientes = repositorioPacientes;
        }

        public ResultadoOperacion<Observacion> AgregarObservacion(
            long dniPaciente,
            string texto)
        {
            var paciente = repositorioPacientes.BuscarPorDni(dniPaciente);

            if (paciente == null)
            {
                return ResultadoOperacion<Observacion>.Error(
                    "No existe un paciente con ese DNI."
                );
            }

            if (string.IsNullOrWhiteSpace(texto))
            {
                return ResultadoOperacion<Observacion>.Error(
                    "La observación no puede estar vacía."
                );
            }

            if (texto.Contains("|"))
            {
                return ResultadoOperacion<Observacion>.Error(
                    "La observación no puede contener el carácter |."
                );
            }

            Observacion observacion = new Observacion(
                0,
                dniPaciente,
                DateTime.Now,
                texto.Trim()
            );

            repositorioObservaciones.Agregar(observacion);

            return ResultadoOperacion<Observacion>.Correcto(
                "Observación agregada correctamente.",
                observacion
            );
        }

        public List<Observacion> ObtenerObservacionesPorPaciente(long dniPaciente)
        {
            return repositorioObservaciones
                .ObtenerPorDniPaciente(dniPaciente)
                .OrderByDescending(o => o.Fecha)
                .ToList();
        }

        public List<Observacion> ObtenerTodas()
        {
            return repositorioObservaciones
                .ObtenerTodas()
                .OrderByDescending(o => o.Fecha)
                .ToList();
        }
    }
}