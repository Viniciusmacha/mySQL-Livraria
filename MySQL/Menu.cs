using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL
{


    class Menu
    {
        DAO Dao;



        public int opcao;
        

          public Menu()
        {
            opcao = 0;
            Dao = new DAO();
        }//fim do construtor
        public void MostrarOpcoes()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n\n" +
            "\n1. Cadastrar" +
            "\n2. Consultar Tudo" +
            "\n3. Atualizar" +
            "\n4. Excluir");
            opcao = Convert.ToInt32(Console.ReadLine());



        }//fim do metodo
        public void Executar()
        {
            MostrarOpcoes();//mostrando o menu pra usuario
       

        
            switch (opcao)
            {

                case 1:
                    Console.WriteLine("Informe seu nome: ");
                    string nome = Console.ReadLine();



                    Console.WriteLine("Informe seu telefone: ");
                    string telefone = Console.ReadLine();



                    Console.WriteLine("Informe seu endereco: ");
                    string endereco = Console.ReadLine();
                    //Executar o métado inserir
                    Dao.inserir(nome, telefone, endereco);
                    break;

                case 2:
                    Console.WriteLine(Dao.ConsultarTudo());
                    break;
                case 3:
                    Console.WriteLine("Informe o código que deseja consultar");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nome:" + Dao.ConsultarNome(codigo) + "\nTelefone:" + Dao.ConsultarTelefone(codigo) + "\nEndereço: " + Dao.ConsultarEndereco(codigo));
                    break;

            }
        
               
            
        }
    }//fim da classe
}// fim do projeto