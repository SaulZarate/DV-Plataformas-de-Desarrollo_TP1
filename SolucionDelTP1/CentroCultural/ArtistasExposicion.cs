using System;
using System.Collections.Generic;

namespace CentroCultural
{
  class ArtistasExposicion
  {
    private List<Artista> artistas;

    public void insertarArtista(Artista artista)
    {
      String message;
      artistas.Add(artista);
      message = "Se agrego el artista";
      Console.WriteLine(message);
    }


    public int cantidadArtistas()
    {
      if (!this.hayArtistas()) return 0;
      return artistas.Count;
    }

    public bool estaArtista(Obra obra)
    {
      foreach (Artista ar in this.artistas)
      {
        if (ar != null)
        {
          if (ar.nombre == obra.nombreArtista)
          {
            return true;
          }
        }
      }

      return false;
    }

    public bool estaLlena()
    {
      return true;
    }

    public bool hayArtistas()
    {
      return artistas.Count > 0;
    }

    // public Artista recuperarArtista(string nombre)
    // {

    // }

    // public List<ArtistasExposicion> artistaNac(String nac)
    // {
    //   // Devuelve todos los artistas de una nacionalidad dada
    // }

  }
}
