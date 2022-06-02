using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class TxtFile : BitacoraStrategy
    {
        public override List<string> Visualizar(List<string> actions)
        {
            string p = @"Archivos\bit.txt";
            using (StreamWriter sw = File.AppendText(p))
            {
                foreach(string s in actions)
                {
                    sw.WriteLine(s);
                }
            }
            List<string> path = new List<string>();
            path.Add(p);
            return path;
        }
    }
}
