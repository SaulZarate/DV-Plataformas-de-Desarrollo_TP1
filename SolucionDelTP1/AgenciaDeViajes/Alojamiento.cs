using System;

namespace AgenciaDeViajes
{
    class Alojamiento
    {
        private int codigo;
        private String ciudad;
        private String barrio;
        private int estrellas;
        private int cantidadDePersonas;
        private bool tv;

        public Alojamiento(int codigo, String ciudad,String barrio,int estrellas,int cantidadDePersonas, bool tv = false)
        {
            this.codigo = codigo;
            this.ciudad = ciudad;
            this.barrio = barrio;
            this.estrellas = estrellas;
            this.cantidadDePersonas = cantidadDePersonas;
            this.tv = tv;
        }
        public override String ToString()
        {
            return $"Código: {this.codigo} \n" +
                $"Personas: {this.cantidadDePersonas} \n" +
                $"Estrellas: {this.estrellas} \n" +
                "Television: " + (this.tv ? "si" : "no") + " \n" +
                $"Ciudad: {this.ciudad} \n" +
                $"Barrio: {this.barrio} \n" ;
            
        }
        public bool IgualCodigo(Alojamiento alojamiento)
        {
            return this.codigo == alojamiento.getCodigo();
        }


        public static Alojamiento[] OrderByEstrellas(Alojamiento[] alojamientos)
        {
            return Alojamiento.orderByAtributo("estrella",alojamientos);
        }
        public static Alojamiento[] OrderByCantidadDePersonas(Alojamiento[] alojamientos)
        {
            return Alojamiento.orderByAtributo("cantidadDePersonas", alojamientos);
        }
        public static Alojamiento[] OrderByCodigo(Alojamiento[] alojamientos)
        {
            return Alojamiento.orderByAtributo("codigo", alojamientos);
        }
        // Este metodo es el que realmente se encarga de orgenar todo
        private static Alojamiento[] orderByAtributo(String nameAtributo , Alojamiento[] alojamientos)
        {
            for (int i = 0; i < alojamientos.Length; i++)
            {
                for (int j = 0; j < alojamientos.Length-1; j++)
                {
                    if (Alojamiento.isMayor(nameAtributo, alojamientos[j], alojamientos[j+1]))
                    {
                        Alojamiento aux = alojamientos[j];
                        alojamientos[j] = alojamientos[j+1];
                        alojamientos[j+1] = aux;

                    }
                }
            }
            return alojamientos;
        }
        private static bool isMayor(String nameAtributo, Alojamiento al1, Alojamiento al2)
        {
            bool resultado = false;
            if (al2 == null) return false;
            switch (nameAtributo)
            {
                case "estrella":
                    if ( al1.getEstrellas() > al2.getEstrellas()) resultado = true;
                    break;
                case "codigo":
                    if (al1.getCodigo() > al2.getCodigo()) resultado = true;
                    break;
                case "cantidadDePersonas":
                    if (al1.getCantidadDePersonas() > al2.getCantidadDePersonas()) resultado = true;
                    break;
            }
            return resultado;
        }

        public int getCodigo()
        {
            return this.codigo;
        }
    
        public int getEstrellas()
        {
            return this.estrellas;
        }
    
        public int getCantidadDePersonas()
        {
            return this.cantidadDePersonas;
        }
    }
}
