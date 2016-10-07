using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1 - FAZER A CONEXÃO COM BANCO DE DADOS
            //2 - TRAZER ID, NOME E EMAIL DA TABELA USUÁRIOS
            SqlConnection conecxao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alexandre Athayde\Documents\BancoTeste.mdf;Integrated Security=True;Connect Timeout=30"); //INSTANCIA DO SQLCONNECTION

            conecxao.Open();//ABRINDO A CONEXÃO COM O BANCO DE DADOS

            if (conecxao.State == ConnectionState.Open) //VERIFICANDO A CONEXÃO
            {
                MessageBox.Show("Conexão com Sucesso!", "Informação", MessageBoxButtons.OK,MessageBoxIcon.Information);

                var sql = "insert into Aluno(Nome, Email) values (@nome, @email)";
                var comando = new SqlCommand(sql,conecxao);

                comando.Parameters.AddWithValue("@nome", textBox5.Text);
                comando.Parameters.AddWithValue("@email", textBox3.Text);
                var retorno = comando.ExecuteNonQuery();
                

                if (retorno > 0)
                {
                    MessageBox.Show("Inserção OK!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                MessageBox.Show("Conexão Negada!");
            }
            conecxao.Close();//FECHANDO A CONEXÃO, NUMCA DEVE FICAR ABERTA A CONECXÃO

            
        }
    }
}
