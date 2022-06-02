using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class LeerQR : Form
    {
        public List<string> actions = new List<string>();
        public LeerQR(List<string>a)
        {
            InitializeComponent();
            actions = a;
            string path = @"Archivos\bit.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (FileStream fs = File.Create(path)) { }
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult dr = open.ShowDialog();
            open.Filter = "Image PNG (*.png)|*.png";
            string t = "";
            //Lo que hacemos es poner la imagen en un picture box con su nombre y ID para verificar que es la tienda que
            //queremos capturar. Si es así simplemente vamos a capturar el pedido.
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);

                string strPath = open.FileName;
                label1.Text = strPath;
                var filename = Path.GetFileName(strPath);
                string path = "";

                if (filename == "Tienda1.png")
                {
                    t = "Tienda 1";
                    path = @"Jsons\JSONTienda1.json";
                }
                else if (filename == "Tienda2.png")
                {
                    t = "Tienda 2";
                    path = @"Jsons\JSONTienda2.json";
                }
                else if (filename == "Tienda3.png")
                {
                    t = "Tienda 3";
                    path = @"Jsons\JSONTienda3.json";
                }

                using (StreamReader jsonStream = File.OpenText(path))
                {
                    var json = jsonStream.ReadToEnd();
                    Orden deserialize = JsonConvert.DeserializeObject<Orden>(json);
                    label1.Text = deserialize.NombreTienda;
                    label2.Text = deserialize.IDTienda.ToString();
                }
                label6.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            else
            {
                return;
            }

            string action = "QR "+t+" leido.";
            actions.Add(action);
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //brinca a la Forma para capturar pedidos e iniciar el proceso de pedido
            
            string action = "Crear pedido.";
            actions.Add(action);
            new CapturaPedidos(label1.Text,label2.Text,actions).Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string action = "Comienzo de Simulación.";
            actions.Add(action);
            new Simulacion(actions).Show();
            Hide();
        }
    }
}
