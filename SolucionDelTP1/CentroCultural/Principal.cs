using System;
using System.Collections.Generic;

namespace CentroCultural
{
    class Principal
    {
        static void Main(string[] args)
        {
            /*
            ObrasExposicion obrasDeExposicion = new ObrasExposicion();

            // Cuadros
            Cuadro c1 = new Cuadro(5, 5, 1, 908, "El espiedo", "Francisco de Medicci", 2020, 12, 25);
            Cuadro c2 = new Cuadro(5, 5, 1, 908, "El perro", "Leopoldo Fernandez", 1989, 12, 25);
            Cuadro c3 = new Cuadro(5, 5, 1, 908, "El caballo", "Carlos de Santo", 1568, 12, 25);
            Cuadro c4 = new Cuadro(5, 5, 1, 908, "La Mona Lisa", "Leonardo Da Vinci", 1465, 12, 25);

            obrasDeExposicion.InsertarObra(c1);
            obrasDeExposicion.InsertarObra(c2);
            obrasDeExposicion.InsertarObra(c3);
            obrasDeExposicion.InsertarObra(c4);
            obrasDeExposicion.InsertarObra(c1); // Cuadro repetido

            Console.WriteLine(obrasDeExposicion.CantidadObras());
            Console.WriteLine(obrasDeExposicion.CantidadObras());
            Console.WriteLine(obrasDeExposicion.CantidadObras());

            // Artistas
            Artista artistaUno = new Artista("Francisco de Medicci", "Frances", 1594, 12, 12, 1650, 12, 25);
            Artista artistaDos = new Artista("Leopoldo Fernandez", "Argentina", 1560, 08, 25, 1640, 11, 30);
            Artista artistaTres = new Artista("Carlos de Santo", "Uruguayo", 1594, 12, 12, 1650, 12, 25);
            Artista artistaCuatro = new Artista("Leonardo Da Vinci", "Italiano", 1560, 08, 25, 1640, 11, 30);

            ArtistasExposicion artistasDeLaExposicion = new ArtistasExposicion();

            artistasDeLaExposicion.InsertarArtista(artistaUno);
            artistasDeLaExposicion.InsertarArtista(artistaDos);
            artistasDeLaExposicion.InsertarArtista(artistaTres);
            artistasDeLaExposicion.InsertarArtista(artistaCuatro);


            Console.WriteLine(artistasDeLaExposicion.ArtistasNacionalidad("Frances"));
            Console.WriteLine(artistasDeLaExposicion.ArtistasNacionalidad("Argentina"));

            Console.WriteLine("Contando los artistas: " + artistasDeLaExposicion.CantidadArtistas());

            Console.WriteLine("¿ Esta el artista de la obra " + c1.GetNombreArtista() + " ? " + (artistasDeLaExposicion.RecuperarArtista(c1.GetNombreArtista()) == null ? "No" : "Si") );
            */

            List<String> nombres = new List<string>();
            Console.WriteLine(nombres.Count == 0);
        }
    }
}
