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
      return 1;
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


    }

    public void obrasPorDefecto()
    {

    }

    public void artistasPorDefecto()
    {

    }
  }
}