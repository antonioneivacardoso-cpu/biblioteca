using Blibioteca;

using MySql.Data.MySqlClient;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Biblioteca

{

    class ControlAutor

    {

        DAOAutor autor;

        public int opcao;

        public ControlAutor()

        {

            this.autor = new DAOAutor(); // Abrindo a conexão com o BD

        } // fim do construtor

        // Mostrar o menu

        public void MostrarMenu()

        {

            Console.WriteLine("----- MENU -----\n\n" +

                              "\n0. Sair" +

                              "\n1. Cadastrar" +

                              "\n2. Consultar" +

                              "\n3. Atualizar" +

                              "\n4. Excluir" +

                              "\nEscolha uma das opções acima: ");

            this.opcao = Convert.ToInt32(Console.ReadLine());

        } // fim do método

        public void ExecutarOperacao()

        {

            do

            {

                this.MostrarMenu();

                switch (this.opcao)

                {

                    case 0:

                        Console.WriteLine("Obrigado!");

                        break;

                    case 1:

                        Console.WriteLine("Cadastrar Autor");

                        //formulario do cadastro 

                        Console.WriteLine("Informe o nome do autor: ");

                        string nome = Console.ReadLine();

                        Console.WriteLine("Informe o genero do autor: ");

                        string genero = Console.ReadLine();

                        Console.WriteLine("Informe o endereço do autor: ");

                        string endereco = Console.ReadLine();

                        //Inserir esses dados no banco

                        this.autor.Inserir(nome, genero, endereco);

                        break;

                    case 2:

                        Console.WriteLine("Consultar Autor");

                        break;

                    case 3:

                        Console.WriteLine("Atualizar Autor");

                        break;

                    case 4:

                        Console.WriteLine("Excluir Autor");

                        break;

                    default:

                        Console.WriteLine("Codigo informado é invalido");

                        break;

                }

            } while (this.opcao != 0);

        }

    }

}
