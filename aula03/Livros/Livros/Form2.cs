using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livros
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label6.Text = Titulo;
            label7.Text = Autor;
            label8.Text = Editora;
            label9.Text = Local;
            label11.Text = Data;

        }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Local { get; set; }
        public string Data { get; set; }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
