using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = ""; // mensagens vazia tudo ok
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String email,String senha)
        {
            //procurar no banco esse email e senha
            cmd.CommandText = "select * from nomeDaTabela where email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                //as informacoes buscadas no banco esta no dr email e senha
               dr = cmd.ExecuteReader();
               if(dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;
        }
    }
}
