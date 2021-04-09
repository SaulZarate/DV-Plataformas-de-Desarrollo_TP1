using System;
using System.Threading;

namespace AgenciaDeViajes
{
    class App
    {
        private const String USER_ADMIN = "admin";
        private const String PASSWORD_ADMIN = "admin";

        private Agencia agencia;

        public App()
        {
            Console.Title = "Agencia de alojamientos";
            this.agencia = new Agencia();
            this.alojamientosPorDefecto();
        }
        
        public void Iniciar()
        {
            int opcionMenuPrincipal = 0;
            bool salir = false; // Terminar el programa

            /* Administrador */
            int menuAgregarAlojamiento;
            bool login = false;

            /* Cliente */
            int opcionMenuAgencia;
            int menuCabania;
            int menuAlojamientos;
            int menuEstrellas;

            while (true)
            {
                opcionMenuPrincipal = opcionMenuPrincipal == 0 ? this.menuPrincipal() : opcionMenuPrincipal; // Menu Principal

                opcionMenuAgencia = 0;
                menuCabania = 0;
                menuAlojamientos = 0;
                menuEstrellas = 0;

                if (opcionMenuPrincipal == 1) /* ---------------- SECCION DEL ADMINISTRADOR ---------------- */
                {
                    login = login ? login : this.loginAdmin();

                    if (login)
                    {
                        menuAgregarAlojamiento = this.menuAgregarAlojamiento();

                        if (menuAgregarAlojamiento == 1) /* ~~~~~~~~ Agregar Hotel ~~~~~~~~ */
                        {
                            this.agregarHotel();
                        }
                        else if (menuAgregarAlojamiento == 2) /* ~~~~~~~~ Agregar Cabaña ~~~~~~~~ */
                        {
                            this.agregarCabania();
                        }
                        else if (menuAgregarAlojamiento == 8) /* ~~~~~~~~ Cerrar sesion ~~~~~~~~ */
                        {
                            login = false; // Cierra la sesion
                            opcionMenuPrincipal = 0; // Ir al Menu principal
                        }
                        else
                        {
                            salir = true;
                        }
                    }
                    else
                    {
                        opcionMenuPrincipal = 0;
                    }
                }
                else if (opcionMenuPrincipal == 2) /* ---------------- MENU DE LA AGENCIA ---------------- */
                {
                    opcionMenuAgencia = this.menuAgencia();

                    if(opcionMenuAgencia == 8)
                    {
                        opcionMenuPrincipal = 0;
                        continue; // Salta a la proxima iteracion y "redirecciona" al menu principal
                    }

                    if (opcionMenuAgencia == 1) /* ~~~~~~~~~~~~ HOTELES ~~~~~~~~~~~~ */
                    {
                        opcionMenuAgencia = this.verHoteles(this.agencia);
                    }
                    else if (opcionMenuAgencia == 2) /* ~~~~~~~~~~~~ CABAÑAS ~~~~~~~~~~~~ */
                    {
                        menuCabania = this.menuCabania();

                        if (menuCabania == 1) /* ~~~~~~ RANGO DE PRECIOS ~~~~~~ */
                        {
                            double minimo = this.pedirPrecio("Ingrese el Minimo");
                            double maximo = this.pedirPrecio("Ingrese el Maximo");

                            menuCabania = this.verCabania(this.agencia, minimo, maximo);
                        }
                        else if(menuCabania == 2) /* ~~~~~~ TODAS LAS CABAÑAS ~~~~~~ */
                        {
                            menuCabania = this.verCabania(this.agencia);
                        }

                        salir = menuCabania == 9 ? true : salir;
                    }
                    else if (opcionMenuAgencia == 3) /* ~~~~~~~~~~~~ TODOS LOS ALOJAMIENTOS ~~~~~~~~~~~~ */
                    {
                        menuAlojamientos =  this.menuAlojamientos();

                        if (menuAlojamientos == 1) /* ~~~~~~ VER POR CODIGO ~~~~~~ */
                        {
                            this.agencia.OrderByCodigo();
                            menuAlojamientos = this.verAlojamientos(this.agencia);
                        }
                        else if(menuAlojamientos == 2) /* ~~~~~~ VER POR ESTRELLAS ~~~~~~ */
                        {
                            menuEstrellas = this.menuEstrellas();

                            if (menuEstrellas == 1) /* CON UN MINIMO */
                            {
                                int minimo = this.obtenerMinimoDeEstrellas();
                                menuEstrellas = this.verAlojamientos(this.agencia.MasEstrellas(minimo));

                            }
                            else if(menuEstrellas == 2) /* ORDEN ASC */
                            {
                                this.agencia.OrderByEstrellas();
                                menuEstrellas = this.verAlojamientos(this.agencia);
                            }

                            salir = menuEstrellas == 9 ? true : false;
                        }
                        else if(menuAlojamientos == 3) /* ~~~~~~ VER POR CANTIDAD DE PERSONAS ~~~~~~ */
                        {
                            this.agencia.OrderByCantidadDePersonas();
                            menuAlojamientos = this.verAlojamientos(this.agencia);
                        }

                        salir = menuAlojamientos == 9 ? true : salir;
                    }

                    // Salir
                    salir = opcionMenuAgencia == 9 ? true : salir;
                }

                if (salir) return; // Termina el programa

            } // Fin While
        }

        private int menuPrincipal()
        {
            String mensaje = " \n~~~~~~~~~~~~ Menu Principal ~~~~~~~~~~~~ \n\n";
            mensaje += "¿ Como desea ingresar al sistema ?\n\n";
            mensaje += "1.Administrador \n";
            mensaje += "2.Cliente \n";

            return this.validarOpcion(mensaje, new int[] { 1, 2 });
        }

        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
        /* ~~~~~~~~~~~~~~~~ ADMINISTRADOR ~~~~~~~~~~~~~~~~ */
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
        private bool loginAdmin()
        {
            String mensaje = "\n¡¡¡ Opcion incorrecta. Solo puede ingresar si/no !!!\n\n";
            bool login = false;

            this.cleanConsole();
            Console.WriteLine("\n¿ Desea iniciar sesion. (si/no) ? \n");
            String sesion = Console.ReadLine().ToLower();

            if (sesion == "no") return false;
            
            if (sesion == "si")
            {
                Console.WriteLine("\nIngrese su usuario");
                String user = Console.ReadLine();

                Console.WriteLine("Ingrese su contraseña");
                String password = Console.ReadLine();
                
                mensaje = "\nUsuario incorrecto...\n";

                if (user == App.USER_ADMIN && password == App.PASSWORD_ADMIN)
                {
                    mensaje = "\n\n!!! Bienvenido administrador !!!\n";
                    login = true;
                }
            }

            Console.WriteLine(mensaje); // Informacion del login
            Thread.Sleep(2000); // Pauso la ejecucion para mostrar el mensaje
            return login;
        }
        private int menuAgregarAlojamiento()
        {
            String mensaje = "\n~~~~~~~~ Agregar Alojamiento ~~~~~~~~\n\n";
            mensaje += "1. Hotel\n";
            mensaje += "2. Cabaña\n";
            mensaje += $"{this.agencia.LugaresParaAlojamientos()}\n\n\n";
            mensaje += "8. Cerrar Sesion\n";
            mensaje += "9. Salir";

            return this.validarOpcion(mensaje, new int[] { 1, 2, 8, 9 });
        }
        private void agregarHotel()
        {
            int codigo;
            String ciudad; 
            String barrio;
            int estrellas;
            int cantPersonas; 
            bool tv = false;
            double precioPorPersona;

            this.cleanConsole();
            Console.WriteLine("Ingrese los siguientes datos del Hotel\n");

            Console.WriteLine("Codigo");
            codigo = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ciudad");
            ciudad = Console.ReadLine();

            Console.WriteLine("Barrio");
            barrio = Console.ReadLine();

            Console.WriteLine("Precio por persona");
            precioPorPersona = Int32.Parse(Console.ReadLine());

            estrellas = this.validarOpcionConRango("Cantidad de estrellas del hotel", 1, 5, false);

            Console.WriteLine("Cantidad de personas por habitacion");
            cantPersonas = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Con television. (si o no)");
            String aux = Console.ReadLine().ToLower();
            tv = aux == "si" ? true : tv;

            this.agencia.AgregarAlojamiento(new Hotel(precioPorPersona, codigo, ciudad, barrio, estrellas, cantPersonas, tv));

            Console.WriteLine(); // Salto de linea
            Thread.Sleep(2000); // Informo si se agrego el alojamiento
        }
        private void agregarCabania()
        {            
            int codigo;
            String ciudad;
            String barrio;
            int estrellas;
            int cantPersonas;
            bool tv = false;
            double precioPorDia;
            int cantidadDeHabitaciones;
            int cantidadDeBanios;

            this.cleanConsole();
            Console.WriteLine("Ingrese los siguientes datos del Hotel\n");

            Console.WriteLine("Codigo");
            codigo = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ciudad");
            ciudad = Console.ReadLine();

            Console.WriteLine("Barrio");
            barrio = Console.ReadLine();
            
            estrellas = this.validarOpcionConRango("Cantidad de estrellas de la cabaña", 1, 5,false);

            Console.WriteLine("Cantidad de personas por habitacion");
            cantPersonas = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Con television. (si o no)");
            String aux = Console.ReadLine().ToLower();
            tv = aux == "si" ? true : tv;

            Console.WriteLine("Precio por dia");
            precioPorDia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cantidad de habitaciones");
            cantidadDeHabitaciones = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad de baños");
            cantidadDeBanios = Int32.Parse(Console.ReadLine());

            this.agencia.AgregarAlojamiento(new Cabania(precioPorDia,cantidadDeHabitaciones,cantidadDeBanios, codigo, ciudad, barrio, estrellas, cantPersonas, tv));

            Console.WriteLine(); // Salto de linea
            Thread.Sleep(2000); // Informo si se agrego el alojamiento
        }

        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
        /* ~~~~~~~~~~~~~~~~~~~ CLIENTE ~~~~~~~~~~~~~~~~~~~ */
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
        private int menuAgencia()
        {
            String mensaje = "\n~~~~~~~~ Menu de la Agencia ~~~~~~~~ \n\n";
            mensaje += "1. Ver Hoteles \n";
            mensaje += "2. Ver cabañas \n";
            mensaje += "3. Ver todo\n\n\n";
            mensaje += "8. Menu Principal\n";
            mensaje += "9. Salir";

            return this.validarOpcion(mensaje, new int[] { 1, 2, 3, 8, 9 });
        }
        private String footerAlojamiento()
        {
            String mensaje = "\n\n8. Menu de la Agencia\n";
            mensaje += "9. Salir";
            return mensaje;
        }

        /* ~~~~~~~~~~~~ HOTELES ~~~~~~~~~~~~ */
        private int verHoteles(Agencia agencia)
        {
            String mensaje = agencia.SoloHoteles().GetAllAlojamientos();
            mensaje += this.footerAlojamiento();

            return this.validarOpcion(mensaje, new int[] { 8, 9 });
        }

        /* ~~~~~~~~~~~~ CABAÑAS ~~~~~~~~~~~~ */
        private int verCabania(Agencia agencia)
        {
            String mensaje = this.agencia.SoloCabanias().GetAllAlojamientos();
            mensaje += this.footerAlojamiento();

            return this.validarOpcion(mensaje, new int[] { 8, 9 });
        }
        private int verCabania(Agencia agencia, double min, double max)
        {
            String mensaje = this.agencia.CabaniasEntrePrecios(min, max).GetAllAlojamientos();
            mensaje += this.footerAlojamiento();

            return this.validarOpcion(mensaje, new int[] { 8, 9 });
        }
        private int menuCabania()
        {
            String mensaje = "\n~~~~ Seleccione una opcion ~~~~\n\n";
            mensaje += "1. Ver por Rango de precio\n";
            mensaje += "2. Ver todas las cabañas\n";
            mensaje += this.footerAlojamiento();

            return this.validarOpcion(mensaje, new int[] { 1, 2, 8, 9 });
        }
        private double pedirPrecio(String mensaje)
        {
            double num1;
            
            this.cleanConsole();
            while (true)
            {
                try
                {
                    Console.WriteLine(mensaje);
                    num1 = Double.Parse(Console.ReadLine());
                    return num1;
                }
                catch(Exception e)
                {
                    this.cleanConsole();
                    Console.WriteLine("Solo puede ingresar numeros\n\n");
                }
            }

        }

        /* ~~~~~~~~~~~~ TODOS LOS ALOJAMIENTOS ~~~~~~~~~~~~ */
        private int menuAlojamientos()
        {
            String mensaje = "\n~~~~ Ordenar alojamientos por ~~~~\n\n";
            mensaje += "1. Codigo\n";
            mensaje += "2. Estrellas\n";
            mensaje += "3. Cantidad de Personas\n";
            mensaje += this.footerAlojamiento();

            return this.validarOpcion(mensaje, new int[] { 1, 2, 3, 8, 9 });
        }
        private int menuEstrellas()
        {
            String mensaje = "\n~~~~ Ver estrellas ~~~~\n\n";
            mensaje += "1. Con un minimo\n";
            mensaje += "2. De menor a mayor\n";
            mensaje += this.footerAlojamiento();

            return this.validarOpcion(mensaje, new int[] { 1, 2, 8, 9 });
        }
        private int obtenerMinimoDeEstrellas()
        {
            String mensaje = "Ingrese el minimo de estrellas";
            return this.validarOpcionConRango(mensaje, 1, 5);
        }
        private int verAlojamientos(Agencia agencia)
        {
            String mensaje = agencia.GetAllAlojamientos();
            mensaje += this.footerAlojamiento();

            return this.validarOpcion(mensaje, new int[] { 8, 9 });
        }

        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
        /* ~~~~~~~~~~~~~~~~~~~ HELPERS ~~~~~~~~~~~~~~~~~~~ */
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
        private int validarOpcion(String mensaje, int[] opcionesValidas)
        {
            this.cleanConsole();
            while (true)
            {
                Console.WriteLine(mensaje);
                int opcion = Int32.Parse(Console.ReadLine());

                if (Array.Exists(opcionesValidas, e => e == opcion)) return opcion;

                this.cleanConsole();
                this.mensajeOpcionIncorrecta();
            }
        }
        private int validarOpcionConRango(String mensaje, int min, int max, bool limpiarConsola = true)
        {
            if (limpiarConsola) { this.cleanConsole(); }
            while (true)
            {
                Console.WriteLine(mensaje);
                int opcion = Int32.Parse(Console.ReadLine());

                if (opcion >= min && opcion <= max) return opcion;

                if (limpiarConsola) { this.cleanConsole(); }
                this.mensajeOpcionIncorrecta($"Solo se permiten valores entre {min} y {max}");
            }
        }
        private void alojamientosPorDefecto()
        {
            this.agencia.AgregarAlojamiento(new Hotel(3200, 1234, "Buenos Aires", "Recoleta", 4, 3, true));
            this.agencia.AgregarAlojamiento(new Hotel(1000, 5265, "Mar del Plata", "Acantilados", 3, 2, false));
            this.agencia.AgregarAlojamiento(new Hotel(5500, 9678, "Buenos Aires", "Puerto Madero", 3, 5, true));
            this.agencia.AgregarAlojamiento(new Cabania(2400, 2, 1, 5678, "Carlos Paz", "Centro", 1, 4, true));
            this.agencia.AgregarAlojamiento(new Cabania(2000, 1, 1, 6789, "Rosario", "Barrio Parque", 1, 4, true));
            this.agencia.AgregarAlojamiento(new Cabania(4500, 2, 1, 5687, "Neuquen", "Villa la Angostura", 3, 2, true));
        }
        private void mensajeOpcionIncorrecta(String mensaje = "")
        {
            if (mensaje == "")
            {
                Console.WriteLine("\n¡¡¡ Opcion incorrecta. vuelva a intentarlo !!! \n");
            }
            else
            {
                Console.WriteLine($"\n¡¡¡ {mensaje} !!! \n");
            }
        }
        private void cleanConsole()
        {
            Console.Clear();
        }
    }
}