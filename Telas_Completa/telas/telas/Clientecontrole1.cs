using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telas
{
    internal class Clientecontrole1
    {
        conexao con = new conexao();

        //metodo para cadastrar usuario
        public bool cadastrar(Cliente usuario)
        {
            //inicializar a variavel resultado do operacao 
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "insert into cliente (nome,email,telefone, senha )values(@nome,@email,@telefone, @senha)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nome", "@email", "@telefone","@senha"};
                //monto o vetor com os valores do formulario
                string[] valores = { usuario.nome, usuario.email, usuario.telefone, usuario.senha };
                //testar o insert no banco de dados
                usuario.cod_usuario = con.cadastrar(0, campos, valores, sql);
                if (usuario.cod_usuario >= 1)
                {
                    resultado = true;
                    

                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }



        }

        public long obterrgistro(long registro)
        {

            return registro;
        }
        public bool editar(Cliente usuario)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "update cliente set nome=@nome,email=@email,telefone=@telefone, where cod_usuario=@id)";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@nome", "@email", "@telefone" };
                //monto o vetor com os valores do formulario
                string[] valores = { usuario.nome, usuario.email, usuario.telefone };
                //testar o insert no banco de dados
                if (con.cadastrar(usuario.cod_usuario, campos, valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
