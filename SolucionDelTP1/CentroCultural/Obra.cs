using System;
using System.Collections.Generic;
using System.Text;

namespace CentroCultural
{
    class Obra
    {
        public int codigo, anioCreacion;
        public string nombre, nombreArtista;
        DateTime fechaIngreso;

        public Obra(int codigo, int anioCreacion, string nombre, string nombreArtista, int anio, int mes, int dia)
        {
            this.codigo = codigo;
            this.anioCreacion = anioCreacion;
            this.nombre = nombre;
            this.nombreArtista = nombreArtista;
            fechaIngreso = new DateTime(anio, mes, dia);

        }

        public int getCodigo()
        {
            return this.codigo;
        }

        public override String ToString()
        {

            return "\nCodigo: " + codigo + "\nAño creacion: " + anioCreacion + "\nNombre: " + nombre + "\nNombre Artista: " + nombreArtista + "\nFecha de ingreso: " + fechaIngreso.ToString("d");
        }

    }
}
