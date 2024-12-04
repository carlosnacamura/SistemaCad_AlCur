using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAlunosCursos.DAO;

namespace SistemaAlunosCursos.Formulários.Forms_Cursos
{
    public partial class FrmEditarCurso : Form
    {
        private string LinhaConexao = "Server=CLAUDIA1968\\DBCARLOS;Database=SistemAlunCurs;User=carkapo;Password=112233; ";
        private SqlConnection Conexao;
        DaoAlunos dao = new DaoAlunos();
        public FrmEditarCurso(int cursoId)
        {
            InitializeComponent();
            string query = @"select ID_CURSO, NOME_CUR, SIGLA
                from CURSOS where ID_CURSO = @id";
            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.Parameters.Add(new SqlParameter("@id", cursoId));

            SqlDataReader Leitura = comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    label_id.Text = Leitura[0].ToString();
                    txtNome.Text = Leitura[1].ToString();
                    txtSigla.Text = Leitura[2].ToString();
                }
            }
            Conexao.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string query = "update CURSOS set NOME_CUR = @nome, SIGLA = @sigla WHERE  ID_CURSO = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
            comando.Parameters.Add(new SqlParameter("@sigla", txtSigla.Text));
            comando.Parameters.Add(new SqlParameter("@id", label_id.Text));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Curso Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
