using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Ascendente
    {
        public List<string> Iterar()
        {
            List<string> surtido = new List<string>();
            string path = @"Jsons";
            string[] files = Directory.GetFiles(path);
            foreach(string f in files)
            {
                int ganancia = 0;
                using (StreamReader jsonStream = File.OpenText(f))
                {
                    var json = jsonStream.ReadToEnd();
                    Orden deserialize = JsonConvert.DeserializeObject<Orden>(json);
                    string nombre = deserialize.NombreTienda;
                    int id = deserialize.IDTienda;
                    List<Pedido> list = deserialize.orden;
                    surtido.Add(nombre);
                    //Console.WriteLine("Nombre: " + nombre + ", ID: " + id);
                    foreach(Pedido p in list)
                    {
                        surtido.Add(p.Nombre);
                        surtido.Add(p.Cantidad.ToString());
                        ganancia += (p.Cantidad * p.Precio);
                    }
                    //Console.WriteLine("Ganancia:"+ganancia);
                }
                surtido.Add(ganancia.ToString());
            }
            /*
            foreach(string s in surtido)
            {
                Console.WriteLine(s);
            }
            */
            
            return surtido;
            
        }
    }
}
