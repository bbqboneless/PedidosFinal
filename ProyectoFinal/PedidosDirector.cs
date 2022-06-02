using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class PedidosDirector
    {
        public void ConstructPedido(PedidosBuilder builder, string p1, int c1, string p2, int c2, string p3, int c3) {
            builder.PrepararInformacion();
            builder.CapturarPedido(p1,c1,p2,c2,p3,c3);
            builder.GenerarQR();
        }
    }
}
