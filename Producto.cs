using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int idProducto { get; set; }
        public TipoProducto TipoProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public Stock Stock { get; set; }
        public int Cantidad { get; set; }

        public Producto() { }

        public Producto(string nom, decimal pre)
        {
            Nombre = nom;
            Precio = pre;
        }

        public Producto(string nom, decimal pre, int cantidad)
        {
            Nombre = nom;
            Precio = pre;
            Cantidad = cantidad;
        }

        public Producto(string nom)
        {
            Nombre = nom;
        }

        public Producto(int cantidad)
        {
            Cantidad = cantidad;
        }

        public Producto(int id, int cant)
        {
            idProducto = id;
            Cantidad = cant;
        }

        public Producto (string nom, int cant)
        {
            Nombre = nom;
            Cantidad = cant;
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
