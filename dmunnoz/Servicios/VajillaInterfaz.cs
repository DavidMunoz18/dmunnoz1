using dmunnoz.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnoz.Servicios
{
    /// <summary>
    /// Clase que contiene los metodos relacionados con la gestion de la vajilla.
    /// <author>dmp - 041223</author>
    /// </summary>
    internal interface VajillaInterfaz
    {
        /// <summary>
        /// Metodo cuya funcionalidad es dar de alta a un nuevo stock de la vajilla.
        /// <author>dmp - 041223</author>
        /// </summary>
        /// <param name="listaVajilla"></param>
        public void darAltaElemento(List<VajillaDto> listaVajilla);

        /// <summary>
        /// Metodo que permite modificar el elemento.
        /// <author>dmp - 041223</author>
        /// </summary>
        /// <param name="listaVajilla"></param>
        public void modificarElemento(List<VajillaDto> listaVajilla);

        
    }
}
