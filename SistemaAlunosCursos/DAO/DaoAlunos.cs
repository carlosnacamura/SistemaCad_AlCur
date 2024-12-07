using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            string query = @"SELECT 
                            ALUNOS.ID_ALUNO,
                            ALUNOS.NOME,
                            ALUNOS.IDADE,
                            ALUNOS.EMAIL,
                            ALUNOS.ID_CURSO,
                            CURSOS.NOME_CUR
                            FROM 
                                ALUNOS
                            INNER JOIN 
                                CURSOS
                            ON 
                                ALUNOS.ID_CURSO = CURSOS.ID_CURSO
                            ORDER BY 
                                 ID_ALUNO DESC;";
            //string query = "SELECT * FROM ALUNOS ORDER BY ID_ALUNO";
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
                    aluno.NOME_CUR = leitura[5].ToString();

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
                query = @"SELECT 
                            ALUNOS.ID_ALUNO,
                            ALUNOS.NOME,
                            ALUNOS.IDADE,
                            ALUNOS.EMAIL,
                            ALUNOS.ID_CURSO,
                            CURSOS.NOME_CUR
                            FROM 
                                ALUNOS
                            INNER JOIN 
                                CURSOS
                            ON 
                                ALUNOS.ID_CURSO = CURSOS.ID_CURSO
                            ORDER BY 
                                 ID_ALUNO DESC;";
            }
            else
            {
                query = $@"SELECT 
                            ALUNOS.ID_ALUNO,
                            ALUNOS.NOME,
                            ALUNOS.IDADE,
                            ALUNOS.EMAIL,
                            ALUNOS.ID_CURSO,
                            CURSOS.NOME_CUR
                            FROM 
                                ALUNOS
                            INNER JOIN 
                                CURSOS
                            ON 
                                ALUNOS.ID_CURSO = CURSOS.ID_CURSO
                            where NOME LIKE '%{pesquisar}%' OR
                            EMAIL LIKE '%{pesquisar}%' OR
                            CURSOS.NOME_CUR LIKE '%{pesquisar}%'
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
                    aluno.NOME_CUR = leitura[5].ToString();
                    dt.Rows.Add(aluno.Linha());
                }
            }
            Conexao.Close();
            return dt;

        }

        public void Excluir()
        {
            EntidadeAlunos alunos = new EntidadeAlunos();
            string query = "Delete from ALUNOS WHERE ID_ALUNO = @id";
            Conexao.Open();
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.Parameters.Add(new SqlParameter("@id",alunos.ID_ALUNO));
            int resposta = comando.ExecuteNonQuery();
            if (resposta == 1)
            {
                MessageBox.Show("Usuário Excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
        }
    }
}
