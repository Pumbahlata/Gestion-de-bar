using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FormaDePago
    {
        public int idPago { get; set; }
        public string Descripcion { get; set; }

        public FormaDePago(int id)
        {
            idPago = id;
        }

        public FormaDePago(string desc)
        {
            Descripcion = desc;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
