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
            StreamWriter write = new StreamWriter(rutaArchivo, true);
            if (paciente is PacienteGuardia pg)
            {
                write.WriteLine($"{pg.Tipo} | {pg.Dni} | {pg.NombreApellido} | {pg.Edad} | {pg.Motivo} | {pg.Signos} | {pg.FechaIngreso} | {pg.Nivel} | {pg.RequiereCamilla} | |");
            }
            else if (paciente is PacientePediatrico pd)
            {
                write.WriteLine($"{pd.Tipo} | {pd.Dni} | {pd.NombreApellido} | {pd.Edad} | {pd.Motivo} | {pd.Signos} | {pd.FechaIngreso} | {pd.Nivel} | | {pd.AdultoResponsable}");
            }
        }

        public List<Paciente> ObtenerTodos()
        {
            List<Paciente> lista = new List<Paciente>();

            if (!File.Exists(rutaArchivo))
                return lista;

            foreach (var linea in File.ReadAllLines(rutaArchivo))
            {
                var paciente = ConvertirLineaAPaciente(linea);
                if (paciente != null)
                    lista.Add(paciente);
            }

            return lista;
        }

        public Paciente? BuscarPorDni(long dni)
        {
            return ObtenerTodos().FirstOrDefault(p => p.Dni == dni);
        }

        public bool ExisteDni(long dni)
        {
            return BuscarPorDni(dni) != null;
        }

        public void Actualizar(Paciente paciente)
        {
            var lista = ObtenerTodos();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Dni == paciente.Dni)
                {
                    lista[i] = paciente;
                    break;
                }
            }
            GuardarTodos(lista);
        }

        public List<Paciente> FiltrarPorNivel(NivelUrgencia nivel)
        {
            return ObtenerTodos().Where(p => p.Nivel == nivel).ToList();
        }

        private void GuardarTodos(List<Paciente> pacientes)
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo, false))
            {
                foreach (var p in pacientes)
                {
                    writer.WriteLine(ConvertirPacienteALinea(p));
                }
            }
        }

        private string ConvertirPacienteALinea(Paciente paciente)
        {
            string camilla = "";
            string adulto = "";

            if (paciente is PacienteGuardia pg)
            {
                camilla = pg.RequiereCamilla.ToString();
            }
            else if (paciente is PacientePediatrico pp)
            {
                adulto = pp.AdultoResponsable;
            }

            return $"{paciente.Tipo}|{paciente.Dni}|{paciente.NombreApellido}|{paciente.Edad}|{paciente.Motivo}|" +
                   $"{paciente.Signos.Pulso}|{paciente.Signos.Temperatura}|{paciente.Signos.Presion}|" +
                   $"{paciente.Signos.Saturacion}|{paciente.Signos.Dolor}|{paciente.FechaIngreso}|" +
                   $"{paciente.Nivel}|{camilla}|{adulto}";
        }

        private Paciente? ConvertirLineaAPaciente(string linea)
        {
            var partes = linea.Split('|');

            TipoPaciente tipo = Enum.Parse<TipoPaciente>(partes[0]);
            long dni = long.Parse(partes[1]);
            string nombre = partes[2];
            int edad = int.Parse(partes[3]);
            MotivoConsulta motivo = Enum.Parse<MotivoConsulta>(partes[4]);

            SignosVitales signos = new SignosVitales(
                int.Parse(partes[5]),
                double.Parse(partes[6]),
                partes[7],
                int.Parse(partes[8]),
                int.Parse(partes[9])
            );

            DateTime fecha = DateTime.Parse(partes[10]);
            NivelUrgencia nivel = Enum.Parse<NivelUrgencia>(partes[11]);

            if (tipo == TipoPaciente.Guardia)
            {
                bool camilla = bool.Parse(partes[12]);

                return new PacienteGuardia(dni, nombre, edad, motivo, signos, camilla)
                {
                    FechaIngreso = fecha,
                    Nivel = nivel
                };
            }
            else
            {
                string adulto = partes[13];

                return new PacientePediatrico(dni, nombre, edad, motivo, signos, adulto)
                {
                    FechaIngreso = fecha,
                    Nivel = nivel
                };
            }
        }
    }
}
