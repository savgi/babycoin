using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ailtono_12._03_Terça
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Negrito.Checked)
            {
                txbPalavra.Font = new Font(txbPalavra.Font, FontStyle.Bold);
            }
            else
            {
                txbPalavra.Font = new Font(txbPalavra.Font, FontStyle.Regular);
            }

        }

        private void txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Itálico_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Itálico.Checked)
            {
                txbPalavra.Font = new Font(txbPalavra.Font, FontStyle.Italic);
            }
            else
            {
                txbPalavra.Font = new Font(txbPalavra.Font, FontStyle.Regular);
            }
        }

        private void checkBox_Vermelho_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Vermelho.Checked)
            {
                txbPalavra.ForeColor = Color.Red;
            }
            else
            {
                txbPalavra.ForeColor = Color.Black;
            }
        }
    }
}
