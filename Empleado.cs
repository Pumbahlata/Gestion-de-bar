using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado
    {
        public int Legajo { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public TipoEmpleado TipoEmpleado { get; set; }

        public Empleado() { }
        public Empleado(int legajo)
        {
            Legajo = legajo;
        }
        public Empleado(string nom, string ape,int legajo)
        {
            Nombre = nom;
            Apellido = ape;
            Legajo = legajo;
        }

        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {

            return Nombre + " " + Apellido;
        }
    }
}
