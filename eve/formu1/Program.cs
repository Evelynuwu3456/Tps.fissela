using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace formu1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private ListBox listBox1;
        private ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //este sirve para cuando quieras seguir escribiendo sin seleccionar el cuadrito de escribir
            textBox1.Focus();
            //
            string texto = textBox1.Text;
            //aca hacemos un if para que no aparesca un espacio en blanco, ej: si en el textbox ponemos enter sin nada escrito la idea es que no suceda para que no se nos lite un espacio en blanco
            //si el texto es igual a nada osea vacio en este caso "" o el texto sea nulo.....
            if (texto == "" || texto == null)
            //.....aparesca este mensage en modo box de "no hay nada" o "error" con un boton de "ok" y un icono de error osea una "x"
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
                for (int i = 0; i < list.Count; i++)
                {
                    //aca decimos que el box se convierte en lista y que podemos seleccionar un item y insertarlo dependiendo la posición de la lista del box 2
                    listBox1.Items.Insert(i, list[i]);
                }
                //aca exacto es donde decimos que se borre en texto si lo cambiamos en donde estaba anteriormente
                textBox1.Clear();
            }
        }
        //*cuando ponemos listbox solo es un objeto solo pero cuando ponemos .items este se convierte en un lista al cual le podemos seleccionar un item
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //obtenemos el texto seleccionado y el metodo. TO STRING SIRVE PARA PASARLO A TEXTO
            string texto = listBox1.SelectedItem.ToString();
            //listbox1.SelectedIndex lo que hace es proporcionarnos el indice de  el elemento seleccionado 
            int indice = listBox1.SelectedIndex;
            //*lo mismo pero nos indica el conteo de donde se va ubicar ekl texto osea abajo de todo
            listBox2.Items.Insert(listBox2.Items.Count, texto);
            //aca es donde le indicamos al boton que tiene que remover la palabra sellecionada al otro lado
            listBox1.Items.RemoveAt(indice);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(424, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 261);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(404, 59);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(263, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(263, 130);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(954, 538);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
