using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoEmpleado
    {
        public int IdTipoEmpleado { get; set; }
        public string Descripcion { get; set; }
        public TipoEmpleado() { }
        public TipoEmpleado(int id) { IdTipoEmpleado = id; }
        public TipoEmpleado(string Desc) { Descripcion = Desc; }
        public TipoEmpleado(int id, string Desc)
        {
            IdTipoEmpleado = id;
            Descripcion = Desc;
        }
        public TipoEmpleado(string desc,int id)
        {
            Descripcion = desc;
            IdTipoEmpleado = id;
        }
        
        public override string ToString()
        {
            return Descripcion;
        }
        
    }
}
