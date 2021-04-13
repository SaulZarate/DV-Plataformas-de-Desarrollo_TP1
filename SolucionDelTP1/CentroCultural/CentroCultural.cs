using System;
using System.Collections.Generic;

namespace CentroCultural
{
  class CentroCultural
  {
    private String nombre;
    private ObrasExposicion obras;
    private ArtistasExposicion artistas;

    public CentroCultural(String nombre)
    {
      this.nombre = nombre;
      this.obras = new ObrasExposicion();
      this.artistas = new ArtistasExposicion();
      this.artistasPorDefecto();
      this.obrasPorDefecto();
    }

    public List<String> NombresObrasNacionalidad(String nacionalidad)
    {
      // Lista de nombres
      List<String> nombres = new List<string>();

      // Artistas que cumplen
      ArtistasExposicion artistas = this.artistas.ArtistasNacionalidad(nacionalidad);

      foreach (Artista artista in artistas.GetArtistasExposicion())
      {
        nombres.Add(artista.GetNombre());
      }

      return nombres;
    }
    public List<String> NombreCuadrosGaleria(String nombreDeLaGaleria)
    {
      List<String> nombres = new List<string>();

      foreach (ObraDeArte obra in this.obras.GetExposicion())
      {
        if (obra != null && obra is CuadroPrestado)
        {
          CuadroPrestado aux = (CuadroPrestado)obra;

          if (aux.GetNombreGaleria() == nombreDeLaGaleria)
          {
            nombres.Add(aux.GetNombre());
          }
        }
      }

      return nombres;
    }


    /* AGREGAR DATOS AL CENTRO CULTURAL */
    public void agregarObra(ObraDeArte obra)
    {
      obras.InsertarObra(obra);
    }

    public void agregarArtista(Artista artista)
    {
      artistas.InsertarArtista(artista);
    }


    /* OBTENER DATOS DEL CENTRO CULTURAL */

    // Obtener todos los Artistas
    public String ObtenerTodosLosArtistas()
    {
      return this.artistas.ObtenerTodosLosArtistas();
    }

    // Obtener todas la obras de arte
    public String ObtenerTodasLasObras()
    {
      return this.obras.ObtenerTodasLasObras();
    }

    // Obtener todas las obras por nombre de artista
    public String ObtenerObrasPorNombreDeArtista(String nombreDelArtista)
    {
      return this.obras.ObrasArtistas(nombreDelArtista).ObtenerTodasLasObras();
    }

    // Obtener obras ordenadas por año
    public String ObtenerObrasOrdenasPorAnio()
    {
      this.obras.OrdenarObrasPorAnio();
      return this.obras.ObtenerTodasLasObras();
    }

    // Obtener todos los cuadros prestados
    public String ObtenerTodosLosCuadrosPrestados()
    {
      return this.obras.TodosLosCuadrosPrestados().ObtenerTodasLasObras();
    }

    /* AGREGAR DATOS AL CENTRO CULTURAL */
    private void artistasPorDefecto()
    {
      this.agregarArtista(new Artista("Francisco de Medicci", "Frances", 1594, 12, 12, 1650, 12, 25));
      this.agregarArtista(new Artista("Leopoldo Fernandez", "Argentina", 1560, 08, 25, 1640, 11, 30));
      this.agregarArtista(new Artista("Carlos de Santo", "Uruguayo", 1594, 12, 12, 1650, 12, 25));
      this.agregarArtista(new Artista("Leonardo Da Vinci", "Italiano", 1560, 08, 25, 1640, 11, 30));
    }
    private void obrasPorDefecto()
    {
      // Cuadros
      this.agregarObra(new CuadroPrestado(2022, 12, 11, "galeria3", 5, 5, 457546, 908, "El espiedo", "Francisco de Medicci", 2020, 12, 25));
      this.agregarObra(new CuadroPrestado(2025, 11, 23, "galeria1", 5, 5, 234235, 908, "El perro", "Leopoldo Fernandez", 1989, 12, 25));
      this.agregarObra(new CuadroPrestado(2023, 12, 11, "galeria4", 5, 5, 798965, 908, "El caballo", "Carlos de Santo", 1568, 12, 25));
      this.agregarObra(new CuadroPrestado(2023, 12, 11, "galeria2", 5, 5, 289867, 908, "La Mona Lisa", "Leonardo Da Vinci", 1465, 12, 25));

      // Cuadros Prestados
      this.agregarObra(new CuadroPrestado(2021, 12, 21, "galeria1", 10, 10, 986561, 2019, "La buitreada", "Carlos de Santo", 2020, 10, 28));
      this.agregarObra(new CuadroPrestado(2022, 11, 29, "galeria4", 10, 10, 783483, 2019, "El Chaja", "Leonardo Da Vinci", 2020, 10, 10));
      this.agregarObra(new CuadroPrestado(2023, 10, 18, "galeria2", 10, 10, 153211, 2020, "El despertar", "Leopoldo Fernandez", 2019, 11, 30));

      // Esculturas
      this.agregarObra(new Escultura(250, 300, 642341, 2010, "escutura1", "Francisco de Medicci", 2018, 11, 24));
      this.agregarObra(new Escultura(500, 250, 811433, 2012, "escutura2", "Leopoldo Fernandez", 2018, 11, 24));
      this.agregarObra(new Escultura(100, 150, 991242, 2015, "escutura3", "Carlos de Santo", 2018, 11, 24));
    }

    /* GETTER */
    public String GetNombre()
    {
      return this.nombre;
    }

  }
}

