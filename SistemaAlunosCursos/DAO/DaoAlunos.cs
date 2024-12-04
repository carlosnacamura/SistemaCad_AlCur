using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entidades;

namespace SistemaAlunosCursos.DAO
{
    public class DaoAlunos
    {
        //private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private string LinhaConexao = "Server=CLAUDIA1968\\DBCARLOS;Database=SistemAlunCurs;User=carkapo;Password=112233;";
        private SqlConnection Conexao;

        public DaoAlunos() 
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(EntidadeAlunos aluno)
        {
            Conexao.Open();
            string query = "Insert into ALUNOS (ID_ALUNO,NOME, IDADE, EMAIL, ID_CURSO) Values (idAluno,@nome,@idade, @email, @idCurso)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@idAluno", aluno.ID_ALUNO);
            SqlParameter parametro2 = new SqlParameter("@nome", aluno.NOME);
            SqlParameter parametro3 = new SqlParameter("@idade", aluno.IDADE);
            SqlParameter parametro4 = new SqlParameter("@email", aluno.EMAIL);
            SqlParameter parametro5 = new SqlParameter("@idCurso", aluno.ID_CURSO);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterAlunos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "Select * From ALUNOS Order BY ID_ALUNO desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
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
                    aluno.IDADE = Convert.ToInt32(leitura[2]);
                    aluno.EMAIL = leitura[3].ToString();
                    aluno.ID_CURSO= Convert.ToInt32(leitura[4]);
                    dt.Rows.Add(aluno.Linha());


                }
            }
            Conexao.Close();
            return dt;


        }
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT ID_CURSO, NOME_CUR FROM CURSOS";

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
        public DataTable Pesquisar(string pesquisar)
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "";


            if (string.IsNullOrEmpty(pesquisar))
            {
                query = "SELECT * FROM ALUNOS order by ID_ALUNO desc";
            }
            else
            {
                query = $@"SELECT * FROM ALUNOS 
                            where NOME LIKE '%{pesquisar}%' OR
                            EMAIL LIKE '%{pesquisar}%'
                            Order by ID_ALUNO desc";
            }

            SqlCommand comando = new SqlCommand(query, Conexao);

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
                    aluno.IDADE = Convert.ToInt32(leitura[2]);
                    aluno.EMAIL = leitura[3].ToString();
                    aluno.ID_CURSO = Convert.ToInt32(leitura[4]);
                    dt.Rows.Add(aluno.Linha());
                }
            }
            Conexao.Close();
            return dt;

        }
    }
}
