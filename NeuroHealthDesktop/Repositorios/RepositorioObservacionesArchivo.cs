using System.Collections.Generic;

namespace NeuroHealthDesktop.Repositorios
{
    public class RepositorioObservacionesArchivo : IRepositorioObservaciones
    {
        private string rutaArchivo;

        public RepositorioObservacionesArchivo()
        {
            rutaArchivo = "observaciones.txt";
        }

        public void Agregar(Observacion observacion)
        {
            observacion.Id = ObtenerProximoId();

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine(ConvertirObservacionALinea(observacion));
            }
        }

        public List<Observacion> ObtenerTodas()
        {

            List<Observacion> lista = new List<Observacion>();

            if (!File.Exists(rutaArchivo))
                return lista;

            foreach (var linea in File.ReadAllLines(rutaArchivo))
            {
                var obs = ConvertirLineaAObservacion(linea);
                if (obs != null)
                    lista.Add(obs);
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
            var lista = ObtenerTodas();

            if (lista.Count == 0)
                return 1;

            return lista.Max(o => o.Id) + 1;
        }

        private string ConvertirObservacionALinea(Observacion observacion)
        {
            return $"{observacion.Id}|{observacion.DniPaciente}|{observacion.Fecha}|{observacion.Texto}";
        }

        private Observacion? ConvertirLineaAObservacion(string linea)
        {
            var partes = linea.Split('|');

            if (partes.Length < 4)
                return null;

            int id = int.Parse(partes[0]);
            long dni = long.Parse(partes[1]);
            DateTime fecha = DateTime.Parse(partes[2]);
            string texto = partes[3];

            return new Observacion(id, dni, fecha, texto);
        }
    }
}
