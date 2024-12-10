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

    public class DaoCursos
    {
        private string LinhaConexao = "Server=LS05MPF;Database=SistemAlunCurs;User Id=sa;Password=admsasql;";
        //private string LinhaConexao = "Server=CLAUDIA1968\\DBCARLOS;Database=SistemAlunCurs;User=carkapo;Password=112233;";
        private SqlConnection Conexao;
        public DaoCursos()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(EntidadeCursos curso)
        {
            Conexao.Open();
            string query = "Insert into CURSOS (ID_CURSO,NOME_CUR, SIGLA) Values (idCuso,@nome,@sigla)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@idCurso", curso.ID_CURSO);
            SqlParameter parametro2 = new SqlParameter("@nome", curso.NOME_CUR);
            SqlParameter parametro3 = new SqlParameter("@idade", curso.SIGLA);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterCursos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "Select * From CURSOS Order BY ID_CURSO desc";
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
                    EntidadeCursos curso = new EntidadeCursos();
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
                query = "SELECT * FROM CURSOS order by ID_CURSO desc";
            }
            else
            {
                query = $@"SELECT * FROM CURSOS 
                            where NOME_CUR LIKE '%{pesquisar}%' OR
                            SIGLA LIKE '%{pesquisar}%'
                            Order by ID_CURSO desc";
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
                    EntidadeCursos curso = new EntidadeCursos();
                    curso.ID_CURSO = Convert.ToInt32(leitura[0]);
                    curso.NOME_CUR = leitura[1].ToString();
                    curso.SIGLA = leitura[2].ToString();
                    dt.Rows.Add(curso.Linha());
                }
            }
            Conexao.Close();
            return dt;

        }

    }
}
