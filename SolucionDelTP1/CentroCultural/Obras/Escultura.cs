using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Escultura : Obra
    {
        int peso;
        int volumen;

        public Escultura(int peso, int volumen, int codigo, int anioCreacion, string nombre, string nombreArtista, int anio, int mes, int dia) : base(codigo, anioCreacion, nombre, nombreArtista, anio, mes, dia)
        {
            this.peso = peso;
            this.volumen = volumen;
        }
    }
}
