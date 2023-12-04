using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnoz.Servicios
{
    /// <summary>
    /// Clase que contiene los metodos relacionados con el menu.
    /// <author>dmp - 041223</author>
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y permite seleccionar una opcion al usuario.
        /// <author>dmp - 041223</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();

        /// <summary>
        /// Metodo que pide al usuario el codigo del elemento
        /// <author>dmp - 041223</author>
        /// </summary>
        /// <returns></returns>
        public string pedirStock();
        
        
    }
}
