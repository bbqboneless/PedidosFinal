using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class TipoContext
    {
        //clase context
        private BitacoraStrategy _strategy;
        //aqui vamos a definir la estrategia a utilizar
        public TipoContext(BitacoraStrategy strategy)
        {
            _strategy = strategy;
        }

        public List<string> Visualizar(List<string> actions)
        {
            if(_strategy == null)
            {
                return null;
            }
            else
            {
                return _strategy.Visualizar(actions);
            }
        }
    }
}
