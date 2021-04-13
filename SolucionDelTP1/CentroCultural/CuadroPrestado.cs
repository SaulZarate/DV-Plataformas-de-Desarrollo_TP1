using System;

namespace CentroCultural
{
    class CuadroPrestado : Cuadro
    {
        private DateTime fechaDeDevolucion;
        private String nombreGaleria;

        public CuadroPrestado(int anioDevo, int mesDevo, int diaDevo, string nombreGaleria, int baseCuadro, int altura, int codigo, int anioCreacion, string nombre, string nombreArtista, int anio, int mes, int dia) : 
            base(baseCuadro, altura, codigo, anioCreacion, nombre, nombreArtista, anio, mes, dia)
        {
            this.fechaDeDevolucion = new DateTime(anioDevo, mesDevo, diaDevo);
            this.nombreGaleria = nombreGaleria;
        }

        public String GetNombreGaleria()
        {
            return this.nombreGaleria;
        }

        public override String ToString()
        {
            return "\nDatos del cuadro prestado:\n" +
                "\nFecha de devolucion: " + this.fechaDeDevolucion + 
                "\nNombre de la galeria: " + this.nombreGaleria 
                + base.ToString();
        }
    }
}
