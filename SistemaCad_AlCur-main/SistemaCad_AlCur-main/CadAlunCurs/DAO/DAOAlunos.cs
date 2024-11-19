using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entidades;

namespace CadAlunCurs.DAO
{
    class DAOAlunos
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public DAOAlunos()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(EntidadeAlunos aluno)
        {
            Conexao.Open();
            string query = "Insert into ALUNOS (NOME, DATA_NASC, EMAIL, ID_CURSO, ID_ALUNO) Values (@nome,@dataNasc, @email, @IdCurso, @IdAluno)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", aluno.NOME);
            SqlParameter parametro2 = new SqlParameter("@dataNasc", aluno.DATA_NASC);
            SqlParameter parametro3 = new SqlParameter("@email", aluno.EMAIL);
            SqlParameter parametro4 = new SqlParameter("@IdCurso", aluno.ID_CURSO);
            SqlParameter parametro5 = new SqlParameter("@IdAluno", aluno.ID_ALUNO);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);

            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT ID_ALUNO, NOME FROM ALUNOS";

            using (SqlConnection connection = new SqlConnection(LinhaConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao acessar os dados: " + ex.Message);
                }
            }

            return dataTable;
        }
        public DataTable obterAlunos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "Select * From ALUNOS Order BY ID_ALUNO desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.ExecuteReader();
            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(EntidadeAlunos).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    EntidadeAlunos aluno = new EntidadeAlunos();
                    aluno.ID_ALUNO = Convert.ToInt32(leitura[0]);
                    aluno.NOME = leitura[1].ToString();
                    aluno.DATA_NASC = leitura[2].ToString();
                    aluno.EMAIL = leitura[3];
                    aluno.ID_CURSO = Convert.ToBoolean(leitura[4]);
                    dt.Rows.Add(aluno.Linha());


                }
            }
            Conexao.Close();
            return dt;


        }
        public DataTable Pesquisar(string pesquisar)
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "";


            if (string.IsNullOrEmpty(pesquisar))
            {
                query = "SELECT ID_ALUNO,NOME,EMAIL FROM ALUNOS order by ID_ALUNO desc";
            }
            else
            {
                query = "SELECT ID_ALUNO,NOME,EMAIL FROM ALUNOS where NOME LIKE '%" + pesquisar + "%' Order by ID_ALUNO desc";
            }

            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(AlunoEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    AlunoEntidade aluno = new AlunoEntidade();
                    aluno.ID = Convert.ToInt32(leitura[0]);
                    aluno.nome = leitura[1].ToString();
                    aluno.idade = Convert.ToInt32(leitura[2]);
                    aluno.sala = Convert.ToInt32(leitura[3]);
                    aluno.estudante = Convert.ToBoolean(leitura[4]);
                    aluno.apelido = leitura[5].ToString();
                    dt.Rows.Add(aluno.Linha());


                }
            }
            Conexao.Close();
            return dt;

        }
    }
    
}
