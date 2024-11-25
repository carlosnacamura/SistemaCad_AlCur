using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadAlunCurs.DAOB
{
   
    class DAOAlunos
    {
        private string LinhaConexao = "Server=SistemAlunCar;Database=BD_ALUNCURS;User Id=root;Password=;";
        private SqlConnection Conexao;
        public DAOAlunos()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(EntidadeAlunos obj)
        {
            Conexao.Open();
            string query = "Insert into ALUNOS (ID_ALUNOS, NOME, IDADE,EMAIL,ID_CURSO) Values (@idAlunos, @nome, @idade,@email,idCurso) ";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@idAluno", obj.ID_ALUNO);
            SqlParameter parametro2 = new SqlParameter("@nome", obj.NOME);
            SqlParameter parametro3 = new SqlParameter("@idade", obj.IDADE);
            SqlParameter parametro4 = new SqlParameter("@email", obj.EMAIL);
            SqlParameter parametro5 = new SqlParameter("@idCurso", obj.ID_CURSO);


            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);

            comando.ExecuteNonQuery();
            Conexao.Close();

        }

        public DataTable ObterAlunosCursos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT C.Nome AS NomeCurso, D.Nome AS NomeDisciplina, cd.periodo " +
               "FROM CURSO_DISCIPLINA CD " +
               "INNER JOIN CURSOS C ON C.Id = CD.Curso_Id " +
               "INNER JOIN DISCIPLINAS D ON D.Id = CD.Disciplina_Id " +
               "ORDER BY CD.Id DESC";

            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = comando.ExecuteReader();

            dt.Columns.Add("NomeCurso");
            dt.Columns.Add("NomeDisciplina");
            dt.Columns.Add("Periodo");

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    EntidadeAlunos a = new EntidadeAlunos();

                    a.NOME = Leitura[0].ToString();
                    a.IDADE = Convert.ToInt32(Leitura[1]);
                    a.EMAIL = Leitura[2].ToString();
                    a.ID_CURSO = Convert.ToInt32(Leitura[3]);
                    a.ID_ALUNO = Convert.ToInt32(Leitura[4]);
                    dt.Rows.Add(a.Linha());

                }
            }
            Conexao.Close();
            return dt;


        }
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ID_ALUNO,NOME FROM ALUNOS";

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
        public DataTable ObterAlunos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "Select * From ALUNOS Order BY Id desc";
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
                    aluno.IDADE = Convert.ToInt32(leitura[2]);
                    aluno.EMAIL = leitura[3].ToString();
                    aluno.ID_CURSO = Convert.ToInt32(leitura[4]);

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
                query = "SELECT ID_ALUNO,NOME,IDADE,EMAIL FROM ALUNOS order by ID_ALUNO desc";
            }
            else
            {
                query = "SELECT * FROM ALUNOS where NOME LIKE '%" + pesquisar + "%' Order by ID_ALUNO desc";
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
