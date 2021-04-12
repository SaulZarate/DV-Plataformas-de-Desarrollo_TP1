using System;
using System.Collections.Generic;
using System.Text;

namespace CentroCultural
{
    class Cuadro : Obra
    {
        int baseCuadro;
        int altura;
        public Cuadro(int baseCuadro, int altura, int codigo, int anioCreacion, string nombre, string nombreArtista, int anio, int mes, int dia) : base(codigo, anioCreacion, nombre, nombreArtista, anio, mes, dia)
        {
            this.baseCuadro = baseCuadro;
            this.altura = altura;

        }

        public override String ToString()
        {
            return "\nBase: " + baseCuadro + "\nAltura: " + altura + base.ToString();
        }

    }
}
