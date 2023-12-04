using dmunnoz.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnoz.Servicios
{
    /// <summary>
    /// Clase que implementa los metodos de la interfaz
    /// <author>dmp - 041223</author>
    /// </summary>
    internal class VajillaImplementacion : VajillaInterfaz
    {
        MenuInterfaz mi = new MenuImplementacion();
        public void darAltaElemento(List<VajillaDto> listaVajilla)
        {
            VajillaDto vajilla = crearNuevoElemento();

            listaVajilla.Add(vajilla);
        }

        

        /// <summary>
        /// Metodo que muestra un menu con las opciones que puedes modificar
        /// <author>dmp - 041223</author>
        /// </summary>
        /// <returns></returns>
        private int mostrarMenuYSeleccionCampo()
        {
            int opcionIntroducida;
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Modificar la cantidad del stock");
            opcionIntroducida = Convert.ToInt32(Console.ReadLine());
            return opcionIntroducida;
        }
        /// <summary>
        /// Metodo que modifica el campo del elemento.
        /// <author>dmp - 041223</author>
        /// </summary>
        /// <param name="vajilla"></param>
        /// <param name="opcion"></param>
        /// <returns></returns>
        private bool modificarCampoElemento(VajillaDto vajilla, int opcion)
        {
            bool abrirMenu = true;
            switch (opcion)
            {
                case 0:
                    abrirMenu = false;
                    break;
                case 1:
                    Console.WriteLine("Indique la nueva cantidad");
                    vajilla.CantidadElemento = Convert.ToInt32(Console.ReadLine());

                    break;

                default:
                    Console.WriteLine("No se encuentra ninguna opcion seleccionada");
                    break;
            }
            return abrirMenu;
        }
        /// <summary>
        /// Metodo que permite introducir los nuevos elementos que se van a mostrar por pantalla.
        /// <author>dmp - 041223</author>
        /// </summary>
        /// <returns></returns>
        private VajillaDto crearNuevoElemento()
        {
            VajillaDto vajilla = new VajillaDto();

            Console.WriteLine("Introduzca el id");
            vajilla.IdElemento = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el nombre del elemento");
            vajilla.NombreElemento = Console.ReadLine();

            Console.WriteLine("Introduzca la descripcion del elemento");
            vajilla.DescripcionElemento = Console.ReadLine();

            Console.WriteLine("Introduzca la cantidad del elemento");
            vajilla.CantidadElemento = Convert.ToInt32(Console.ReadLine());

            return vajilla;
        }

        public void modificarElemento(List<VajillaDto> listaVajilla)
        {
            VajillaDto vajillaDto = new VajillaDto();
            string codigoE = mi.pedirStock();

            
            foreach(VajillaDto vajilla in listaVajilla)
            {
                if(vajilla.CodigoElemento.Equals(codigoE))
                {
                    int opcion = mostrarMenuYSeleccionCampo();
                    bool control = true;
                    while (control)
                    {
                        control = modificarCampoElemento(vajilla, opcion);
                        break;
                    }

                }
                
            }
            
        }
    }
}
