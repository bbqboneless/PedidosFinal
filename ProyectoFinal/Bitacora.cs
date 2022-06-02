using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoFinal
{
    public partial class Bitacora : Form
    {
        public List<string> actions = new List<string>();
        public Bitacora(List<string> a)
        {
            InitializeComponent();
            actions = a;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var txtFile = new TipoContext(new TxtFile());
                List<string> list = txtFile.Visualizar(actions);
                string path = list[0];
                Process openFile = new Process();
                openFile.StartInfo.FileName = path;
                openFile.Start();
            }
            if (checkBox2.Checked)
            {
                dataGridView1.AutoResizeColumns();
                dataGridView1.Visible = true;
                dataGridView1.Columns[0].Width = 500;
                var gridVista = new TipoContext(new VistaGrid());
                List<string> list = gridVista.Visualizar(actions);
                
                foreach (string l in list)
                {
                    string[] st = { l};
                    dataGridView1.Rows.Add(st);
                }
            }
            if (checkBox3.Checked)
            {
                textBox1.Visible = true;
                var textboxVista = new TipoContext(new VistaTextbox());
                List<string> list = textboxVista.Visualizar(actions);

                foreach(string l in list)
                {
                    textBox1.Text += l + Environment.NewLine;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> a = new List<string>();
            new LeerQR(a).Show();
            Hide();
        }
    }
}
