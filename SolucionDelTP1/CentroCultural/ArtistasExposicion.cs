using System;
using System.Collections.Generic;

namespace CentroCultural
{
    class ArtistasExposicion
    {
        private const int CANTIDAD_MAXIMA_DE_ARTISTAS = 10;

        private List<Artista> artistasExposicion;

        public ArtistasExposicion()
        {
            this.artistasExposicion = new List<Artista>();
        }

        public void InsertarArtista(Artista artista)
        {
            String mensaje = "\nNo hay lugar para agregar otro artista";

            if ( !this.EstaLlena() ) // Agrego el artista si hay lugar
            {
                this.artistasExposicion.Add(artista);
                mensaje = "\nSe agrego el artista correctamente";
            }

            Console.WriteLine(mensaje);
        }

        public int CantidadArtistas()
        {
            return this.artistasExposicion.Count;
        }

        public bool EstaLlena()
        {
            return this.CantidadArtistas() == ArtistasExposicion.CANTIDAD_MAXIMA_DE_ARTISTAS;
        }

        public bool HayArtista()
        {
            return this.CantidadArtistas() > 0;
        }

        public Artista RecuperarArtista(String nombreDelArtista)
        {
            foreach(Artista art in this.artistasExposicion)
            {
                if (art.GetNombre() == nombreDelArtista)
                {
                    return art;
                }
            }
            return null;
        }
    
        public ArtistasExposicion ArtistasNacionalidad( String nacionalidad )
        {
            ArtistasExposicion artistasExposicion = new ArtistasExposicion();

            foreach ( Artista art in this.artistasExposicion )
            {
                if ( art.GetNacionalidad() == nacionalidad )
                {
                    artistasExposicion.InsertarArtista(art);
                }
            }
            return artistasExposicion;
        }
    
        public List<Artista> GetArtistasExposicion()
        {
            return this.artistasExposicion;
        }
    }
}
