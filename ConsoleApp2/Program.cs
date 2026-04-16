using Blibioteca;
using Google.Protobuf.WellKnownTypes;
using System;

using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteca

{

    internal class Program

    {

        static void Main(string[] args)

        {

            ControlAutor controlAutor = new ControlAutor();

            controlAutor.ExecutarOperacao();
            {
                //definir o ponto de entrada do softwere
                [STAThread]
                
                static void main(string[] args)
            }

            Application.enablevisualstyles();
            Application.setconpatibletextRenderingdefaut(true);
            Application.run(new MenuCommand());


            public Cadastrar()
        {
            InitializeComponent();
            //Inserir
            this.autor = new DAOAutor();
        } //fim do construtor

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string genero = textBox2.Text;
            string endereco = textBox3.Text;

            //Inserir dentro do banco
            this.autor.Inserir(nome, genero, endereco);

        } //fim do cadastrar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public partial class Menu : Form
        {
            Cadastrar cad;

            public Menu()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                cad = new Cadastrar();
            } //Botão Cadastrar

            private void button2_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Botão Consultar");

            private void button1_Click(object sender, EventArgs e)
            {
                string nome = textBox1.Text;
                string genero = textBox2.Text;
                string endereco = textBox3.Text;

                //Inserir dentro do banco
                this.autor.Inserir(nome, genero, endereco);//Chamar Método

//Nome Colunas
public void NomeColunas(DataGridView dataGrid)
            {
                dataGrid.Columns[0].Name = "Código";
                dataGrid.Columns[1].Name = "Nome";
                dataGrid.Columns[2].Name = "Gênero";
                dataGrid.Columns[3].Name = "Endereço";
            }//fim do método

            //Definir a estrutura da tabela
            public void ConfigurarDataGrid(DataGridView dataGrid)
            {
                dataGrid.AllowUserToAddRows = false; //Não permito que o usuário adicione linhas
                dataGrid.AllowUserToDeleteRows = false;
                dataGrid.AllowUserToResizeColumns = false;
                dataGrid.AllowUserToResizeRows = false;

                dataGrid.ColumnCount = 4;
            }//fim do configurar
             //Definir a estrutura da tabela
            public void ConfigurarDataGrid(DataGridView dataGrid)
            {
                dataGrid.AllowUserToAddRows = false; //Não permito que o usuário adicione linhas
                dataGrid.AllowUserToDeleteRows = false;
                dataGrid.AllowUserToResizeColumns = false;
                dataGrid.AllowUserToResizeRows = false;

                dataGrid.ColumnCount = 4;
            }//fim do configurar

            public void AdicionarDados(DataGridView dataGrid)
            {
                //Primeira coisa será: PREENCHER O VETOR
                this.dao.PreencherVetor();

                for (int i = 0; i < this.dao.contar; i++)
                {
                    dataGrid.Rows.Add(
                        this.dao.codigo[i],
                        this.dao.nome[i],
                        this.dao.genero[i],
                        this.dao.endereco[i]
                    );
                }//fim
            }//fim do adicionarDados


            //Limpar os campos
            LimparCampos();
            } //fim do cadastrar

            //Limpar os campos
            public void LimparCampos()
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";


            } //fim do método
        } //Botão Consultar
        } //Classe Menu

        //Projeto Biblioteca


    }//fim do metodo main

}//fim da classe

}//fim do projeto

