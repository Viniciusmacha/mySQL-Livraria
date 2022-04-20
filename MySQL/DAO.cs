using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace MySQL
{
    class DAO
    {
        MySqlConnection conexao;
        public string dados;
        public string resultado;
       
        public DAO()

        {
            conexao = new MySqlConnection("server=localhost;DataBase=BancoDeDadosTI13N;Uid=root;Password=;");
            try
            {
                conexao.Open();
                Console.WriteLine("Entrei!!!");

            }

            catch (Exception e)
            {
                Console.WriteLine("Algo deu errado!\n\n" + e);
                conexao.Close();
            }
            
        }
           

         
        public void inserir(string nome, string telefone, string endereco)
        {
            try
            {
                dados = "('', '" + nome + "','" + telefone + "','" + endereco + "')";
                resultado = "Insert auto into Pessoa(codigo, nome, telefone, edereco) values" + dados;
                MySqlCommand sql = new MySqlCommand(resultado, conexao);
                resultado = "" + sql.ExecuteNonQuery();
            }       
            catch (Exception e)
            {
                Console.WriteLine("Algo deu errado!\n\n" + e);
            }
        }
    }//fim da classe 
}//fim projeto
