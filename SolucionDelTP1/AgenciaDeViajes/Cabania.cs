using System;

namespace AgenciaDeViajes
{
    class Cabania : Alojamiento
    {
        private double precioPorDia;
        private int cantidadDeHabitaciones;
        private int cantidadDeBanios;

        public Cabania(double precioPorDia, int cantidadDeHabitaciones, int cantidadDeBanios, int codigo, String ciudad, String barrio, int estrellas, int cantPersonas, bool tv = false) :
            base(codigo, ciudad, barrio, estrellas, cantPersonas, tv)
        {
            this.precioPorDia = precioPorDia;
            this.cantidadDeHabitaciones = cantidadDeHabitaciones;
            this.cantidadDeBanios = cantidadDeBanios;
        }
    
        public override String ToString()
        {
            return "------ CABAÑA ------\n" +
                $"Precio por día: ${this.precioPorDia} \n" +
                $"Habitaciones: {this.cantidadDeHabitaciones} \n" +
                $"Baños: {this.cantidadDeBanios} \n" + 
                base.ToString();
        }

        // GETTER
        public double getPrecioPorDia()
        {
            return this.precioPorDia;
        }
    }
}
