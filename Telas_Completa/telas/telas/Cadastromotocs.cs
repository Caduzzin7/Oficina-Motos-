using MySqlX.XDevAPI;
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

namespace telas
{
    public partial class Cadastromotocs : Form
    {
        int id_cliente;
        int codcliente; 
       conexao conexao = new conexao();
        public Cadastromotocs(int id_cliente)
        {
            InitializeComponent();
            this.id_cliente = id_cliente;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Cadastromotocs_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            motomodelo mmodelo = new motomodelo();
            mmodelo.kmmoto = textBox4.Text;
            mmodelo.marcamoto = txtnome.Text;
            mmodelo.modelomoto = textBox2.Text;
            mmodelo.cormoto = textBox5.Text;
            mmodelo.cod_cliente = id_cliente;
            motocontrole cmoto = new motocontrole();
            if (cmoto.cadastrar(mmodelo) == true)
            {
                MessageBox.Show("cadatrado com sucesso");
            }
            else
            {
                MessageBox.Show("erro ao cadastrar a moto");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrohprodutos produto = new Cadastrohprodutos(id_cliente);
            produto.ShowDialog();

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pesquisacliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pesquisacliente.SelectedIndex > -1)
            {
                codcliente = Convert.ToInt32(((DataRowView)pesquisacliente.SelectedItem)["Codcliente"]);
                dt = conexao.obterdados("select * from moto where codcliente=" + codcliente);
                marcamoto.Text = dt.Rows[0][0].ToString();
                modelomoto.Text = dt.Rows[0][2].ToString();
                kmmoto.Text = dt.Rows[0][1].ToString();
                cormoto.Text = dt.Rows[0][4].ToString();
                cliente.cod_usuario = Convert.ToInt32(textBox1.Text);
            }

        }
    }
}
