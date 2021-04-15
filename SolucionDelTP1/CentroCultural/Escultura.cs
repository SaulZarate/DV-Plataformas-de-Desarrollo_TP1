using System;

namespace CentroCultural
{
    class Escultura : ObraDeArte
    {
        private int peso;
        private int volumen;

        public Escultura(int peso, int volumen, int codigo, int anioCreacion, string nombre, string nombreArtista, int anio, int mes, int dia) : 
            base(codigo, anioCreacion, nombre, nombreArtista, anio, mes, dia)
        {
            this.peso = peso;
            this.volumen = volumen;
        }
        public override String ToString()
        {
            return "Peso: " + this.peso + 
                "\nVolumen: " + this.volumen + 
                "\n" + base.ToString();
        }
    }
}
