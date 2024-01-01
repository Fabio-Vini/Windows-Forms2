using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equacao delta = new Equacao();


            delta.setA(textBox1.Text);
            delta.setB(textBox2.Text);
            delta.setC(textBox3.Text);

            

            if (float.Parse(delta.getDelta()) >= 0)
            {
                MessageBox.Show("VALOR DE DELTA E SUAS RAÍZES:\n " +
                                "\n▲ = " + delta.getDelta() +
                                "\nx' = " + delta.getX1() + 
                                "\nx'' = " + delta.getX2());
               
            }
            else 
            {
                MessageBox.Show("Não existem raízes reais!\n" + 
                                "\nVALOR DE DELTA:\n " +
                                "\n▲ = " + delta.getDelta());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
