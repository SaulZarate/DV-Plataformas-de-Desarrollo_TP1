using System;

namespace CentroCultural
{
    class ObraDeArte
    {
        private int codigo;
        private String nombre;
        private String nombreArtista;
        private int anioCreacion;
        private DateTime fechaIngreso;

        public ObraDeArte(int codigo, int anioCreacion, String nombre, String nombreArtista, int anio, int mes, int dia)
        {
            this.codigo = codigo;
            this.anioCreacion = anioCreacion;
            this.nombre = nombre;
            this.nombreArtista = nombreArtista;
            this.fechaIngreso = new DateTime(anio, mes, dia);
        }

        public int GetCodigo()
        {
            return this.codigo;
        }
        public String GetNombre()
        {
            return this.nombre;
        }
        public String GetNombreArtista()
        {
            return this.nombreArtista;
        }

        public override String ToString()
        {
            return "\nDatos de la Obra de Arte\n" +
                "\nCodigo: " + this.codigo + 
                "\nAño creacion: " + this.anioCreacion + 
                "\nNombre de la Obra: " + this.nombre + 
                "\nNombre Artista: " + this.nombreArtista + 
                "\nFecha de ingreso: " + this.fechaIngreso.ToString("d");
        }

    }
}
