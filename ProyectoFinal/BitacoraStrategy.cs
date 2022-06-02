using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public abstract class BitacoraStrategy
    {
        //clase strategy
        public abstract List<string> Visualizar(List<string> actions);
    }
}
