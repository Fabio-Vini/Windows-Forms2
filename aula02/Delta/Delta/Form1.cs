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

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            Equacao delta = new Equacao();


            delta.setA(tbA.Text);
            delta.setB(tbB.Text);
            delta.setC(tbC.Text);

            DeltaBLL.validaDados(delta);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
/*                tbA.Enabled = false;
                tbB.Enabled = false;
                tbC.Enabled = false;*/
            }

            if (float.Parse(delta.getDelta()) >= 0)
            {
                MessageBox.Show("VALOR DE DELTA E SUAS RAÍZES:\n " +
                                "\n▲ = " + delta.getDelta() +
                                "\nx' = " + delta.getX1() + 
                                "\nx'' = " + delta.getX2());

                lblDelta.Text = delta.getDelta();
                lblX1.Text = delta.getX1();
                lblX2.Text = delta.getX2();
               
            }
            else 
            {
                MessageBox.Show("Não existem raízes reais!\n" + 
                                "\nVALOR DE DELTA:\n " +
                                "\n▲ = " + delta.getDelta());
            }
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            tbA.Focus();
            tbA.Clear();
            tbB.Clear();
            tbC.Clear();

            lblDelta.Text = "";
            lblX1.Text = "";
            lblX2.Text = "";
        }

        private void btnEncerra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
