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
    public partial class tela_senha_para_cadastro : Form
    {
        public tela_senha_para_cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Cliente zusuario = new Cliente();
            zusuario.senha = txtsenha.Text;

            Clientecontrole1 cusuario = new Clientecontrole1();
            if (zusuario.senha == "mymotos" )
            {
                MessageBox.Show("Acesso autorizado!");
                loginoficina moto = new loginoficina ();
                moto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acesso não autorizado!");

            }
        }
    }
}
