using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // ADO.net
using System.Data.SqlClient; // ADO para SQL SERVER

namespace Data
{
    public class ClienteDao
    {
        private string _conexao;

        // Metodo Construtor => Inicializa Objeto buscando Conexao
        public ClienteDao(string conexao)
        {
            _conexao = conexao;
        }

        // Inserir cliente Vulgo XUXAR
        public void IncluiCliente(Cliente cliente)
        {
            using (SqlConnection conexaobd = new SqlConnection(_conexao))
            {
                string sql = "insert int Clientes (nome,profissao,setor,obs) values (@nome,@profissao,@setor,@obs)";



                using (SqlCommand comando = new SqlCommand(sql,conexaobd))
                {
                    comando.Parameters.AddWithValue("@nome", cliente.Nome);
                    comando.Parameters.AddWithValue("@profissao", cliente.Profissao);
                    comando.Parameters.AddWithValue("@setor", cliente.Setor);
                    comando.Parameters.AddWithValue("@obs", cliente.Obs);

                    try
                    {
                        conexaobd.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao excluir Cliente:" + ex.Message);
                    }
                }
            }
        }
    }
}


