using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Simulacion : Form
    {
        public List<string> actions = new List<string>();
        public Simulacion(List<string> a)
        {
            InitializeComponent();
            actions = a;
            var facade = new SimulationFacade();
            List<int> list = facade.MethodCam();
            List<string> prod = new List<string>() { "Refrescos","Panes","Verduras"};

            for(int i = 0;i < list.Count; i++)
            {
                string[] st = { prod[i], list[i].ToString() };
                dataGridView1.Rows.Add(st);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var facade = new SimulationFacade();
            List<int> list = facade.MethodCam();

            string cp1 = label3.Text.Trim();
            int c1 = Convert.ToInt32(Math.Round(camiones1.Value, 0)); ;
            string cp2 = label4.Text.Trim();
            int c2 = Convert.ToInt32(Math.Round(camiones2.Value, 0)); ;
            string cp3 = label5.Text.Trim();
            int c3 = Convert.ToInt32(Math.Round(camiones3.Value, 0)); ;

            var facade2 = new SimulationFacade();
            List<bool> check = facade2.MethodVerify(list,c1,c2,c3);
            string message = "";
            int verified = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int sobra = 0;
                if(i == 0)
                {
                    //Refrescos
                    sobra = 120-(list[i] % 120);
                    //message += "R:" + sobra + "Refresco\n";
                    if(check[i] == true)
                    {
                        verified += 1;
                        message += "Se cumple demanda de Refrescos y sobran " + sobra + "\n";
                    }
                    else
                    {
                        message += "Agregar/Quitar camiones de Refrescos\n";
                        string action = "Agregar camión de Refresco.";
                        actions.Add(action);
                    }
                }else if(i == 1)
                {
                    //Panes
                    sobra = 270 - (list[i] % 270);
                    //message += "R:" + sobra + "Panes\n";
                    if (check[i] == true)
                    {
                        verified += 1;
                        message += "Se cumple demanda de Panes y sobran " + sobra + "\n";
                    }
                    else
                    {
                        message += "Agregar/Quitar camiones de Panes\n";
                        string action = "Agregar camión de Panes.";
                        actions.Add(action);
                    }
                }
                else if(i == 2)
                {
                    //Verduras
                    sobra = 95 - (list[i] % 95);
                    //message += "R:" + sobra + "Verduras\n";
                    if (check[i] == true)
                    {
                        verified += 1;
                        message += "Se cumple demanda de Verduras y sobran " + sobra + "\n";
                    }
                    else
                    {
                        message += "Agregar/Quitar camiones de Verduras\n";
                        string action = "Agregar camión de Verduras.";
                        actions.Add(action);
                    }
                }
            }

            if(verified == 3)
            {
                message += "¡El sistema esta listo para generar la ruta!";
                string action = "Fin de Simulación.";
                actions.Add(action);
                MessageBox.Show(message);
                new Ruta(actions).Show();
                Hide();
            }
            else
            {
                message += "¡¡¡Verificar camiones!!!";
                MessageBox.Show(message);
            }

            //MessageBox.Show(message);
        }
    }
}
