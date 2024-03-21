using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55.Adicionar
{
    public partial class frmAdicionarCliente : Form
    {
        //Chamar a conexão
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frmAdicionarCliente()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbObs.Clear();
            txbProfissao.Clear();
            txbSetor.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Chama o objeto Cliente
            Cliente cliente = new Cliente();
            ClienteDao clientedao = new ClienteDao (_conexao);

            if (string.IsNullOrEmpty(txbNome.Text)|| string.IsNullOrEmpty(txbObs.Text) ||string.IsNullOrEmpty(txbProfissao.Text) ||string.IsNullOrEmpty(txbSetor.Text))
            {
                MessageBox.Show("Cadê os dados?");
            }
            else 
            {
                // Toda vez que mexer com bd usar try
                try
                {
                    //preenche o objeto Cliente
                    cliente.Nome = txbNome.Text;
                    cliente.Profissao = txbProfissao.Text;
                    cliente.Setor = txbSetor.Text;
                    cliente.Obs = txbObs.Text;

                    clientedao.IncluiCliente(cliente);
                }catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar", "Atenção!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                
                }
                finally
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                }

                






            }


        }
    }
}
