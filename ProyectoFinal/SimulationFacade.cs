using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class SimulationFacade
    {
        private Camiones _camiones;
        private Verificacion _verificacion;
        private Ascendente _asc;
        private Sortear _sort;

        public SimulationFacade()
        {
            _camiones = new Camiones();
            _verificacion = new Verificacion();
            _asc = new Ascendente();
            _sort = new Sortear();
        }

        public List<int> MethodCam()
        {
            return _camiones.Simulacion();
        }

        public List<bool> MethodVerify(List<int>list, int c1, int c2, int c3)
        {
            return _verificacion.Checar(list,c1,c2,c3);
        }

        public List<string> MethodOrder()
        {
            return _asc.Iterar();
        }

        public Dictionary<string, int> MethodSort()
        {
            return _sort.Sorting();
        }

    }
}
