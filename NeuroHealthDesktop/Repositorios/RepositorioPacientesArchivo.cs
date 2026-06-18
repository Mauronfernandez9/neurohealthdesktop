using System.Collections.Generic;
using System.Net;

namespace NeuroHealthDesktop.Repositorios
{
    public class RepositorioPacientesArchivo : IRepositorioPacientes
    {
        private string rutaArchivo;

        public RepositorioPacientesArchivo()
        {
            // TODO: Crear carpeta Datos y definir ruta de pacientes.txt.
            rutaArchivo = "pacientes.txt";
        }

        public void Agregar(Paciente paciente)
        {
            // TODO: Agregar paciente al archivo.

            if ((paciente != null) && (paciente.Tipo == TipoPaciente.Guardia))
            {   
                PacienteGuardia PG = new PacienteGuardia(paciente.Dni, paciente.NombreApellido, paciente.Edad, paciente.Motivo, paciente.Signos, true);
                using (StreamWriter write = new StreamWriter(rutaArchivo, true))
                {
                    write.WriteLine($"{paciente.Tipo} | {paciente.Dni} | {paciente.NombreApellido} | {paciente.Edad} | {paciente.Motivo} | {paciente.Signos} | {paciente.FechaIngreso} | {paciente.Nivel}");
                }
            }
            else
            {

            }
        }

        public List<Paciente> ObtenerTodos()
        {
            // TODO: Leer pacientes desde archivo.
            return new List<Paciente>();
        }

        public Paciente? BuscarPorDni(long dni)
        {
            // TODO: Buscar paciente por DNI en archivo.
            return null;
        }

        public bool ExisteDni(long dni)
        {
            // TODO: Verificar si existe el DNI.
            return false;
        }

        public void Actualizar(Paciente paciente)
        {
            // TODO: Actualizar paciente en archivo.
        }

        public List<Paciente> FiltrarPorNivel(NivelUrgencia nivel)
        {
            // TODO: Filtrar pacientes por nivel.
            return new List<Paciente>();
        }

        private void GuardarTodos(List<Paciente> pacientes)
        {
            // TODO: Reescribir archivo completo.
        }

        private string ConvertirPacienteALinea(Paciente paciente)
        {
            // TODO: Convertir paciente a formato separado por |.
            return string.Empty;
        }

        private Paciente? ConvertirLineaAPaciente(string linea)
        {
            // TODO: Convertir línea del archivo en PacienteGuardia o PacientePediatrico.
            return null;
        }
    }
}
