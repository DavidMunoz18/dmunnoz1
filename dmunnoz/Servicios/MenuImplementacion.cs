using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnoz.Servicios
{
    /// <summary>
    /// Clase que implementa los metodos creados en la interfaz.
    /// <author>dmp - 041223</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("########################");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Dar de alta un nuevo stock de vajilla");
            Console.WriteLine("2. Modificar cierta cantidad de stock de vajilla");
            Console.WriteLine("########################");
            opcionIntroducida = Console.ReadKey(true).KeyChar - '0';
            return opcionIntroducida;
        }

        

        public string pedirStock()
        {
            Console.WriteLine("Indique el codigo del elemento");
            string codigoElemento = Console.ReadLine();
            return codigoElemento;
        }
    }
}
