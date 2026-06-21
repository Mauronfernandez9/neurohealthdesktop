using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NeuroHealthDesktop.Repositorios
{
    public class RepositorioPacientesArchivo : IRepositorioPacientes
    {
        private readonly string rutaArchivo;

        public RepositorioPacientesArchivo()
        {
            string carpeta = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Datos"
            );

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            rutaArchivo = Path.Combine(carpeta, "pacientes.txt");

            if (!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Close();
            }
        }

        public void Agregar(Paciente paciente)
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine(ConvertirPacienteALinea(paciente));
            }
        }

        public List<Paciente> ObtenerTodos()
        {
            List<Paciente> lista = new List<Paciente>();

            if (!File.Exists(rutaArchivo))
                return lista;

            foreach (string linea in File.ReadAllLines(rutaArchivo))
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                Paciente? paciente = ConvertirLineaAPaciente(linea);

                if (paciente != null)
                    lista.Add(paciente);
            }

            return lista;
        }

        public Paciente? BuscarPorDni(long dni)
        {
            return ObtenerTodos()
                .FirstOrDefault(p => p.Dni == dni);
        }

        public bool ExisteDni(long dni)
        {
            return BuscarPorDni(dni) != null;
        }

        public void Actualizar(Paciente paciente)
        {
            List<Paciente> pacientes = ObtenerTodos();

            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i].Dni == paciente.Dni)
                {
                    pacientes[i] = paciente;
                    break;
                }
            }

            GuardarTodos(pacientes);
        }

        public List<Paciente> FiltrarPorNivel(NivelUrgencia nivel)
        {
            return ObtenerTodos()
                .Where(p => p.Nivel == nivel)
                .ToList();
        }

        private void GuardarTodos(List<Paciente> pacientes)
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo, false))
            {
                foreach (Paciente paciente in pacientes)
                {
                    writer.WriteLine(ConvertirPacienteALinea(paciente));
                }
            }
        }

        private string ConvertirPacienteALinea(Paciente paciente)
        {
            string requiereCamilla = "";
            string adultoResponsable = "";

            if (paciente is PacienteGuardia pg)
            {
                requiereCamilla = pg.RequiereCamilla.ToString();
            }
            else if (paciente is PacientePediatrico pp)
            {
                adultoResponsable = pp.AdultoResponsable;
            }

            return
                $"{paciente.Tipo}|" +
                $"{paciente.Dni}|" +
                $"{paciente.NombreApellido}|" +
                $"{paciente.Edad}|" +
                $"{paciente.Motivo}|" +
                $"{paciente.Signos.Pulso}|" +
                $"{paciente.Signos.Temperatura}|" +
                $"{paciente.Signos.Presion}|" +
                $"{paciente.Signos.Saturacion}|" +
                $"{paciente.Signos.Dolor}|" +
                $"{paciente.FechaIngreso:O}|" +
                $"{paciente.Nivel}|" +
                $"{requiereCamilla}|" +
                $"{adultoResponsable}";
        }

        private Paciente? ConvertirLineaAPaciente(string linea)
        {
            try
            {
                string[] partes = linea.Split('|');

                if (partes.Length < 14)
                    return null;

                TipoPaciente tipo =
                    Enum.Parse<TipoPaciente>(partes[0]);

                long dni =
                    long.Parse(partes[1]);

                string nombre =
                    partes[2];

                int edad =
                    int.Parse(partes[3]);

                MotivoConsulta motivo =
                    Enum.Parse<MotivoConsulta>(partes[4]);

                SignosVitales signos = new SignosVitales(
                    int.Parse(partes[5]),
                    double.Parse(partes[6]),
                    partes[7],
                    int.Parse(partes[8]),
                    int.Parse(partes[9])
                );

                DateTime fechaIngreso =
                    DateTime.Parse(partes[10]);

                NivelUrgencia nivel =
                    Enum.Parse<NivelUrgencia>(partes[11]);

                if (tipo == TipoPaciente.Guardia)
                {
                    bool requiereCamilla =
                        bool.Parse(partes[12]);

                    return new PacienteGuardia(
                        dni,
                        nombre,
                        edad,
                        motivo,
                        signos,
                        requiereCamilla)
                    {
                        FechaIngreso = fechaIngreso,
                        Nivel = nivel
                    };
                }
                else
                {
                    string adultoResponsable =
                        partes[13];

                    return new PacientePediatrico(
                        dni,
                        nombre,
                        edad,
                        motivo,
                        signos,
                        adultoResponsable)
                    {
                        FechaIngreso = fechaIngreso,
                        Nivel = nivel
                    };
                }
            }
            catch
            {
                return null;
            }
        }
    }
}