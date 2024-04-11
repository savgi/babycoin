using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55.Alterar.frmGerirCllientes.cs
{
    public partial class frmGerirClientes : Form
    {
        public frmGerirClientes()
        {
            InitializeComponent();
        }

        private void btn_ExcluirCli_Click(object sender, EventArgs e)
        {
            dgvCliente.Rows.RemoveAt(dgvCliente.CurrentRow.Cells[0].RowIndex);
        }

        private void btn_IncluirCli_Click(object sender, EventArgs e)
        {


            dgvCliente.Rows.Add(txb_Busca.Text);


            txb_Busca.Text = string.Empty;
            

            txb_Busca.Focus();
        }

        private void btn_AlterarCli_Click(object sender, EventArgs e)
        {
            if(dgvCliente.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Selecione um registro para alteração");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void frmGerirClientes_Load(object sender, EventArgs e)
        {
            
        }
    }
}
