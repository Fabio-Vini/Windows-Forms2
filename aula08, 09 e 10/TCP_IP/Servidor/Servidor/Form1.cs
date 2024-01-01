using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();//Preparo do servidor para ser configurado e usado.
            server.Delimiter = 0x13;//O valor 0x13 representa o caractere hexadecimal 0x13, que é o código ASCII para o caractere "enter", isso significa que o servidor irá considerar qualquer instância do caractere "enter" como um delimitador para separar mensagens ou dados recebidos.
            server.StringEncoder = Encoding.UTF8;//É um objeto que representa o conjunto de caracteres UTF-8, que é um padrão amplamente utilizado para codificar caracteres em texto.
            server.DataReceived += Server_DataReceived;//Quando o servidor receber dados, este método será chamado para processar esses dados.
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblStatus.Text += "Server starting...";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text); //Transforma o texto do 'TextBox Host' em um IP, armazena na variável 'ip' para usar posteriormente.
            server.Start(ip, Convert.ToInt32(txtPort.Text)); //Inicia o servidor e vincula ao endereço IP que foi registrado na variável 'ip', ao depurar o código, o servidor estará ativo e pronto para receber clientes com a mesma combinação de endereço IP e Porta do Servidor.
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
                server.Stop();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost2.Text);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            server.Broadcast(txtMessage.Text);
        }
    }
}
