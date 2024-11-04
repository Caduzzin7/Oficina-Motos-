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
    public partial class relatoriogeral : Form
    {
        conexao con = new conexao();
        int id_cliente;
        public relatoriogeral(int id_cliente)
        {
            this.id_cliente = id_cliente;
            InitializeComponent();
        }

        private void relatoriogeral_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.obterdados("select * from cliente inner join moto on moto.codigo_cliente=cliente.codcliente ");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
