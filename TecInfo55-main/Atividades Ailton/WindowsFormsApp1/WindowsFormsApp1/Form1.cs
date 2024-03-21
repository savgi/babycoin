using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string item;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Elimin_Click(object sender, EventArgs e)
        {
            if (cb_droplist.SelectedIndex == -1)
            {
             MessageBox.Show("Nenhum item foi selecionado.","Combo box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cb_droplist.Items.RemoveAt(cb_droplist.SelectedIndex);
            }
            cb_droplist.Items.Remove(cb_droplist.SelectedIndex);
        }

        private void cb_droplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_droplist.SelectedIndex != -1)
            {
                lbl_PosLista.Text = cb_droplist.SelectedIndex.ToString();
                lbl_TextSelec.Text = cb_droplist.SelectedIndex.ToString();
                lbl_TotItens.Text = cb_droplist.SelectedIndex.ToString();
            }
        }

        private void btn_Adic_Click(object sender, EventArgs e)
        {
            cb_droplist.Items.Add(item);
            tb_Digiteumtexto.Text=string.Empty;
            tb_Digiteumtexto.Focus();


        }

        private void tb_Digiteumtexto_TextChanged(object sender, EventArgs e)
        {
            item = tb_Digiteumtexto.Text;
            lbl_PosLista.Text = Convert.ToString(cb_droplist.SelectedIndex);
            lbl_TextSelec.Text = Convert.ToString(cb_droplist.SelectedItem);
            lbl_TotItens.Text = Convert.ToString(cb_droplist.Items.Count);
            tb_Digiteumtexto.Focus();




        }

        private void btn_LimpList_Click(object sender, EventArgs e)
        {
            cb_droplist .Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb_Digiteumtexto.Clear();
            cb_droplist.SelectedIndex = -1;
            lbl_PosLista.Text = "";
            lbl_TextSelec.Text = "";
            lbl_TotItens.Text = "";
            tb_Digiteumtexto.Focus();
        }

        private void tb_Digiteumtexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_Adic_Click(sender, e);
            }
        }
    }
}