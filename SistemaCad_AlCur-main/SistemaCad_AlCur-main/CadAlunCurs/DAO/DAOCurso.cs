using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model
namespace CadAlunCurs.DAO
{
    class DAOCurso
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public DAOCurso()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(EntidadeCurso curso)
        {
            Conexao.Open();
            string query = "Insert into CURSOS (NOME_CUR, SIGLA, ID_CURSO) Values (@nome,@sigla, @IdCurso)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", curso.NOME_CUR);
            SqlParameter parametro2 = new SqlParameter("@sigla", curso.SIGLA);
            SqlParameter parametro4 = new SqlParameter("@IdCurso", curso.ID_CURSO);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT ID_CURSO,NOME_CUR FROM CURSOS";

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
            string query = "Select * From CURSOS Order BY ID_CURSO desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.ExecuteReader();
            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(EntidadeCurso).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    EntidadeCurso curso = new EntidadeCurso();
                    curso.ID_CURSO = Convert.ToInt32(leitura[0]);
                    curso.NOME_CUR = leitura[1].ToString();
                    curso.SIGLA = leitura[2].ToString();
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
                query = "SELECT ID_CURSO,NOME_CUR,SIGLA FROM CURSOS order by ID_CURSO desc";
            }
            else
            {
                query = "SELECT ID_CURSO,NOME_CUR,SIGLA FROM CURSOS where NOME_CUR LIKE '%" + pesquisar + "%' Order by ID_CURSO desc";
            }

            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(EntidadeCurso).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    EntidadeCurso curso = new EntidadeCurso();
                    curso.ID_CURSO = Convert.ToInt32(leitura[0]);
                    curso.NOME = leitura[1].ToString();
                    curso.SIGLA = leitura[2].ToString();
                    dt.Rows.Add(curso.Linha());
                }
            }
            Conexao.Close();
            return dt;

        }
    }
}
