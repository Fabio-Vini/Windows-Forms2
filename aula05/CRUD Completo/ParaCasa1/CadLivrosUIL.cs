using System;
using System.Windows.Forms;

namespace ParaCasa1
{
    public partial class CadLivrosUIL : Form
    {
        Livro umlivro = new Livro();

        public CadLivrosUIL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            umlivro.setCodigo(textBox1.Text);
            umlivro.setDescricao(textBox2.Text);
            umlivro.setFabricante(textBox3.Text);
            umlivro.setQuantidade(maskedTextBox2.Text);
            umlivro.setValor(maskedTextBox3.Text);

            
            LivroBLL.validaDados(umlivro, 'i');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void CadLivrosUIL_Load(object sender, EventArgs e)
        {
          
            LivroBLL.conecta();
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            umlivro.setCodigo(textBox1.Text);

            LivroBLL.validaCodigo(umlivro, 'c');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            {

                textBox1.Text = umlivro.getCodigo();
                textBox2.Text = umlivro.getDescricao();
                textBox3.Text = umlivro.getFabricante();
                maskedTextBox2.Text = umlivro.getQuantidade();
                maskedTextBox3.Text = umlivro.getValor();
            }
        }

        private void CadLivrosUIL_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            LivroBLL.desconecta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            umlivro.setCodigo(textBox1.Text);

            LivroBLL.validaCodigo(umlivro, 'e');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Produto Excluído!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            umlivro.setCodigo(textBox1.Text);
            umlivro.setDescricao(textBox2.Text);
            umlivro.setFabricante(textBox3.Text);
            umlivro.setQuantidade(maskedTextBox2.Text);
            umlivro.setValor(maskedTextBox3.Text);

            
            LivroBLL.validaDados(umlivro, 'a');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Dados alterados com sucesso!");
        }

       
        

        }
    }
