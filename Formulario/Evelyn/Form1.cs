using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evelyn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
                {
           
                }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            string texto = textBox1.Text;
            if (texto == "" || texto == null)
            {
                MessageBox.Show("Error", "No hay nada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.Add(texto);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
            string texto = textBox2.Text;
            if (texto == "" || texto == null)
            {
                MessageBox.Show("Error", "No hay nada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox2.Items.Add(texto);
                textBox2.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                listBox2.Items.Add(listBox1.Items[0]);
                listBox1.Items.Clear();
            }
            if (listBox2.Items.Count == 0)
            {
                listBox1.Items.Add(listBox2.Items[0]);
                listBox2.Items.Clear();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count == 4)
            {
                listBox1.Items.Clear();
            }
        }
    }
}
