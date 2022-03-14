using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsProducto
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int categoria { get; set; }
        public decimal precioCosto { get; set; }
        public decimal porcUtilidad { get; set; }
        public int impuesto { get; set; }
        public decimal cantidadStock { get; set; }
        public bool estado { get; set; }
    }
}
