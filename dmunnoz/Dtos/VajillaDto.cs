using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnoz.Dtos
{
    internal class VajillaDto
    {
        //Atributos
        long idElemento;
        string codigoElemento = "aaaaa";
        string nombreElemento = "aaaaa";
        string descripcionElemento = "aaaaa";
        int cantidadElemento = 0;

        //get y set
        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

        //constructores
        public VajillaDto(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = idElemento + nombreElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }

        public VajillaDto()
        {
        }
        //metodo TO STRING
        override
        public string ToString()
        {
            string vajillaString = "id: " + this.idElemento
                + "  codigo: " + this.idElemento
                + this.nombreElemento 
                + "  nombre: " + this.nombreElemento
                + "  descripcion: " + this.descripcionElemento
                + "  cantidad: " + this.cantidadElemento;
            return vajillaString;
        }
    }
}
