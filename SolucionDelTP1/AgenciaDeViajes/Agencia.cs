using System;

namespace AgenciaDeViajes
{
    class Agencia
    {
        private const int CANTIDAD_MAXIMA_DE_ALOJAMIENTOS = 8;

        private Alojamiento[] alojamientos;
        private int cantidadDeAlojamientos;

        public Agencia()
        {
            this.alojamientos = new Alojamiento[Agencia.CANTIDAD_MAXIMA_DE_ALOJAMIENTOS];
            this.cantidadDeAlojamientos = 0;
        }
        
        public void AgregarAlojamiento(Alojamiento alojamiento)
        {
            String message;
            // Verifico que la agencia no este llena
            if( this.estaLlena() )
            {
                message = "La agencia esta llena. No se pueden agregar mas alojamientos";
            }
            // Verifico si la agencia no tiene alojamientos. Agrego en caso que no tenga
            else if( !this.hayAlojamiento() )
            {
                // Agrego al array
                this.alojamientos[this.cantidadDeAlojamientos] = alojamiento;

                // Incremento en 1 el atributo de cantidad de alojamientos
                this.cantidadDeAlojamientos++;

                message = "Se agrego el alojamiento correctamente";
            }
            // Verifico que el alojamiento no este en la agencia
            else if ( this.estaAlojamiento( alojamiento ) )
            {
                message = "La agencia ya posee ese alojamiento";
            }
            // Agrego el alojamiento
            else
            {
                // Agrego al array
                this.alojamientos[this.cantidadDeAlojamientos] = alojamiento;

                // Incremento en 1 el atributo de cantidad de alojamientos
                this.cantidadDeAlojamientos++;

                message = "Se agrego el alojamiento correctamente";
            }

            // Informo al usuario si se agrego o si no. Con su respectivo mensaje
            Console.WriteLine(message+"\n");
        }

        private bool estaAlojamiento(Alojamiento alojamiento)
        {
            foreach (Alojamiento al in this.alojamientos)
            {
                if (al != null )
                {
                    if (al.IgualCodigo(alojamiento))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private bool estaLlena()
        {
            return this.cantidadDeAlojamientos == Agencia.CANTIDAD_MAXIMA_DE_ALOJAMIENTOS;
        }
        private bool hayAlojamiento()
        {
            return this.cantidadDeAlojamientos > 0;
        }
        
        public Agencia SoloHoteles()
        {
            Agencia agencia = new Agencia();
            foreach (Alojamiento al in this.alojamientos)
            {
                if ( al != null && al is Hotel )
                {
                    agencia.AgregarAlojamiento(al);
                    Console.Clear();
                }
            }
            return agencia;
        }
        public Agencia MasEstrellas(int minimo)
        {
            Agencia agencia = new Agencia();
            foreach( Alojamiento al in this.alojamientos)
            {
                if ( al != null )
                {
                    if ( al.getEstrellas() >= minimo )
                    {
                        agencia.AgregarAlojamiento(al);
                        Console.Clear();
                    }
                }
            }
            return agencia;
        }
        public Agencia CabaniasEntrePrecios(double min, double max)
        {
            Agencia agencia = new Agencia();
            foreach ( Alojamiento al in this.alojamientos)
            {
                if ( al != null && al is Cabania)
                {
                    Cabania cabania = (Cabania)al;
                    double precio = cabania.getPrecioPorDia();
                    if (precio >= min && precio <= max)
                    {
                        agencia.AgregarAlojamiento(al);
                        Console.Clear();
                    }
                }
            }
            return agencia;
        }


        /*  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
        /*  ~~~~~~~~~~~~ METODO AGREGADOS ~~~~~~~~~~~~ */
        /*  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */

        // Datos de la agencia
        public override string ToString()
        {
            return "~~~~~~~~ Agencia ~~~~~~~~\n" +
                $"Cantidad de Hoteles: {this.SoloHoteles().getCantidadDeAlojamientos()}\n" +
                $"Cantidad de Cabañas: {this.SoloCabanias().getCantidadDeAlojamientos()}\n" +
                $"Total: {this.cantidadDeAlojamientos}\n";
        }
        // Mostrar los alojamientos que posee
        public String GetAllAlojamientos()
        {
            if ( !this.hayAlojamiento() ) return "\nNo hay alojamientos disponibles";

            String strAlojamientos = "";
            foreach (Alojamiento al in this.alojamientos)
            {
                if (al != null)
                {
                    strAlojamientos += $"\n{al.ToString()}";
                }
            }
            return strAlojamientos;
        }
        // Solo Cabañas
        public Agencia SoloCabanias()
        {
            Agencia agencia = new Agencia();
            foreach (Alojamiento al in this.alojamientos)
            {
                if (al != null && al is Cabania)
                {
                    agencia.AgregarAlojamiento(al);
                    Console.Clear();
                }
            }
            return agencia;
        }
        // Mostrar cantidad de alojamientos que se pueden agregar
        public String LugaresParaAlojamientos()
        {
            return this.estaLlena() ? "No hay lugar para agregar alojamientos" : $"Se pueden agregar {Agencia.CANTIDAD_MAXIMA_DE_ALOJAMIENTOS-this.cantidadDeAlojamientos} alojamientos";
        }


        // Metodos de ordenamiento
        public void OrderByEstrellas()
        {
            this.alojamientos = Alojamiento.OrderByEstrellas(this.alojamientos);
        }
        public void OrderByCantidadDePersonas()
        {
            this.alojamientos = Alojamiento.OrderByCantidadDePersonas(this.alojamientos);
        }
        public void OrderByCodigo()
        {
            this.alojamientos = Alojamiento.OrderByCodigo(this.alojamientos);
        }

        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
        /*  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
        /*  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */


        // GETTER
        public int getCantidadDeAlojamientos()
        {
            return this.cantidadDeAlojamientos;
        }
        
    }
}
