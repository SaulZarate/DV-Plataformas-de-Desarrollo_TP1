using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CuadroPrestado : Cuadro
    {
        DateTime fechaDeDevolucion;
        String nombreGaleria;

        public CuadroPrestado(int anioDevo, int mesDevo, int diaDevo, string nombreGaleria, int baseCuadro, int altura, int codigo, int anioCreacion, string nombre, string nombreArtista, int anio, int mes, int dia) : base(baseCuadro, altura, codigo, anioCreacion, nombre, nombreArtista, anio, mes, dia)
        {
            this.fechaDeDevolucion = new DateTime(anioDevo, mesDevo, diaDevo);
            this.nombreGaleria = nombreGaleria;
        }
    }
}
