using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class ObrasExposicion
    {
        public int numeroDeObras= 0;

        public List<Obra> exposicion = new List<Obra>();

        public int capacidadDeObras = 0;
        public ObrasExposicion()
        {
         
        }

        public ObrasExposicion(int capacidadMaximaDeObras)
        {
            capacidadDeObras = capacidadMaximaDeObras;
        }
        public string insertarObra(Obra obra) {
            if( verificarDulicadas(obra)){
                exposicion.Add(obra);
                return "Se inserto la obra correctamente";
            }
            return "No se inserto la obra correctamente, hay una obra igual, farsante";
        }
        public void insertarObras(List<Obra> obras)
        {
            foreach(Obra obra in obras)
            {
                exposicion.Add(obra);
            }
        }

        public int cantidadObras() {
            return exposicion.Count;
        }

        public bool estaLlena() {
            if (exposicion.Count >= numeroDeObras && numeroDeObras!=0) {
                return true;
            } else {
                return false;
            }
        }
        public bool hayObras() {
            if (exposicion.Count >= 0) {
                return true;
            } else {
                return false;
            }
        }

        public String recuperarObra(Obra obra)
        {
            if (recuperoObra(obra) != null) { 
                return "Se recupera la obra "+obra.nombre;
            }
            return "No se encuentra la obra";
        }
            
        

        public List<Obra> obrasArtista(String nombreArtista)
        {
            List<Obra> obrasArtista= new List<Obra>();
           
            foreach( Obra obra in exposicion)
            {
                if(nombreArtista == obra.nombreArtista)
                {
                    obrasArtista.Add(obra);
                }
            }
            return obrasArtista;
        }

        public Obra cuadrosPrestados()
        {
            return exposicion[0];
        }
        public Obra recuperoObra(Obra obra)
        {
            foreach (Obra obras in exposicion)
            {
                if (obras.getCodigo() == obra.getCodigo())
                {
                    return obra;
                }
            }
            return null;
        }
        public Boolean verificarDulicadas(Obra obra){
            foreach(Obra obr in exposicion) {
                if( obr.getCodigo() == obra.getCodigo()){
                    return false;
                }
            }
            return true;
        }

        
    }
}