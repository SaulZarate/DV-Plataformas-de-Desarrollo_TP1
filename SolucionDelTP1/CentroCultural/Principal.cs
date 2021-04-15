using System;
using System.Collections.Generic;

namespace CentroCultural
{
    class Principal
    {
        static void Main(string[] args)
        {
            CentroCultural centroCutural = new CentroCultural("Centro de cultura internacional");

            /* List<String> artistas = centroCutural.NombresObrasNacionalidad("Argentina");
            foreach ( String artista in artistas)
            {
                Console.WriteLine(artista);
            } */

            /* List<String> cuadros = centroCutural.NombreCuadrosGaleria("galeria1");
            foreach (String artista in cuadros)
            {
                Console.WriteLine(artista);
            } */

            //Console.WriteLine(centroCutural.ObtenerTodosLosArtistas());
            //Console.WriteLine(centroCutural.ObtenerTodasLasObras());

            //Console.WriteLine(centroCutural.ObtenerTodosLosArtistas());
            //Console.WriteLine(centroCutural.ObtenerTodasLasObras());
            //Console.WriteLine(centroCutural.ObtenerObrasPorNombreDeArtista("Francisco de Medicci"));
            //Console.WriteLine(centroCutural.ObtenerObrasOrdenasPorAnioDeCreacion());
            Console.WriteLine(centroCutural.ObtenerTodosLosCuadrosPrestados());

        }
    }
}
