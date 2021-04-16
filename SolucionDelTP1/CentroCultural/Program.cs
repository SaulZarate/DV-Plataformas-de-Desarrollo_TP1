using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bandera = 1;

            CentroCultural centro;


            //Bienvenida al sistema y selector de opciones
            Console.WriteLine("Bienvenido al sistema de gestion del Centro Cultural");
            Console.WriteLine("Elija el nombre del Centro Cultural");
            string name = Console.ReadLine();

            centro = new CentroCultural(name);
            Console.WriteLine("El nombre del centro cultural elegido es: " + centro);

            Console.WriteLine("Elija la cantidad de obras maximas para crear la exposición");
            int numeroObras = int.Parse(Console.ReadLine());
            centro.cantidadObras(numeroObras);

            Console.WriteLine("Elija la cantidad máxima de artistas expositores");
            int numeroArtistas = int.Parse(Console.ReadLine());
            centro.cantidadArtistas(numeroArtistas);



            Console.WriteLine("Te gustaria generar obras y artistas de forma automatica? presiona '1' para si o '2' para no, una vez rechazado no se podran generar las obras automaticamente");
            int generar = int.Parse(Console.ReadLine());

            //Genera obras y artistas automaticamente si el usuario lo pide

            if (generar == 1)
            {
                Cuadro c1 = new Cuadro(5, 5, 1, 908, "El espiedo", "Francisco de Medicci", 2020, 12, 25);
                Cuadro c2 = new Cuadro(5, 5, 1, 908, "El perro", "Leopoldo Fernandez", 1989, 12, 25);
                Cuadro c3 = new Cuadro(5, 5, 1, 908, "El caballo", "Carlos de Santo", 1568, 12, 25);
                Cuadro c4 = new Cuadro(5, 5, 1, 908, "La Mona Lisa", "Leonardo Da Vinci", 1465, 12, 25);
                centro.obrasExpo.insertarObra(c1);
                centro.obrasExpo.insertarObra(c2);
                centro.obrasExpo.insertarObra(c3);
                centro.obrasExpo.insertarObra(c4);

                Artista artistaUno = new Artista("Francisco de Medicci", "Frances", 1594, 12, 12, 1650, 12, 25);
                Artista artistaDos = new Artista("Leopoldo Fernandez", "Argentina", 1560, 08, 25, 1640, 11, 30);
                Artista artistaTres = new Artista("Carlos de Santo", "Uruguayo", 1594, 12, 12, 1650, 12, 25);
                Artista artistaCuatro = new Artista("Leonardo Da Vinci", "Italiano", 1560, 08, 25, 1640, 11, 30);

                centro.artistasExpo.insertarArtista(artistaUno);
                centro.artistasExpo.insertarArtista(artistaDos);
                centro.artistasExpo.insertarArtista(artistaTres);
                centro.artistasExpo.insertarArtista(artistaCuatro);
            }




            // Empieza el loop con las opciones del menu
            while (bandera != 0)
            {

                Console.WriteLine("Elija una opcion:\n" +
                                   "0 para salir del sistema\n" +
                                    "1 para ingresar un artista\n" +
                                    "2 para ingresar una obra\n" +
                                   " 3 para ver cuantos artistas hay\n" +
                                   " 4 si la exposicion esta llena de artistas\n " +
                                   " 5 buscar un artista\n" +
                                   " 6 se ingreso algun artista?\n" +
                                   " 7 ver cantidad de obras" +
                                   " 8 buscar una obra" +
                                   " 9 buscar obras por artistas" +
                                   " 10 buscar por cuadros prestados" +
                                   " 11 Buscar obras por nacionalidad del artista" +
                                   " 12 buscar cuadros segun la galeria" +
                                   " 13 Buscar artistas por nacionalidad" +
                                   " 14 si la exposicion esta llena de obras\n");
                bandera = int.Parse(Console.ReadLine());
                if (bandera == 1)
                {
                    Console.WriteLine("Elija el nombre del artista");
                    string nombreArtista = Console.ReadLine();
                    Console.WriteLine("Elija la nacionalidad del artista");
                    string nacionalidadArtista = Console.ReadLine();
                    Console.WriteLine("Elija el año de nacimiento del artista");
                    int nacimientoArtistaAnio = int.Parse(Console.ReadLine());
                    Console.WriteLine("Elija el mes de nacimiento del artista");
                    int nacimientoArtistaMes = int.Parse(Console.ReadLine());
                    Console.WriteLine("Elija el dia de nacimiento del artista");
                    int nacimientoArtistaDia = int.Parse(Console.ReadLine());

                    Console.WriteLine("¿Querés ingresar la fecha de defunción? si/no");
                    string decicion = Console.ReadLine();

                    if (decicion == "si")
                    {
                        Console.WriteLine("Elija el año de nacimiento del artista");
                        int DefuncionArtistaAnio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Elija el mes de nacimiento del artista");
                        int DefuncionArtistaMes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Elija el dia de nacimiento del artista");
                        int DefuncionArtistaDia = int.Parse(Console.ReadLine());
                        centro.agregarArtista(new Artista(nombreArtista, nacionalidadArtista, nacimientoArtistaAnio, nacimientoArtistaMes, nacimientoArtistaDia, DefuncionArtistaAnio, DefuncionArtistaMes, DefuncionArtistaDia));

                    }
                    else
                    {
                        centro.agregarArtista(new Artista(nombreArtista, nacionalidadArtista, nacimientoArtistaAnio, nacimientoArtistaMes, nacimientoArtistaDia));
                    }

                }
                else if (bandera == 2)

                {
                    Console.WriteLine("Elija 0 para salir del sistema, 1 para ingresar un cuadro, 2 para ingresar una escultura");
                    bandera = int.Parse(Console.ReadLine());

                    if (bandera == 1)
                    {
                        Console.WriteLine("Elija 0 para salir del sistema, 1 para ingresar un cuadro prestado o 2 para ingresar un cuadro propio");
                        bandera = int.Parse(Console.ReadLine());
                        if (bandera == 1)
                        {
                            //Pide los datos para el constructor de cuadro prestado
                            Console.WriteLine("Ingrese el año de devolucion");
                            int anioDevo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el mes de devolucion");
                            int mesDevo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el dia de devolucion");
                            int diaDevo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el nombre de la galería");
                            string nombreGaleria = Console.ReadLine();
                            Console.WriteLine("Ingrese la base del cuadro");
                            int baseCuadro = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la altura del cuadro");
                            int alturaCuadro = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el código de identificación de la obra");
                            int codigo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el año de creación");
                            int anioCreacion = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el nombre de la obra");
                            string nombreObra = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del artista");
                            string nombreArtistaObra = Console.ReadLine();
                            Console.WriteLine("Ingrese el año de ingreso");
                            int anioIngreso = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el mes de ingreso");
                            int mesIngreso = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el dia de ingreso");
                            int diaIngreso = int.Parse(Console.ReadLine());

                            centro.agregarObra(new CuadroPrestado(anioDevo, mesDevo, diaDevo, nombreGaleria, baseCuadro, alturaCuadro, codigo, anioCreacion, nombreObra, nombreArtistaObra, anioIngreso, mesIngreso, diaIngreso));

                        }
                        else if (bandera == 2)
                        {
                            //Pide los datos para el constructor de cuadro propio

                            Console.WriteLine("Ingrese la base del cuadro");
                            int baseCuadro = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la altura del cuadro");
                            int alturaCuadro = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el código de identificación de la obra");
                            int codigo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el año de creación");
                            int anioCreacion = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el nombre de la obra");
                            string nombreObra = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del artista");
                            string nombreArtistaObra = Console.ReadLine();
                            Console.WriteLine("Ingrese el año de ingreso");
                            int anioIngreso = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el mes de ingreso");
                            int mesIngreso = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el dia de ingreso");
                            int diaIngreso = int.Parse(Console.ReadLine());

                            centro.agregarObra(new Cuadro(baseCuadro, alturaCuadro, codigo, anioCreacion, nombreObra, nombreArtistaObra, anioIngreso, mesIngreso, diaIngreso));

                        }
                    }
                    else if (bandera == 2)
                    {
                        Console.WriteLine("Ingrese la base de la escultura");
                        int peso = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura de la escultura");
                        int volumen = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el código de identificación de la obra");
                        int codigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el año de creación");
                        int anioCreacion = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el nombre de la obra");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del artista");
                        string nombreArtista = Console.ReadLine();
                        Console.WriteLine("Ingrese el año de ingreso");
                        int anio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el mes de ingreso");
                        int mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el dia de ingreso");
                        int dia = int.Parse(Console.ReadLine());

                        centro.agregarObra(new Escultura(peso, volumen, codigo, anioCreacion, nombre, nombreArtista, anio, mes, dia));
                    }
                    else if (bandera == 3)
                    {
                        Console.WriteLine("Artistas actuales: " + centro.artistasExpo.contarArtistas());
                    }
                    else if (bandera == 4)
                    {
                        Console.WriteLine("Esta llena de artistas? " + centro.artistasExpo.estaLlena());
                    }
                    else if (bandera == 5)
                    {
                        Console.WriteLine("Ingrese el codigo de la obra del artista");
                        int obra = int.Parse(Console.ReadLine());
                        Console.WriteLine(centro.artistasExpo.estaArtista(centro.obrasExpo.recuperoObra(obra)));
                    }
                    else if (bandera == 6)
                    {
                        Console.WriteLine("Hay artistas? " + centro.artistasExpo.hayArtistas());
                    }
                    else if (bandera == 7)
                    {
                        Console.WriteLine("Hay obras? " + centro.obrasExpo.cantidadObras());
                    }
                    else if (bandera == 8)
                    {
                        Console.WriteLine("Ingrese el codigo de la obra");
                        int obra = int.Parse(Console.ReadLine());
                        Console.WriteLine(centro.obrasExpo.recuperarObra(centro.obrasExpo.recuperoObra(obra)));
                    }
                    else if (bandera == 9)
                    {
                        Console.WriteLine("Ingrese el nombre del artista");
                        string nombreArtista = Console.ReadLine();
                        foreach (Obra obra in centro.obrasExpo.obrasArtista(nombreArtista))
                        {
                            Console.WriteLine(obra.nombre);
                        }
                    }
                    else if (bandera == 10)
                    {
                        foreach (CuadroPrestado cuadroPrestado in centro.obrasExpo.buscarPorCuadroPrestado())
                            Console.WriteLine(cuadroPrestado.nombre);
                    }
                    else if (bandera == 11)
                    {
                        Console.WriteLine("Ingrese la nacionalidad del artista para buscar las obras");
                        string nacionalidadArtista = Console.ReadLine();
                        foreach (Obra obra in centro.buscarObraPorNacionalidadArtista(nacionalidadArtista))
                        {
                            Console.WriteLine(obra.nombre);
                        }
                    }
                    else if (bandera == 12)
                    {
                        Console.WriteLine("Ingrese el nombre de la galeria");
                        string nombreGaleria = Console.ReadLine();
                        foreach (Obra obra in centro.buscarPorGaleria(nombreGaleria))
                        {
                            Console.WriteLine(obra.nombre);
                        }
                    }
                    else if (bandera == 13)
                    {
                        Console.WriteLine("Ingrese la nacionalidad del artista");
                        string nacionalidadArtista = Console.ReadLine();
                        foreach (Artista artista in centro.buscarArtistaPorNacionalidad(nacionalidadArtista))
                        {
                            Console.WriteLine(artista.nombre);
                        }
                        
                    }
                    else if (bandera == 14)
                    {
                        Console.WriteLine("Esta llenade obras? " + centro.obrasExpo.estaLlena());
                    }



                }

                /*ObrasExposicion expoObras = new ObrasExposicion(5);
                  Cuadro c1 = new Cuadro(5,5,1,908,"El espiedo", "Francisco de Medicci", 2020,12,25);
                  Cuadro c2 = new Cuadro(5, 5, 1, 908, "El perro", "Leopoldo Fernandez", 1989, 12, 25);
                  Cuadro c3 = new Cuadro(5, 5, 1, 908, "El caballo", "Carlos de Santo", 1568, 12, 25);
                  Cuadro c4 = new Cuadro(5, 5, 1, 908, "La Mona Lisa", "Leonardo Da Vinci", 1465, 12, 25);
                  expoObras.insertarObra(c1);
                  expoObras.insertarObra(c2);
                  expoObras.insertarObra(c3);
                  expoObras.insertarObra(c4);
                  expoObras.insertarObra(c1);//debe dar error
                  Console.WriteLine(expoObras.cantidadObras());
                  Console.WriteLine(expoObras.cantidadObras());
                  Console.WriteLine(expoObras.cantidadObras());
                  //Console.WriteLine("hola");
                  //Console.WriteLine(expoObras.recuperarObra(0).ToString());
                  // Console.WriteLine(expoObras.exposicion[0].nombreArtista);
                  Artista artistaUno = new Artista("Francisco de Medicci", "Frances", 1594, 12, 12, 1650, 12, 25);
                  Artista artistaDos = new Artista("Leopoldo Fernandez", "Argentina", 1560, 08, 25, 1640, 11, 30);
                  Artista artistaTres = new Artista("Carlos de Santo", "Uruguayo", 1594, 12, 12, 1650, 12, 25);
                  Artista artistaCuatro = new Artista("Leonardo Da Vinci", "Italiano", 1560, 08, 25, 1640, 11, 30);
                  ArtistasExposicion expMedieval = new ArtistasExposicion();
                  expMedieval.insertarArtista(artistaUno);
                  expMedieval.insertarArtista(artistaDos);
                  expMedieval.insertarArtista(artistaTres);
                  expMedieval.insertarArtista(artistaCuatro);
                  Console.WriteLine(expMedieval.artistaNac("Frances"));
                  Console.WriteLine(expMedieval.artistaNac("Argentina"));
                  Console.WriteLine("Contando los artistas: "+ expMedieval.contarArtistas());
                  Console.WriteLine("esta el artista de la obra "+ c1.nombre + "?"+expMedieval.estaArtista(c1));
                  //Console.WriteLine(artistaUno.nombre);
                  // Console.WriteLine(expMedieval.estaArtista(c1, expoObras));*/

            }
        }
    }
}
