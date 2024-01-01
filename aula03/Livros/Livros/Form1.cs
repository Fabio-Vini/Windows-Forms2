using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Livros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Livro cadastro = new Livro();

            cadastro.setTitulo(txtTitulo.Text);
            cadastro.setAutor(txtAutor.Text);
            cadastro.setEditora(txtEditora.Text);
            cadastro.setLocal(txtLocal.Text);
            cadastro.setAnoedit(mskData.Text);

            LivroBLL.validaDados(cadastro);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }

            if (ValidarForm())
            {
                MessageBox.Show("Salvo com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
        }

        private bool ValidarForm()
        {
            bool FormValido;

            if (txtTitulo.Text == "")
            {
                FormValido = false;
            }
            else if (txtAutor.Text == "")
            {
                FormValido = false;
            }
            else if (txtEditora.Text == "")
            {
                FormValido = false;
            }
            else if (txtLocal.Text == "")
            {
                FormValido = false;
            }
            else if (!Regex.IsMatch(txtAutor.Text, @"^[a-zA-Z]+$"))
            {
                FormValido = false;
            }
            else if (!Regex.IsMatch(txtEditora.Text, @"^[a-zA-Z]+$"))
            {
                FormValido = false;
            }
            else if (!Regex.IsMatch(txtLocal.Text, @"^[a-zA-Z]+$"))
            {
                FormValido = false;
            }
            else

            FormValido = true;
            return FormValido;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Titulo = txtTitulo.Text;
            form2.Autor = txtAutor.Text;
            form2.Editora = txtEditora.Text;
            form2.Local = txtLocal.Text;
            form2.Data = mskData.Text;


            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Os dados estão incompletos!");
            }
            else if (txtAutor.Text == "")
            {
                MessageBox.Show("Os dados estão incompletos!");
            }
            else if (txtEditora.Text == "")
            {
                MessageBox.Show("Os dados estão incompletos!");
            }
            else if (txtLocal.Text == "")
            {
                MessageBox.Show("Os dados estão incompletos!");
            }
            else if (!mskData.MaskCompleted)
            {
                MessageBox.Show("Os dados estão incompletos!");
            }
            else
            {
                form2.Show();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditora.Clear();
            txtLocal.Clear();
            mskData.Clear();

            txtTitulo.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
