using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blusa_calça_verde_12._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioAmarelo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAmarelo.Checked)
            {
                lblCores.Text = ("Amarelo");
                lblCores.ForeColor = Color.Yellow;
                lblCores.BackColor = Color.Yellow;
            }
        }

        private void radioVerde_CheckedChanged(object sender, EventArgs e)
        {
            if (radioVerde.Checked)
            {
                lblCores.Text = ("Verde");
                lblCores.ForeColor = Color.Green;
                lblCores.BackColor = Color.Green;
            }
        }

        private void radioAzul_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAzul.Checked)
            {
                lblCores.Text = ("Azul");
                lblCores.ForeColor = Color.Blue;
                lblCores.BackColor = Color.Blue;
            }
        }

        private void radioCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCamisa.Checked)
            {
                lblRoupa.Text = ("Camisa");
                lblRoupa.ForeColor = Color.Black;
                
            }
        }

        private void radioCalça_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCalça.Checked)
            {
                lblRoupa.Text = ("Calça");
                lblRoupa.ForeColor = Color.Black;
                
            }
        }

        private void radioBlusa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlusa.Checked)
            {
                lblRoupa.Text = ("Blusa");
                lblRoupa.ForeColor = Color.Black;
                
            }
        }
    }
}
