using System;
using System.Collections.Generic;

namespace CentroCultural
{
  class CentroCultural
  {
    String nombre;
    private ObrasExposicion[] obrasExpo;
    List<ArtistasExposicion> artistasExpo = new List<ArtistasExposicion>();

    CentroCultural(String nombre)
    {
      this.nombre = nombre;
    }

    public void nombresObrasNacionalidad(string nac) {
      // Devuelve todos los nombres de las obras de arte que correspondan a artistas de una nacionalidad dada

      // return Vector de Strings
    }

    public void nombresCuadrosGaleria(string gal) {
      // Devuelve todos los nombres de los cuadros que pertenecen a una galeria

      // return Vector de Strings
    }
  }
}
