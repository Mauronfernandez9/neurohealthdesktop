namespace NeuroHealthDesktop.Servicios
{
    public class ServicioTriaje : IServicioTriaje
    {
        public NivelUrgencia Clasificar(SignosVitales signos)
        {
            // TODO: Implementar las reglas de triaje.
            // Debe devolver Rojo, Amarillo o Verde según los signos vitales.
            return NivelUrgencia.SinEvaluar;
        }

        private bool EsRojo(SignosVitales signos)
        {
            // TODO: Implementar condición de nivel rojo.
            return false;
        }

        private bool EsAmarillo(SignosVitales signos)
        {
            // TODO: Implementar condición de nivel amarillo.
            return false;
        }
    }
}
