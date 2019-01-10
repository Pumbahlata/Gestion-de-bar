using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mesa
    {
        public int idMesa { get; set; }
        public int idEstado { get; set; }
        public Mesa() { }
        public Mesa(int idmesa,int idestado)
        {
            idMesa = idmesa;
            idEstado = idestado;
        }

        public Mesa(int idmesa)
        {
            idMesa = idmesa;
        }

        public override string ToString()
        {
            return idMesa.ToString();
        }
    }

    
}
