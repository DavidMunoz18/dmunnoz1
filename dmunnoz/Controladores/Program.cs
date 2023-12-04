using dmunnoz.Dtos;
using dmunnoz.Servicios;

namespace dmunnoz.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación.
    /// <author>dmp - 041223</author>
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo de entrada de la aplicación.
        /// <author>dmp - 041223</author>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<VajillaDto> listaVajilla = new List<VajillaDto>();
            VajillaInterfaz vi = new VajillaImplementacion();
            MenuInterfaz mi = new MenuImplementacion();
            bool cerrarMenu = false;
            int opcionIntroducida;
            while(!cerrarMenu)
            {
                opcionIntroducida = mi.mostrarMenuYSeleccion();
                switch (opcionIntroducida)
                {
                    case 0:
                        Console.WriteLine("Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Se ejecuta caso 1");
                        vi.darAltaElemento(listaVajilla);
                        foreach (VajillaDto vajilla in listaVajilla)
                        {
                            Console.WriteLine(vajilla.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Se ejecuta caso 2");
                        vi.modificarElemento(listaVajilla);
                        foreach(VajillaDto vajilla in listaVajilla)
                        {
                            Console.WriteLine(vajilla.ToString());
                        }
                        break;

                        default:
                        Console.WriteLine("No se ha encontrado ninguna opcion");
                        break;
                }
            }
        }
    }
}