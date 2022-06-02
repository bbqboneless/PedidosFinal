using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class VistaTextbox : BitacoraStrategy
    {
        public override List<string> Visualizar(List<string> actions)
        {
            //string[] lineas = File.ReadAllLines(@"Archivos\bit.txt");
            List<string> lineastxt = new List<string>();
            lineastxt.Add("Bitacora Textbox View");
            int cont = 1;
            foreach (string line in actions)
            {
                string aux = cont.ToString() + ".- " + line;
                lineastxt.Add(aux);
                cont += 1;
                /*
                string[] partes = line.Split('\n');
                foreach (string l in partes)
                {
                    string s = cont.ToString() + ".- " + l;
                    lineastxt.Add(s);
                }
                */

            }
            return lineastxt;
        }
    }
}
