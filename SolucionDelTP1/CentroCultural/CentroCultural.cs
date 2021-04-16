using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CentroCultural
    {
        String nombre;
        
        public ObrasExposicion obrasExpo = new ObrasExposicion();
        
        public ArtistasExposicion artistasExpo;
        

        public CentroCultural(string nombre)
        {
            this.nombre = nombre;
        }


        public void cantidadArtistas(int cantidadArtista)
        {
            artistasExpo = new ArtistasExposicion(cantidadArtista);
        }
        public void cantidadObras(int cantidadObras)
        {
            obrasExpo = new ObrasExposicion(cantidadObras);
        }

       
        public void agregarObra(Obra obra)
        {
            obrasExpo.insertarObra(obra);
        }
        public void agregarObras(List<Obra> obras)
        {
            obrasExpo.insertarObras(obras);
        }
        public void agregarArtista(Artista artista){
            artistasExpo.insertarArtista(artista);
        }
        public void agregarArtistas(List<Artista> artistas)
        {
            artistasExpo.insertarArtistas(artistas);
        }

        public List<Obra> buscarObraPorNacionalidadArtista(String nacionalidadArtista) { 
             List<Obra> listaObra= new List<Obra>();
            foreach(Artista artistasE in artistasExpo.getArtistas())
            {
                if(artistasE.nacionalidad == nacionalidadArtista) {
                    foreach(Obra obra in obrasExpo.exposicion)
                    {
                            if (obra.nombreArtista ==artistasE.nombre)
                            {
                                listaObra.Add(obra);
                            }
                    }
                }
                
            }
            return listaObra;
            
        }

        public List<CuadroPrestado> buscarPorGaleria(String galeria)
        {
            List<CuadroPrestado> cuadroPrestados=new List<CuadroPrestado>();
            foreach(CuadroPrestado cuadroPestrado in obrasExpo.exposicion)
            {
                if(cuadroPestrado.getNombreGaleria() == galeria)
                    cuadroPrestados.Add(cuadroPestrado);
            }
            return cuadroPrestados;
        }

        public List<Artista> buscarArtistaPorNacionalidad(string nacionalidadArtista) {
             List<Artista> artistas=new List<Artista>();
             foreach(Artista artistasE in artistasExpo.getArtistas())
                {
                    if(artistasE.nacionalidad == nacionalidadArtista) {
                    artistas.Add(artistasE);
                    }
                
                }
             return artistas;
        }
        override
        public string ToString()
        {
            return nombre;
        }


    }
}
