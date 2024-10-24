﻿using System;
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
    public partial class loginoficina : Form
    {
        conexao con = new conexao();
        
        public loginoficina()
        {
            InitializeComponent();
        }

        private void loginoficina_Load(object sender, EventArgs e)
        {
            DataTable dt_Oficina = new DataTable();

            dataGridView1.DataSource = con.obterdados("select * from dadosrevisao");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastromecanico mecanico = new cadastromecanico();
            mecanicocontrole mecanicocontrole = new mecanicocontrole();

            try
            {
                if (string.IsNullOrEmpty(nomeoficina.Text))
                {
                    MessageBox.Show("Campo nome da oficina está vazio!");
                    return;
                }
                else
                {
                    mecanico.nomeoficina = nomeoficina.Text;

                }
                mecanico.nomeoficina = nomeoficina.Text;
                mecanico.nomemecanico = nomemecanico.Text;
                mecanico.emailmecanico = emailmecanico.Text;
                mecanico.senhamecanico = senhamecanico.Text;
                if (mecanicocontrole.cadastrar(mecanico) == true)
                {
                    MessageBox.Show("mecanico cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastrado do produto!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            cadastromecanico mecanico = new cadastromecanico();
            mecanicocontrole mecanicocontrole = new mecanicocontrole();
            mecanico.cod_mecanico = Convert.ToInt32(codmecanico.Text);
            mecanico.nomeoficina = nomeoficina.Text;
            mecanico.nomemecanico = nomemecanico.Text;
            mecanico.emailmecanico = emailmecanico.Text;
            mecanico.senhamecanico = senhamecanico.Text;
            if (mecanicocontrole.editar(mecanico) == true)
            {
                MessageBox.Show("mecanico cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro no cadastrado do mecanico!");
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            cadastromecanico mecanico = new cadastromecanico();
            mecanicocontrole mecanicocontrole= new mecanicocontrole();
            mecanico.cod_mecanico = Convert.ToInt32(codmecanico.Text);
            if (mecanicocontrole.excluir(mecanico) == true)
            {

                MessageBox.Show("mecanico cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro no cadastrado do mecanico!");
            }
        }
    }
}
