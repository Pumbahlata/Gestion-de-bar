using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cuenta
    {
        public int idCuenta { get; set; }
        public Pedido Pedido { get; set; }
        public Mesa Mesa { get; set; }
        public Empleado Mesero { get; set; }
        public FormaDePago FormaDePago { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ImporteTotal { get; set; }

        public Cuenta() { }


        public Cuenta(int id)
            {
            idCuenta = id;
            }

    }
}
