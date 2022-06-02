using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Camiones
    {
        public List<int> Simulacion()
        {
            string path = @"Jsons";
            string[] files = Directory.GetFiles(path);
            List<int> c = new List<int>();
            foreach (string f in files)
            {
                using (StreamReader jsonStream = File.OpenText(f))
                {
                    var json = jsonStream.ReadToEnd();
                    Orden deserialize = JsonConvert.DeserializeObject<Orden>(json);
                    string nombre = deserialize.NombreTienda;
                    int id = deserialize.IDTienda;
                    List<Pedido> list = deserialize.orden;
                    foreach (Pedido pe in list)
                    {
                        c.Add(pe.Cantidad);
                    }
                }
            }
            int r = c[0] + c[3] + c[6];
            int p = c[1] + c[4] + c[7];
            int v = c[2] + c[5] + c[8];
            List<int> cantidades = new List<int>();
            cantidades.Add(r);
            cantidades.Add(p);
            cantidades.Add(v);
            /*
            foreach(int i in c)
            {
                Console.WriteLine(i.ToString() + ' ');
            }

            Console.WriteLine("Refrescos:" + r + ", Panes:" + p + ", Verduras:" + v);
            */
            return cantidades;
        }
    }
}
