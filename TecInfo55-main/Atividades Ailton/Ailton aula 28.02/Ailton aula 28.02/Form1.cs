using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ailton_aula_28._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int n1, n2, soma;
            n1 = Convert.ToInt32(textbox_Algoritmo1);
            n2 = Convert.ToInt32(textbox_Algoritmo2);
            soma = n1 + n2;
            lbl_Resultado.Text = Convert.ToString(soma);
        }

        private void btn_Exibir_Click(object sender, EventArgs e)
        {
            int n1, n2, subtracao;
            n1 = Convert.ToInt32(textbox_Algoritmo1);
            n2 = Convert.ToInt32(textbox_Algoritmo2);
            subtracao = n1 - n2;
            lbl_Resultado.Text = Convert.ToString(subtracao);
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
