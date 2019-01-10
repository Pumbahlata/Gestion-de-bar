using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuarios
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int TipoAcceso { get; set; }
        public int Legajo { get; set; }

        public Usuarios()
        {

        }
    }
}
