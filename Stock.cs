using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Stock
    {
        public int IdProducto { get; set; }
        public int StockDisponible { get; set; }
        public Stock() { }
        public Stock(int st)
        {
            StockDisponible = st;
        }

        public override string ToString()
        {
            return StockDisponible.ToString();
        }
     
    }
}
