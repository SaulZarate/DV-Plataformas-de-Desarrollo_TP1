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
            // Obtener los nombres de los artistas
            String[] nombres = this.obtenerNombresDeLosArtistas();

            // Usar el metodo burbuja con el array de nombres y con CompareTo
            String[] nombresOrdenados = this.ordenarArrayDeString(nombres);
            foreach(String str in nombresOrdenados)
            {
                Console.WriteLine(str);
            }
            
            // Crear un objeto artistaExposicion
            List<Artista> artExp = new List<Artista>();

            // Llenarlo usando el array de nombres como iteracion
            foreach(String nombre in nombresOrdenados)
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
        // REVISAR EL METODO DE ORDENAMIENTO
        private String[] ordenarArrayDeString(String[] nombres)
        {
            int tamanioDelArray = nombres.Length;
            String[] nombresOrdenados = nombres;

            for (int i = 0; i < tamanioDelArray; i++)
            {
                for (int j = 0; j < tamanioDelArray - 1 ; j++)
                {
                    if (nombresOrdenados[j+1] != null)
                    {
                        if (nombresOrdenados[j].CompareTo(nombresOrdenados[j + 1]) < 0)
                        {
                            String aux = nombresOrdenados[j];
                            nombresOrdenados[j] = nombresOrdenados[j + 1];
                            nombresOrdenados[j] = aux;
                        }
                    }
                }
            }
            return nombresOrdenados;
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
