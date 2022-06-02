using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public abstract class PedidosBuilder
    {
        public abstract void PrepararInformacion();
        public abstract void CapturarPedido(string p1,int c1,string p2,int c2,string p3,int c3);
        public abstract void GenerarQR();
        public abstract Pedidos GetPedido();
    }
}
