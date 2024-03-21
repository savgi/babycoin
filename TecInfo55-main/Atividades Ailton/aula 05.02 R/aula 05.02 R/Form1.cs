using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_05._02_R
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            //Tem q ser nessa ordem para o "Senac" ficar no topo.
            MessageBox.Show("Essa é uma mensagem de alerta", "Alerta", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            label2.Text = "Exemplo 1 e Botâo OK";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;

            resposta = MessageBox.Show("Poderia informar seus dados para contato?", "Dados", MessageBoxButtons.YesNo);

            

            if (resposta == DialogResult.Yes)
            {
                label2.Text = "Exemplo 2 e Botâo SIM";
            }

            else if(resposta == DialogResult.No)
            {
                label2.Text = "Exemplo 2 e botão NÃO";
            }
               
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            var resposta = DialogResult;

            resposta = MessageBox.Show("Confirma sua resposta anterior?", "Certeza?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

           

            if (resposta == DialogResult.Yes)
            {
                label2.Text = "Exemplo 3 e Botâo SIM";
            }

            else if (resposta == DialogResult.No)
            {
                label2.Text = "Exemplo 3 e botão NÃO";
            }
            
            else 
            {
                label2.Text = "Exemplo 3 e botão CANCELADO";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
           label2.Text = "";
        }
    }
}
