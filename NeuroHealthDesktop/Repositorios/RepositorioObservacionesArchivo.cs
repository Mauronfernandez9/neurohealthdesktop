using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NeuroHealthDesktop.Repositorios
{
    public class RepositorioObservacionesArchivo : IRepositorioObservaciones
    {
        private readonly string rutaArchivo;

        public RepositorioObservacionesArchivo()
        {
            string carpeta = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Datos"
            );

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            rutaArchivo = Path.Combine(carpeta, "observaciones.txt");

            if (!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Close();
            }
        }

        public void Agregar(Observacion observacion)
        {
            observacion.Id = ObtenerProximoId();

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine(
                    ConvertirObservacionALinea(observacion)
                );
            }
        }

        public List<Observacion> ObtenerTodas()
        {
            List<Observacion> lista = new List<Observacion>();

            if (!File.Exists(rutaArchivo))
                return lista;

            foreach (string linea in File.ReadAllLines(rutaArchivo))
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                Observacion? observacion =
                    ConvertirLineaAObservacion(linea);

                if (observacion != null)
                {
                    lista.Add(observacion);
                }
            }

            return lista;
        }

        public List<Observacion> ObtenerPorDniPaciente(long dniPaciente)
        {
            return ObtenerTodas()
                .Where(o => o.DniPaciente == dniPaciente)
                .OrderByDescending(o => o.Fecha)
                .ToList();
        }

        public int ObtenerProximoId()
        {
            List<Observacion> observaciones = ObtenerTodas();

            if (observaciones.Count == 0)
                return 1;

            return observaciones.Max(o => o.Id) + 1;
        }

        private string ConvertirObservacionALinea(Observacion observacion)
        {
            return
                $"{observacion.Id}|" +
                $"{observacion.DniPaciente}|" +
                $"{observacion.Fecha:O}|" +
                $"{observacion.Texto}";
        }

        private Observacion? ConvertirLineaAObservacion(string linea)
        {
            try
            {
                string[] partes = linea.Split('|');

                if (partes.Length < 4)
                    return null;

                int id =
                    int.Parse(partes[0]);

                long dniPaciente =
                    long.Parse(partes[1]);

                DateTime fecha =
                    DateTime.Parse(partes[2]);

                string texto =
                    partes[3];

                return new Observacion(
                    id,
                    dniPaciente,
                    fecha,
                    texto
                );
            }
            catch
            {
                return null;
            }
        }
    }
}