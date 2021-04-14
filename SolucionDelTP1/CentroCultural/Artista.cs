using System;

namespace CentroCultural
{
    class Artista
    {
        private String nombre;
        private String nacionalidad;
        private DateTime fechaNacimiento;
        private DateTime fechaFallecimiento;

        public Artista(string nombre, string nacionalidad, int anioNacimiento, int mesNacimiento, int diaNacimiento, int anioFallecimiento, int mesFallecimiento, int diaFallecimiento)
        {
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
            this.fechaNacimiento = new DateTime(anioNacimiento, mesNacimiento, diaNacimiento);
            this.fechaFallecimiento = new DateTime(anioFallecimiento, mesFallecimiento, diaFallecimiento);
        }

        public String GetNombre()
        {
            return this.nombre;
        }
        public String GetNacionalidad()
        {
            return this.nacionalidad;
        }

        public override string ToString()
        {
            return "\n------ Datos del artista ------" +
                "\nNombre: " + this.nombre + 
                "\nNacionalidad: " + this.nacionalidad + 
                "\nFecha Nacimiento: " + fechaNacimiento.ToString("d") + 
                "\nFecha Fallecimiento: " + fechaFallecimiento.ToString("d");
        }

    }
}
