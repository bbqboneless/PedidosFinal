using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Pedidos
    {
        //private string _parts;
        private int _check = 0;

        public void Check(int n)
        {
            _check += n;
        }
        /*
        public void Add(string part)
        {
            _parts += part + " ";
        }
        */
        public override string ToString()
        {
            return _check.ToString();
        }
        
    }
}
