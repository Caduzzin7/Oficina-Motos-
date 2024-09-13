using Microsoft.Win32;
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
    public partial class Cadastro_Tela_2_C : Form
    {
        DataTable dt = new DataTable();
        int Codcliente;
        Cliente cliente = new Cliente();
        Clientecontrole1 clientecontrole = new Clientecontrole1();
        conexao conexao = new conexao();
        public Cadastro_Tela_2_C()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                cliente.nome = txtnome.Text;
                //verificar se o campo email foi preenchido
                if (string.IsNullOrEmpty(txtemail.Text))
                {
                    MessageBox.Show("Campo e-mail está vazio!");
                    return;
                }
                else
                {
                    cliente.email = txtemail.Text;
                }
                cliente.telefone = txttelefone.Text;
                if (clientecontrole.cadastrar(cliente) == true)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    textBox1.Text = cliente.cod_usuario.ToString();
                }
                else
                {
                    MessageBox.Show("Erro no cadastrado do usuário!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Tela_2_C_Load(object sender, EventArgs e)
        {
            pesquisacliente.DataSource = conexao.obterdados("select Codcliente,  nome from cliente");
            pesquisacliente.ValueMember = "Codcliente";
            pesquisacliente.DisplayMember = "nome";
            pesquisacliente.SelectedIndex = -1;

            if (pesquisacliente.SelectedIndex > -1)
            {
                //Codcliente = Convert.ToInt32(((DataRowView)pesquisacliente.SelectedItem)["Codcliente"]);
                dt = conexao.obterdados("select * from cliente where Codcliente=" + Codcliente);
                txtnome.Text = dt.Rows[0][1].ToString();
                txtemail.Text = dt.Rows[0][2].ToString();
                txttelefone.Text = dt.Rows[0][3].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cadastromotocs cmoto = new Cadastromotocs(cliente.cod_usuario);
            cmoto.ShowDialog();

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            loginoficina oficina = new loginoficina();
            oficina.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pesquisacliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(pesquisacliente.selectedindex > -1)
            //{
               // dt = conexao.obterdados("select * from cliente where codcliente=" + codcliente);
                //txtnome.text = dt.rows[0][1].tostring();
                //txtemail.text = dt.rows[0][2].tostring();
                //txttelefone.text = dt.rows[0][3].tostring();
            //}

        }

        private void pesquisacliente_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
