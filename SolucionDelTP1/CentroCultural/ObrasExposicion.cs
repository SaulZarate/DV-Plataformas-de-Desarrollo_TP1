using System;
using System.Collections.Generic;

namespace CentroCultural
{
    class ObrasExposicion
    {
        private const int CANTIDAD_MAXIMA_DE_OBRAS_DE_EXPOSICION = 10;

        private ObraDeArte[] exposicion;

        public ObrasExposicion()
        {
            this.exposicion = new ObraDeArte[ObrasExposicion.CANTIDAD_MAXIMA_DE_OBRAS_DE_EXPOSICION];
        }
        
        public void InsertarObra(ObraDeArte obra)
        {
            String mensaje = "";
            if( this.EstaLlena() ) // Verifica si esta llena
            {
                mensaje = "\nNo hay lugar para ingresar otra obra de arte";
            }
            else if( !this.HayObras() ) // Verifica que no hayan obras
            {
                // Agrego la obra
                this.exposicion[0] = obra;
                mensaje = "\nObra de arte agregada correctamente";
            }
            else if( this.RecuperarObra(obra.GetCodigo()) != null ) // Verifico si existe la obra
            {
                mensaje = "\nYa existe esa obra de arte";
            }
            else 
            {
                // Agrego la Obra
                this.exposicion[this.CantidadObras()] = obra;
                mensaje = "\nObra de arte agregada correctamente";
            }

            Console.WriteLine(mensaje);
        }

        public int CantidadObras()
        {
            int cont = 0;
            foreach (ObraDeArte obra in this.exposicion)
            {
                if(obra != null)
                {
                    cont++;
                }
            }
            return cont;
        }

        public bool EstaLlena()
        {
            return ObrasExposicion.CANTIDAD_MAXIMA_DE_OBRAS_DE_EXPOSICION == this.CantidadObras();
        }

        public bool HayObras()
        {
            return this.CantidadObras() > 0;
        }

        public ObraDeArte RecuperarObra(int codigo)
        {
            foreach(ObraDeArte obra in this.exposicion)
            {
                if ( obra != null && obra.GetCodigo() == codigo)
                {
                    return obra;
                }
            }
            return null;
        }
        
        public ObrasExposicion ObrasArtistas(String nombreDelArtista)
        {
            ObrasExposicion exposicion = new ObrasExposicion();

            foreach (ObraDeArte obra in this.exposicion)
            {
                if( obra != null && obra.GetNombreArtista() == nombreDelArtista)
                {
                    exposicion.InsertarObra(obra);
                }
            }

            return exposicion;
        }

        public ObrasExposicion TodosLosCuadrosPrestados()
        {
            ObrasExposicion exposicion = new ObrasExposicion();

            foreach ( ObraDeArte obra in this.exposicion )
            {
                if ( obra != null && obra is CuadroPrestado)
                {
                    exposicion.InsertarObra(obra);
                }
            }

            return exposicion;
        }

        /* METODOS AGREGADOS */



        /* GETTERS */
        public ObraDeArte[] GetExposicion()
        {
            return this.exposicion;
        }
    }
}
