namespace NeuroHealthDesktop.Servicios
{
    public class ServicioTriaje : IServicioTriaje
    {
        public NivelUrgencia Clasificar(SignosVitales signos)
        {
            if (EsRojo(signos))
                return NivelUrgencia.Rojo;

            if (EsAmarillo(signos))
                return NivelUrgencia.Amarillo;

            return NivelUrgencia.Verde;
        }

        private bool EsRojo(SignosVitales signos)
        {
            return signos.Saturacion < 90
                || signos.Pulso > 120
                || signos.Temperatura >= 39.0
                || signos.Dolor >= 9;
        }

        private bool EsAmarillo(SignosVitales signos)
        {
            return (signos.Saturacion >= 90 && signos.Saturacion <= 94)
                || (signos.Pulso >= 100 && signos.Pulso <= 120)
                || (signos.Temperatura >= 38.0 && signos.Temperatura <= 38.9)
                || (signos.Dolor >= 6 && signos.Dolor <= 8);
        }
    }
}