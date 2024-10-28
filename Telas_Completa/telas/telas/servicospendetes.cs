using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telas
{
    public partial class servicospendetes : Form
    {
        conexao conexao = new conexao();
        public servicospendetes()
        {
            InitializeComponent();
        }

        private void CarregarDadosRevisao()
        {
            try
            {
                // Definindo a query SQL para selecionar os dados da tabela dadosrevisao
                string query = "SELECT cliente.nome AS NomeCliente, cliente.telefone AS TelefoneCliente, moto.marcamoto AS MarcaMoto, cadastroprodutos.nomeproduto AS NomeProduto, cliente.Codcliente AS CodigoCliente, cadastroprodutos.codcadprodutos AS CodigoProduto, moto.Codmoto AS CodigoMoto FROM cliente INNER JOIN moto ON cliente.Codcliente = moto.codigo_cliente CROSS JOIN cadastroprodutos;\r\n";

                // Chamando o método obterdados da classe conexao
                DataTable dt = conexao.obterdados(query);

                // Atribuindo o DataTable como fonte de dados do DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro em caso de falha na conexão ou consulta
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
