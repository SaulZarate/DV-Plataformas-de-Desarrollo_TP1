using System;

namespace ConsoleApp1
{
    public class Artista
    {
        public string nombre, nacionalidad;
        public DateTime fechaNacimiento, fechaFallecimiento;

        public Artista(string nombre, string nacionalidad, int anioNacimiento, int mesNacimiento, int diaNacimiento, int anioFallecimiento, int mesFallecimiento, int diaFallecimiento)
        {
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
            fechaNacimiento = new DateTime(anioNacimiento, mesNacimiento, diaNacimiento);
            fechaFallecimiento = new DateTime(anioFallecimiento, mesFallecimiento, diaFallecimiento);
        }

       
       public override string ToString()
        {
            return "Datos del artista: \n" + "Nombre: " + nombre + "\nNacionalidad: " + nacionalidad + "\nFecha Nacimiento: " + fechaNacimiento.ToString("d") + "\nFecha Fallecimiento: " + fechaFallecimiento.ToString("d");
        }
        
    }
}