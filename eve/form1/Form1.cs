using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            string texto = textBox1.Text;
            if (texto == "" || texto == null)
            {
                MessageBox.Show("No hay nada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //sim no que prosiga normalmente con este codigo
            else
            {
                //se crea la lista
                List<string> list = new List<string>();
                //se sube un texto o sea toma texto
                list.Add(texto);
                //aca hacemos un for para que cuando queremos pasar un texto del box 1 al box2 desapareca del box1 y aparesca en el box2 en el ultimo lugar porque lo que se va listando es un array
                //y si se pusiera en el medio o arriba de todo se romperia todo dice
                //repetir si la opisicion es = a 0 listar la posicion cero con el conteo correspondiente incrmentado
                //for (int i = 0; i < list.Count; i++)
                //{
                //aca decimos que el box se convierte en lista y que podemos seleccionar un item y insertarlo dependiendo la posición de la lista del box 2
                //   listBox1.Items.Insert(i, list[i]);
                // }
                listBox1.Items.Add(textBox1.Text);
                //aca exacto es donde decimos que se borre en texto si lo cambiamos en donde estaba anteriormente
                textBox1.Clear();
            }  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }
    }
}
