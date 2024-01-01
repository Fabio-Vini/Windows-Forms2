using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivroIHM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
        }
        Livro text = new Livro();
        private void button3_Click(object sender, EventArgs e)
        {

           

            text.setitulo(textBox1.Text);
            text.setautor(textBox2.Text);
            text.seteditora(textBox3.Text);
            text.setano(textBox4.Text);
            text.setlocal(textBox5.Text);

            LivroBLL.validaDados(text);
            if(Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                MessageBox.Show("Salvo com sucesso");
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
            }
         
            /*textBox1.BackColor = Color.Aqua;
            textBox2.BackColor = Color.Aqua;
            textBox3.BackColor = Color.Aqua;
            textBox4.BackColor = Color.Aqua;
            textBox5.BackColor = Color.Aqua;*/
        }
     
        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = text.getitulo();
            textBox2.Text = text.getautor();
            textBox3.Text = text.geteditora();
            textBox4.Text = text.getano();
            textBox5.Text = text.getlocal();


        }
    }
}
