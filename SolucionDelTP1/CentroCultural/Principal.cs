using System;

namespace CentroCultural
{
    class Principal
    {
        static void Main(string[] args)
        {
            ObrasExposicion expoObras = new ObrasExposicion(5);

            Cuadro c1 = new Cuadro(5, 5, 1, 908, "El espiedo", "Francisco de Medicci", 2020, 12, 25);
            Cuadro c2 = new Cuadro(5, 5, 1, 908, "El perro", "Leopoldo Fernandez", 1989, 12, 25);
            Cuadro c3 = new Cuadro(5, 5, 1, 908, "El caballo", "Carlos de Santo", 1568, 12, 25);
            Cuadro c4 = new Cuadro(5, 5, 1, 908, "La Mona Lisa", "Leonardo Da Vinci", 1465, 12, 25);

            expoObras.insertarObra(c1);
            expoObras.insertarObra(c2);
            expoObras.insertarObra(c3);
            expoObras.insertarObra(c4);
            expoObras.insertarObra(c1);//debe dar error

            Console.WriteLine(expoObras.cantidadObras());
            Console.WriteLine(expoObras.cantidadObras());
            Console.WriteLine(expoObras.cantidadObras());



            //Console.WriteLine("hola");

            //Console.WriteLine(expoObras.recuperarObra(0).ToString());

            // Console.WriteLine(expoObras.exposicion[0].nombreArtista);
            Artista artistaUno = new Artista("Francisco de Medicci", "Frances", 1594, 12, 12, 1650, 12, 25);
            Artista artistaDos = new Artista("Leopoldo Fernandez", "Argentina", 1560, 08, 25, 1640, 11, 30);
            Artista artistaTres = new Artista("Carlos de Santo", "Uruguayo", 1594, 12, 12, 1650, 12, 25);
            Artista artistaCuatro = new Artista("Leonardo Da Vinci", "Italiano", 1560, 08, 25, 1640, 11, 30);

            ArtistasExposicion expMedieval = new ArtistasExposicion();

            expMedieval.insertarArtista(artistaUno);
            expMedieval.insertarArtista(artistaDos);
            expMedieval.insertarArtista(artistaTres);
            expMedieval.insertarArtista(artistaCuatro);


            Console.WriteLine(expMedieval.artistaNac("Frances"));
            Console.WriteLine(expMedieval.artistaNac("Argentina"));

            Console.WriteLine("Contando los artistas: " + expMedieval.contarArtistas());

            Console.WriteLine("esta el artista de la obra " + c1.nombre + "?" + expMedieval.estaArtista(c1));
            //Console.WriteLine(artistaUno.nombre);

            // Console.WriteLine(expMedieval.estaArtista(c1, expoObras));
        }
    }
}
