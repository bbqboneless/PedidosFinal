using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class VistaGrid : BitacoraStrategy
    {
        public override List<string> Visualizar(List<string> actions)
        {
            //string[] lineas = File.ReadAllLines(@"Archivos\bit.txt");
            List<string> lineastxt = new List<string>();

            foreach (string line in actions)
            {
                lineastxt.Add(line);
                /*
                string[] partes = line.Split('\n');
                foreach (string l in partes)
                {
                    lineastxt.Add(l);
                }
                */

            }
            return lineastxt;
        }
    }
}
