using System;

namespace CentroCultural
{
    class Cuadro : ObraDeArte
    {
        private int baseCuadro;
        private int altura;

        public Cuadro(int baseCuadro, int altura, int codigo, int anioCreacion, string nombre, string nombreArtista, int anio, int mes, int dia) : 
            base(codigo, anioCreacion, nombre, nombreArtista, anio, mes, dia)
        {
            this.baseCuadro = baseCuadro;
            this.altura = altura;
        }

        public override String ToString()
        {
            return "Base: " + this.baseCuadro + 
                "\nAltura: " + this.altura + 
                "\n" + base.ToString();
        }

    }
}
