using System;

namespace AgenciaDeViajes
{
    class Hotel : Alojamiento
    {
        private double precioPorPersona;

        public Hotel(double precioPorPersona, int codigo, String ciudad, String barrio, int estrellas, int cantPersonas, bool tv = false) :
            base(codigo, ciudad, barrio, estrellas, cantPersonas, tv)
        {
            this.precioPorPersona = precioPorPersona;
        }

        public override String ToString()
        {
            return "------ HOTEL ------------\n" +
                $"Precio por persona: ${this.precioPorPersona} \n" + 
                base.ToString();
        }

    }
}
