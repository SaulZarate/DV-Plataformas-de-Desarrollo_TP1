using System;
using System.Threading;
using System.Collections.Generic;

namespace CentroCultural
{
  public class App
  {
    private CentroCultural centroCultural;
    public App()
    {
      Console.Title = "Centro de cultura internacional";
      this.centroCultural = new CentroCultural("Centro de cultura internacional");
    }
    public void iniciar()
    {
      Boolean menuPrincipalQuit = false;
      while (!menuPrincipalQuit)
      {
        int opcionMenuPrincipal = menuPrincipal();
        Console.Clear();
        switch (opcionMenuPrincipal)
        {
          case 1: // Artistas
            Boolean menuArtistasQuit = false;
            while (!menuArtistasQuit)
            {
              int opcionMenuArtistas = this.menuArtistas();
              Console.Clear();
              switch (opcionMenuArtistas)
              {
                case 1: // Ingresar Artista
                  this.agregarArtista();
                  break;
                case 2: // Ver Artistas
                  this.verArtistas();
                  break;
                case 3: // Filtro Nacionalidad
                  this.verArtistasPorNacionalidad();
                  break;
                case 4: // Salir
                  menuArtistasQuit = true;
                  break;
                default: // Opcion Incorrecta
                  Console.WriteLine(opcionMenuArtistas + " es una opcion invalida\n");
                  break;
              }
            }
            break;
          case 2: // Obras
            Boolean menuObrasQuit = false;
            while (!menuObrasQuit)
            {
              int opcionMenuObras = this.menuObras();
              Console.Clear();
              switch (opcionMenuObras)
              {
                case 1: // Ingreso de Cuadro
                  this.agregarCuadro();
                  break;
                case 2: // Ingreso Escultura
                  this.agregarEscultura();
                  break;
                case 3: // Ingreso de Cuadro prestado
                  this.agregarCuadroPrestado();
                  break;
                case 4: // Ver todas las Obras
                  this.verTodasObras();
                  break;
                case 5: // Ver Obras por Nombre de Artista
                  this.verObrasPorArtista();
                  break;
                case 6: // Ver Obras por Nacionalidad de Artista
                  this.verObrasPorNacionalidad();
                  break;
                case 7: // Ver Obras por Año de Creacion
                  this.verObrasPorAnioCreacion();
                  break;
                case 8: // Ver Cuadros por Nombre de Galeria
                  this.verCuadrosPorGaleria();
                  break;
                case 9: // Ver Cuadros Prestados
                  this.verCuadrosPrestados();
                  break;
                case 10: // Salir
                  menuObrasQuit = true;
                  break;
                default: // Opcion Invalida
                  Console.WriteLine(opcionMenuObras + " es una opcion invalida\n");
                  break;
              }
            }
            break;
          case 3: // Salir
            menuPrincipalQuit = true;
            Console.WriteLine("Adios!");
            break;
          default: // Opcion Incorrecta
            Console.WriteLine(opcionMenuPrincipal + " es una opcion invalida\n");
            break;
        }
      }
    }

    /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
    /* ~~~~~~~~~~~~~~~~~~~~ MENUS ~~~~~~~~~~~~~~~~~~~~ */
    /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
    public int menuPrincipal()
    {
      String mensaje = "\n~~~~~~~~ Bienvenido al Centro Cultural ~~~~~~~~\n\n";
      mensaje += "1. Artistas\n";
      mensaje += "2. Obras\n";
      mensaje += "3. Salir";

      Console.WriteLine(mensaje);

      return Convert.ToInt32(Console.ReadLine());
    }
    public int menuArtistas()
    {
      String mensaje = "\n~~~~~~~~ Menu Artistas ~~~~~~~~\n\n";
      mensaje += "1. Ingresar Artista\n";
      mensaje += "2. Ver Artistas\n";
      mensaje += "3. Ver Artistas por Nacionalidad\n";
      mensaje += "4. Salir";

      Console.WriteLine(mensaje);

      return Convert.ToInt32(Console.ReadLine());
    }
    public int menuObras()
    {
      String mensaje = "\n~~~~~~~~ Menu Obras ~~~~~~~~\n\n";
      mensaje += "1. Ingresar Cuadro\n";
      mensaje += "2. Ingresar Escultura\n";
      mensaje += "3. Ingresar CuadroPrestado\n";

      mensaje += "4. Ver Todas las Obras\n";
      mensaje += "5. Ver Obras por Nombre de Artista\n";
      mensaje += "6. Ver Obras por Nacionalidad de Artista\n";
      mensaje += "7. Ver Obras por Año de Creacion\n";
      mensaje += "8. Ver Cuadros por Nombre de Galeria\n";
      mensaje += "9. Ver Cuadros Prestados\n";
      mensaje += "10. Salir\n";

      Console.WriteLine(mensaje);

      return Convert.ToInt32(Console.ReadLine());
    }

    /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
    /* ~~~~~~~~~~~~~~~~~~ Artistas ~~~~~~~~~~~~~~~~~~~ */
    /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */

    private void agregarArtista()
    {
      String nombre, nacionalidad;
      int anioNac, mesNac, diaNac, anioFal, mesFal, diaFal;

      Console.Clear();

      Console.WriteLine("Ingrese datos del Artista\n");

      Console.WriteLine("Nombre");
      nombre = Console.ReadLine();

      Console.WriteLine("Nacionalidad");
      nacionalidad = Console.ReadLine();

      Console.WriteLine("Año nacimiento (num)");
      anioNac = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Mes nacimiento (num)");
      mesNac = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Dia nacimiento (num)");
      diaNac = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Año Fallecimiento (num)");
      anioFal = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Mes Fallecimiento (num)");
      mesFal = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Dia Fallecimiento (num)");
      diaFal = Int32.Parse(Console.ReadLine());

      this.centroCultural.agregarArtista(new Artista(nombre, nacionalidad, anioNac, mesNac, diaNac, anioFal, mesFal, diaFal));
      Console.WriteLine(); // Salto de linea
      Thread.Sleep(2000); // Informo si se agrego el alojamiento
    }

    private void verArtistas()
    {
      String mensaje = this.centroCultural.ObtenerTodosLosArtistas();
      Console.WriteLine(mensaje);
    }

    public void verArtistasPorNacionalidad()
    {
      String nacionalidad;
      Console.Clear();
      Console.WriteLine("Ingrese Nacionalidad del Artista\n");
      nacionalidad = Console.ReadLine();

      List<String> artistas = this.centroCultural.NombreArtistasNacionalidad(nacionalidad);
      foreach (String artista in artistas)
      {
        Console.WriteLine(artista);
      }
    }

    /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
    /* ~~~~~~~~~~~~~~~~~~~~ Obras ~~~~~~~~~~~~~~~~~~~~ */
    /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */

    public void agregarCuadro()
    {
      String nombre, nombreArtista;
      int baseCuadro, altura, codigo, anioCreacion, anio, mes, dia;

      Console.Clear();

      Console.WriteLine("Ingrese datos del Cuadro\n");

      Console.WriteLine("Nombre del Cuadro");
      nombre = Console.ReadLine();

      Console.WriteLine("Nombre del Artista");
      nombreArtista = Console.ReadLine();

      Console.WriteLine("Codigo");
      codigo = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Base (num)");
      baseCuadro = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Altura (num)");
      altura = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Año Creacion (num)");
      anioCreacion = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Año ingreso CentroCultural (num)");
      anio = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Mes ingreso CentroCultural (num)");
      mes = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Dia ingreso CentroCultural (num)");
      dia = Int32.Parse(Console.ReadLine());

      this.centroCultural.agregarObra(new Cuadro(baseCuadro, altura, codigo, anioCreacion, nombre, nombreArtista, anio, mes, dia));
      Console.WriteLine();
      Thread.Sleep(2000);
    }

    public void agregarEscultura()
    {
      String nombre, nombreArtista;
      int peso, volumen, codigo, anioCreacion, anio, mes, dia;

      Console.WriteLine("Ingrese datos de la Escultura\n");

      Console.WriteLine("Nombre del Escultura");
      nombre = Console.ReadLine();

      Console.WriteLine("Nombre del Artista");
      nombreArtista = Console.ReadLine();

      Console.WriteLine("Codigo");
      codigo = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Peso (num)");
      peso = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Volumen (num)");
      volumen = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Año Creacion (num)");
      anioCreacion = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Año ingreso CentroCultural (num)");
      anio = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Mes ingreso CentroCultural (num)");
      mes = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Dia ingreso CentroCultural (num)");
      dia = Int32.Parse(Console.ReadLine());

      this.centroCultural.agregarObra(new Escultura(peso, volumen, codigo, anioCreacion, nombre, nombreArtista, anio, mes, dia));
      Console.WriteLine();
      Thread.Sleep(2000);
    }

    public void agregarCuadroPrestado()
    {
      String nombre, nombreArtista, nombreGaleria;
      int baseCuadro, altura, codigo, anioCreacion, anio, mes, dia, anioDevo, mesDevo, diaDevo;

      Console.Clear();

      Console.WriteLine("Ingrese datos del Cuadro\n");

      Console.WriteLine("Nombre del Cuadro prestado");
      nombre = Console.ReadLine();

      Console.WriteLine("Nombre del Artista");
      nombreArtista = Console.ReadLine();

      Console.WriteLine("Codigo");
      codigo = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Nombre de la Galeria");
      nombreGaleria = Console.ReadLine();

      Console.WriteLine("Base (num)");
      baseCuadro = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Altura (num)");
      altura = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Año Creacion (num)");
      anioCreacion = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Año ingreso CentroCultural (num)");
      anio = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Mes ingreso CentroCultural (num)");
      mes = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Dia ingreso CentroCultural (num)");
      dia = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Año de Devolucion (num)");
      anioDevo = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Mes de Devolucion (num)");
      mesDevo = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Dia de Devolucion (num)");
      diaDevo = Int32.Parse(Console.ReadLine());

      this.centroCultural.agregarObra(new CuadroPrestado(anioDevo, mesDevo, diaDevo, nombreGaleria, baseCuadro, altura, codigo, anioCreacion, nombre, nombreArtista, anio, mes, dia));
      Console.WriteLine();
      Thread.Sleep(2000);
    }

    public void verTodasObras()
    {
      String mensaje = this.centroCultural.ObtenerTodasLasObras();
      Console.WriteLine(mensaje);
    }

    public void verObrasPorArtista()
    {
      String nombreArtista;
      Console.Clear();
      Console.WriteLine("Ingrese Nombre del Artista\n");
      nombreArtista = Console.ReadLine();

      String mensaje = this.centroCultural.ObtenerObrasPorNombreDeArtista(nombreArtista);
      Console.WriteLine(mensaje);
    }

    public void verObrasPorNacionalidad()
    {
      String nacionalidad;
      Console.Clear();
      Console.WriteLine("Ingrese Nacionalidad del Artista\n");
      nacionalidad = Console.ReadLine();

      List<String> obras = this.centroCultural.NombresObrasNacionalidad(nacionalidad);
      foreach (String obra in obras)
      {
        Console.WriteLine(obra);
      }
    }

    public void verObrasPorAnioCreacion()
    {
      String mensaje = this.centroCultural.ObtenerObrasOrdenasPorAnioDeCreacion();
      Console.WriteLine(mensaje);
    }

    public void verCuadrosPorGaleria()
    {
      String nombreGaleria;
      Console.Clear();
      Console.WriteLine("Ingrese Nombre de la Galeria\n");
      nombreGaleria = Console.ReadLine();

      List<String> cuadros = this.centroCultural.NombreCuadrosGaleria(nombreGaleria);
      foreach (String cuadro in cuadros)
      {
        Console.WriteLine(cuadro);
      }
    }

    public void verObrasDeArtistaPorNacionalidad()
    {
      String nacionalidad;
      Console.Clear();
      Console.WriteLine("Ingrese Nacionalidad del Artista\n");
      nacionalidad = Console.ReadLine();

      this.centroCultural.NombresObrasNacionalidad(nacionalidad);
    }

    public void verCuadrosPrestados()
    {
      String mensaje = this.centroCultural.ObtenerTodosLosCuadrosPrestados();
      Console.WriteLine(mensaje);
    }

    public void verObrasDeArtistaPorNombre()
    {
      String nombre;
      Console.Clear();
      Console.WriteLine("Ingrese Nacionalidad del Artista\n");
      nombre = Console.ReadLine();

      this.centroCultural.ObtenerObrasPorNombreDeArtista(nombre);
    }

  }
}