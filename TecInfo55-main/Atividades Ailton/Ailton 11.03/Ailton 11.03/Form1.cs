using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ailton_11._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string item;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(item);
            tbDigiteTexto.Text = string.Empty;
            tbDigiteTexto.Focus();
           
        }

        private void btnElimi_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item foi selecionado.", "Combo box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
            listBox.Items.Remove(listBox.SelectedIndex);
        }

        private void btnLimparTodos_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbDigiteTexto.Clear();
            listBox.SelectedIndex = -1;
            lbPosLis.Text = "";
            lbTexSelec.Text = "";
            lbTotItens.Text = "";
            tbDigiteTexto.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                lbPosLis.Text = Convert.ToString(listBox.SelectedIndex);
                lbTexSelec.Text = Convert.ToString(listBox.SelectedItem) ;
                lbTotItens.Text = Convert.ToString(listBox.Items.Count);
            }
        }

        private void tbDigiteTexto_TextChanged(object sender, EventArgs e)
        {
            item = tbDigiteTexto.Text;
            lbPosLis.Text = Convert.ToString(listBox.SelectedIndex);
            lbTexSelec.Text = Convert.ToString(listBox.SelectedItem);
            lbTotItens.Text = Convert.ToString(listBox.Items.Count);
            tbDigiteTexto.Focus();
        }

        private void lbTexSelec_Click(object sender, EventArgs e)
        {
            
        }

        private void tbDigiteTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Chama a função do botão btnAdicionar
                btnAdicionar_Click(sender, e);

                // Impede que o caractere de nova linha seja inserido no TextBox
                e.Handled = true;
            }
        }
    }
}
