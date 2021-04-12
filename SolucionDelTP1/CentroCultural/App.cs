using System;

namespace CentroCultural
{
  public class App
  {
    private ObrasExposicion obrasExposicion;
    private ArtistasExposicion artistasExposicion;

    public App()
    {
      Console.Title = "Centro Cultural";
      this.obrasExposicion = new ObrasExposicion();
      this.artistasExposicion = new ArtistasExposicion();
      this.obrasPorDefecto();
      this.artistasPorDefecto();
    }

    public void iniciar()
    {
      while (true)
      {
        int opcionMenuPrincipal = menuPrincipal();

        switch (opcionMenuPrincipal)
        {
          case 1:
            int opcionMenuCC = menuCC();
            break;
          case 2:
            int opcionMenuArtistas = menuArtistas();
            switch (opcionMenuArtistas)
            {
              case 1:
                this.agregarArtista();
                break;
              case 2:
                this.cantidadArtistas();
                break;
              case 3:
                this.verArtistas();
                break;
              case 4:
                break;
              case 5:
                break;
              default:
                break;
            }
            break;
          case 3:
            int opcionMenuObras = menuObras();
            break;
          case 4:
            break;
          default:
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
      mensaje += "1. Centro Cultural\n";
      mensaje += "2. Artistas\n";
      mensaje += "3. Obras\n";
      mensaje += "4. Salir";

      return Convert.ToInt32(Console.ReadLine());
    }
    public int menuCC()
    {
      String mensaje = "\n~~~~~~~~ Menu Centro Cultural ~~~~~~~~\n\n";
      mensaje += "1. Filtro Nacionalidad\n";
      mensaje += "2. Filtro Galeria\n";
      mensaje += "3. Salir";

      return Convert.ToInt32(Console.ReadLine());
    }
    public int menuArtistas()
    {
      String mensaje = "\n~~~~~~~~ Menu Artistas ~~~~~~~~\n\n";
      mensaje += "1. Ingresar Artista\n";
      mensaje += "2. Cantidad de Artistas\n";
      mensaje += "3. Ver Artistas\n";
      mensaje += "4. Filtro Nacionalidad\n";
      mensaje += "5. Salir";

      return Convert.ToInt32(Console.ReadLine());
    }
    public int menuObras()
    {
      String mensaje = "\n~~~~~~~~ Menu Obras ~~~~~~~~\n\n";
      mensaje += "1. Ingresar Obras\n";
      mensaje += "2. Cantidad Obras\n";
      mensaje += "3. Ver Obras\n";
      mensaje += "4. Filtro por Nombre de Artista";
      mensaje += "5. Filtro Cuadros prestados";

      return Convert.ToInt32(Console.ReadLine());
    }

    public void verArtistas()
    {

    }
    public int cantidadArtistas()
    {
      Console.WriteLine(this.artistasExposicion.cantidadArtistas().ToString());
      return this.artistasExposicion.cantidadArtistas();
    }

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

      this.artistasExposicion.insertarArtista(new Artista(nombre, nacionalidad, anioNac, mesNac, diaNac, anioFal, mesFal, diaFal));
    }

    public void obrasPorDefecto()
    {
      this.obrasExposicion.insertarObra(new Cuadro(30, 60, 1111, 1801, "Cuadro1", "ArtistaCuadro1", 1750, 1, 1));
      this.obrasExposicion.insertarObra(new Cuadro(20, 70, 2222, 1802, "Cuadro2", "ArtistaCuadro2", 1760, 2, 10));
      this.obrasExposicion.insertarObra(new Escultura(15, 30, 3333, 1803, "Escultura1", "ArtistaEscultura1", 1770, 3, 15));
      this.obrasExposicion.insertarObra(new Escultura(10, 20, 4444, 1804, "Escultura2", "ArtistaEscultura2", 1780, 4, 20));
      this.obrasExposicion.insertarObra(new CuadroPrestado(1990, 4, 2, "Pepito Galery", 15, 25, 5555, 1805, "CuadroPrestado1", "ArtistaCuadroPrestado1", 1790, 5, 25));
    }

    public void artistasPorDefecto()
    {
      this.artistasExposicion.insertarArtista(new Artista("ArtistaArtista1", "Argentino", 1800, 1, 1, 1880, 2, 2));
      this.artistasExposicion.insertarArtista(new Artista("ArtistaArtista2", "Brasil", 1810, 2, 11, 1890, 3, 21));
      this.artistasExposicion.insertarArtista(new Artista("ArtistaArtista3", "Uruguay", 1820, 3, 12, 1900, 4, 22));
      this.artistasExposicion.insertarArtista(new Artista("ArtistaArtista4", "Peru", 1830, 4, 13, 1910, 5, 23));
      this.artistasExposicion.insertarArtista(new Artista("ArtistaArtista5", "Chile", 1840, 5, 14, 1920, 6, 24));
    }
  }
}