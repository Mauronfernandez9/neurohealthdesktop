using System;
using System.Collections.Generic;
using System.Text;

namespace NeuroHealthDesktop
{
    public class ConexionDB
    {
        private readonly string _ruta;

        public ConexionDB(string ruta)
        {
            _ruta = ruta;
        }

       public bool Conectar()
        {
            return File.Exists(_ruta);
        }
    }
}
