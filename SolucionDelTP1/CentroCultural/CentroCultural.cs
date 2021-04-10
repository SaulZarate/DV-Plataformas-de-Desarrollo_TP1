using System;
using System.Collections.Generic;

namespace CentroCultural
{
    class CentroCultural
    {
        private String nombre;

        private ObrasExposicion obras;
        private ArtistasExposicion artistas;

        CentroCultural(String nombre)
        {
            this.nombre = nombre;
            this.obras = new ObrasExposicion();
            this.artistas = new ArtistasExposicion();
        }

        public List<String> NombresObrasNacionalidad(String nacionalidad)
        {
            // Lista de nombres
            List<String> nombres = new List<string>();
            
            // Artistas que cumplen
            ArtistasExposicion artistas = this.artistas.ArtistasNacionalidad(nacionalidad);

            foreach ( Artista artista in artistas.GetArtistasExposicion() )
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
                if( obra != null && obra is CuadroPrestado )
                {
                    CuadroPrestado aux = (CuadroPrestado)obra;

                    if( aux.GetNombreGaleria() == nombreDeLaGaleria )
                    {
                        nombres.Add(aux.GetNombre());
                    }
                }
            }

            return nombres;
        }


        public void agregarObra(ObraDeArte obra)
        {
            obras.InsertarObra(obra);
        }

        public void agregarArtista(Artista artista)
        {
            artistas.InsertarArtista(artista);
        }

        /* 
         * TODO: Agregar los siguientes metodos. Todos deberan devolver un string para mostrarlo en el menu 
         * Algunos metodos ya estan implementados en sus respectivas clases, pero necesitamos llamarlos desde esta clase.
        */

        // Ver artistas ordenados por nombres

        // Ver todas las obras. Ya tiene metodo

        // Ver obras por nombre de artista. Ya tiene metodo

        // Ver obras ordenadas por año

        // Ver Cuadros prestados por la exposicion. Ya tiene metodo

    }
}
