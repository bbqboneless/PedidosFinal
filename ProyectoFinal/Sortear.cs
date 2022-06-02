using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Sortear
    {
        public Dictionary<string, int> Sorting()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<string, int> sorted = new Dictionary<string, int>();
            string path = @"Jsons";
            string[] files = Directory.GetFiles(path);
            foreach (string f in files)
            {
                int ganancia = 0;
                using (StreamReader jsonStream = File.OpenText(f))
                {
                    var json = jsonStream.ReadToEnd();
                    Orden deserialize = JsonConvert.DeserializeObject<Orden>(json);
                    string nombre = deserialize.NombreTienda;
                    int id = deserialize.IDTienda;
                    List<Pedido> list = deserialize.orden;
                    //Console.WriteLine("Nombre: " + nombre + ", ID: " + id);
                    foreach (Pedido p in list)
                    {
                        ganancia += (p.Cantidad * p.Precio);
                    }
                    dict.Add(nombre, ganancia);
                }
            }
            
            foreach(KeyValuePair<string,int> x in dict.OrderByDescending(key => key.Value))
            {
                sorted.Add(x.Key,x.Value);
            }
            
            
            return sorted;
        }

    }
}
