using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Reservas
    {
        public int Dni { get; set; }
        public int IdReserva { get; set; }
        public string Nombre { get; set; }
        public Mesa Mesa { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int Estado { get; set; }
    }
}
