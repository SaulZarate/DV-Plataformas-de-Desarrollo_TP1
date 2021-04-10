using System;
using System.Collections.Generic;

namespace CentroCultural
{
    class CentroCultural
    {
        String nombre;

        ObrasExposicion obrasExpo = new ObrasExposicion();

        ArtistasExposicion artistasExpo = new ArtistasExposicion();

        CentroCultural(String nombre)
        {
            this.nombre = nombre;
        }

        void agregarObra(Obra obra)
        {
            obrasExpo.insertarObra(obra);
        }
        void agregarObras(List<Obra> obras)
        {
            obrasExpo.insertarObras(obras);
        }
        void agregarArtista(Artista artista)
        {
            artistasExpo.insertarArtista(artista);
        }
        void agregarArtistas(List<Artista> artistas)
        {
            artistasExpo.insertarArtistas(artistas);
        }
    }
}
