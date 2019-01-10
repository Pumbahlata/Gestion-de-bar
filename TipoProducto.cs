using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoProducto
    {
        public int idTipoProducto {get; set; }
        public string Descripcion {get;set;}

        public TipoProducto(string desc)
        {
            Descripcion = desc;
        }

        public TipoProducto(int id)
        {
            idTipoProducto = id;
        }

        public TipoProducto(string desc, int id)
        {
            Descripcion = desc;
            idTipoProducto = id;
        }
        public override string ToString()
        {
            return Descripcion;//+ idTipoProducto.ToString();
        }
    }
}
