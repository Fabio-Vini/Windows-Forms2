using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circunferencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Calcular area = new Calcular();

            area.setRaio(textBox1.Text);
            CircunferenciaBLL.validaDados(area);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                textBox2.Text = area.getArea();
                textBox1.Enabled = false;
            }

            textBox2.Text = area.getArea();



            Calcular perimtetro = new Calcular();


            perimtetro.setRaio(textBox1.Text);
            CircunferenciaBLL.validaDados(perimtetro);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                textBox3.Text = perimtetro.getPerimetro();
                textBox1.Enabled = false;
            }

            textBox3.Text = perimtetro.getPerimetro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();

        }
    }
}
