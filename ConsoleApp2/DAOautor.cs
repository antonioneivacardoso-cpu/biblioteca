using MySql.Data.MySqlClient;

using System;

using System.Collections.Generic;

using System.Data.SqlClient;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Blibioteca

{

    class DAOAutor

    {

        public MySqlConnection conexao;

        public string dados;

        public string comando;

        public DAOAutor()

        {

            //Conexão com o banco de dados

            this.conexao = new MySqlConnection("server=localhost;DataBase=registro;Uid=root;Password=;Convert Zero DateTime=True");

            try

            {

                conexao.Open();//Abrir a conexão

                Console.WriteLine("conectado com secesso");

            }

            catch (Exception erro)

            {

                Console.WriteLine($"Algo deu errado!\n\n {erro}");

                this.conexao.Close();//fechar a conexão com o BD

            }//Fim do try_catch

        }//Fim do contruto

        //Inserir dados no banco

        public void Inserir(string nome, string genero, string endereco)

        {

            try

            {

                this.dados = $"('','{nome}','{genero}','{endereco}')";

                this.comando = $"Insert into autor(codigo, nome, genero, endereco) values{this.dados}";

                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);

                string resultado = "" + sql.ExecuteNonQuery(); // Executo o comando

                Console.WriteLine($"Inserido com sucesso!\n\n {resultado}");

            }

            catch (Exception erro)

            {

                Console.WriteLine($"Algo deu errado\n\n {erro}");

            }//fim do catch

        }

    }//FIm da classe

}//Fim projeto
Console.WriteLine("Atualizar Autor");

Console.WriteLine("Informe o código do autor que deseja atualizar");
int codigo = Convert.ToInt32(Console.ReadLine());

//Criar um menu para atualização
Console.WriteLine("Escolha qual campo deseja atualizar: \n\n" +
                  "\n1. Nome" +
                  "\n2. Gênero" +
                  "\n3. Endereço");

int opcaoCampo = Convert.ToInt32(Console.ReadLine());
string campo = "";

//Escolha
switch (opcaoCampo)
{
    case 1:
        campo = "nome";
        break;

    case 2:
        campo = "genero";
        break;

    case 3:
        campo = "endereco";
        break;

    default:
        Console.WriteLine("Não é possível atualizar! Escolha um campo válido");
        return;
}

//Novo valor
Console.WriteLine("Digite o novo valor:");
string novoValor = Console.ReadLine();

//Atualização
model.AtualizarAutor(codigo, campo, novoValor);

Console.WriteLine("Autor atualizado com sucesso!");