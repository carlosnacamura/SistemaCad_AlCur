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
        private string LinhaConexao = "Server=LS05MPF;Database=SistemAlunCurs;User Id=sa;Password=admsasql;";
        // private string LinhaConexao = "Server=CLAUDIA1968\\DBCARLOS;Database=SistemAlunCurs;User=carkapo;Password=112233; ";
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string query = "Delete from CURSOS WHERE ID_CURSO = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            DialogResult resultado = MessageBox.Show("Tem certeza de que deseja excluir este curso? Esta ação não pode ser revertida.",
                                                     "Confirmação de Exclusão",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                SqlCommand comando = new SqlCommand(query, Conexao);
                comando.Parameters.Add(new SqlParameter("@id", label_id.Text));

                int resposta = comando.ExecuteNonQuery();

                if (resposta == 1)
                {
                    MessageBox.Show("Curso excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exclusão cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void FrmEditarCurso_Load(object sender, EventArgs e)
        {

        }
    }
    
}
