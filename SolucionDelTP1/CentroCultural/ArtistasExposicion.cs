using System;
using System.Collections.Generic;

namespace CentroCultural
{
    class ArtistasExposicion
    {
        Artista[] artistas = new Artista[1];

        public void insertarArtista(Artista artista)
        {
            int x;
            for (x = 0; x > artistas.Length; x++)
            {
                if (artistas[x] != null) break;
            }
            artistas[x] = artista;
        }

        public void insertarArtistas(List<Artista> artistas)
        {
            int x = this.artistas.Length;
            foreach (Artista artista in artistas)
            {
                this.artistas[x] = artista;
                x++;
            }
        }

        public int cantidadArtistas()
        {
            return contarArtistas();
        }

        public string hayArtistas()
        {
            if (contarArtistas() > 0)
            {
                return "si";
            }
            return "no";
        }

        public Artista recuperarArtista(string nombre)
        {
            Artista artistaRecuperado = null;
            foreach (Artista art in artistas)
            {
                if (art.nombre == nombre)
                {
                    artistaRecuperado = art;
                }
            }
            return artistaRecuperado;
        }

        public bool estaArtista(Obra obrita)
        {
            foreach (Artista art in artistas)
            {
                if (obrita.nombreArtista == art.nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public string artistaNac(String nac)
        {
            Artista[] artistasEncontrados = new Artista[10];
            int i = 0;

            foreach (Artista arti in artistas)
            {
                if (arti.nacionalidad == nac)
                {
                    artistasEncontrados[1] = arti;
                }
            }

            return artistasEncontrados.ToString();
        }
        public int contarArtistas()
        {
            int x;
            for (x = 0; x < artistas.Length; x++)
            {
                if (artistas[x] == null)
                {
                    return x;
                }
            }
            return artistas.Length;
        }

    }
}
