using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Orden
    {
        public string NombreTienda { get; set; }
        public int IDTienda { get; set; }
        public List<Pedido> orden { get; set; }
    }
}
