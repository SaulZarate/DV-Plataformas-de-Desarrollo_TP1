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

            if ( !this.EstaLlena() ) // Verifico que no este lleno
            {
                // Agrego el artista
                this.artistasExposicion.Add(artista);
                
                // Ordeno los artistas por nombre
                this.ordenarArtistasPorNombre();

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
    
        /* METODOS AGREGADOS */
        private void ordenarArtistasPorNombre()
        {
            // Guardar los nombres de los artistas en un array
            String[] nombres = this.obtenerNombresDeLosArtistas();

            // Ordeno la lista
            Array.Sort(nombres);

            // Crear un objeto artistaExposicion
            List<Artista> artExp = new List<Artista>();

            // Llenarlo usando el array de nombres como iteracion
            foreach(String nombre in nombres)
            {
                artExp.Add(this.RecuperarArtista(nombre));
            }

            // Actualizar el atributo de artistas
            this.artistasExposicion = artExp;
        }
        private String[] obtenerNombresDeLosArtistas()
        {
            String[] nombres = new String[this.CantidadArtistas()];

            int contador = 0;
            foreach(Artista art in this.artistasExposicion)
            {
                if( art != null)
                {
                    nombres[contador] = art.GetNombre();
                    contador++;
                }
            }

            return nombres;
        }
        
        public String ObtenerTodosLosArtistas()
        {
            String mensaje = "";
            foreach(Artista art in this.artistasExposicion)
            {
                mensaje += art.ToString() + "\n\n";
            }
            return mensaje != "" ? mensaje : "\n\n¡No se encontraron artistas!\n\n";
        }

        /* GETTERS */
        public List<Artista> GetArtistasExposicion()
        {
            return this.artistasExposicion;
        }
    }
}
