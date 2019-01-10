using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public Mesa Mesa { get; set; }
        public Producto Producto { get; set; }
        public List<Producto> Productos { get; set; }
        public Empleado Empleado { get; set; }
        public FormaDePago FormaDePago {get;set;}
        public Pedido() { }

        public Pedido(List<Producto> ListaProductos)
        {
            Productos = ListaProductos;
        }

        public Pedido(int idpedido)
        {
            IdPedido = idpedido;
        }
        
    }
}
