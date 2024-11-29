using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadAlunCurs.DAOB
{
    class DAOCursos
    {
        
        private string LinhaConexao = "Server=localhost;Database=BD_ALUNCURS;Uid=root;Pwd=;";
        private SqlConnection Conexao;
        public DAOCursos()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(EntidadeCursos obj)
        {
            Conexao.Open();
            string query = "Insert into CURSOS (ID_CURSO, NOME_CUR,SIGLA) Values (@idCurso, @nome, @sigla) ";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@idCurso", obj.ID_CURSO);
            SqlParameter parametro2 = new SqlParameter("@nome", obj.NOME_CUR);
            SqlParameter parametro3 = new SqlParameter("@sigla", obj.SIGLA);


            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);

            comando.ExecuteNonQuery();
            Conexao.Close();

        }
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ID_CURSO,NOME FROM CURSOS";

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
        public DataTable ObterCursos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "Select * From CURSOS Order BY Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.ExecuteReader();
            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(EntidadeCursos).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    EntidadeCursos curso = new EntidadeCursos();
                    curso.ID_CURSO = Convert.ToInt32(leitura[0]);
                    curso.NOME_CUR = leitura[1].ToString();
                    curso.SIGLA = Convert.ToInt32(leitura[2]);

                    dt.Rows.Add(curso.Linha());


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
                query = "SELECT ID_CURSO FROM CURSOS order by ID_CURSO desc";
            }
            else
            {
                query = "SELECT * FROM CURSOS where NOME_CUR LIKE '%" + pesquisar + "%' Order by ID_CURSO desc";
            }

            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(EntidadeCursos).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    EntidadeCursos aluno = new EntidadeCursos();
                    aluno.ID_CURSO = Convert.ToInt32(leitura[0]);
                    aluno.NOME_CUR = leitura[1].ToString();
                    aluno.SIGLA = Convert.ToInt32(leitura[2]);
                    dt.Rows.Add(aluno.Linha());
                }
            }
            Conexao.Close();
            return dt;

        }
    }
}
