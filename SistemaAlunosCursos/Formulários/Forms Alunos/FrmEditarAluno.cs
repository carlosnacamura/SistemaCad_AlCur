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
using SistemaAlunosCursos.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SistemaAlunosCursos.Formulários.Forms_Alunos
{
    public partial class FrmEditarAluno : Form
    {
        private string LinhaConexao = "Server=CLAUDIA1968\\DBCARLOS;Database=SistemAlunCurs;User=carkapo;Password=112233; ";
        private SqlConnection Conexao;
        DaoAlunos dao = new DaoAlunos();
        public FrmEditarAluno(int alunosId)
        {
            InitializeComponent();
            cbCursos.DataSource = dao.PreencherComboBox();
            cbCursos.DisplayMember = "NOME_CUR";
            cbCursos.ValueMember = "ID_CURSO";

            string query = @"select ID_ALUNO, NOME, IDADE,EMAIL,ID_CURSO
                from ALUNOS where ID_ALUNO = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@id", alunosId));

            SqlDataReader Leitura = comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    label_id.Text = Leitura[0].ToString();
                    txtNome.Text = Leitura[1].ToString();
                    numIdade.Value = Convert.ToInt32(Leitura[2]);
                    txtEmail.Text = Leitura[3].ToString();
                    cbCursos.SelectedValue = Convert.ToInt32(Leitura[4]);
                }
            }
            Conexao.Close();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string query = "update ALUNOS set NOME = @nome, IDADE = @idade, EMAIL = @email,ID_CURSO=@idCurso WHERE  ID_ALUNO = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
            comando.Parameters.Add(new SqlParameter("@idade", numIdade.Value));
            comando.Parameters.Add(new SqlParameter("@email", txtEmail.Text));
            comando.Parameters.Add(new SqlParameter("@idCurso", cbCursos.SelectedValue));
            comando.Parameters.Add(new SqlParameter("@id", label_id.Text));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Aluno(a) Atualizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string query = "Delete from ALUNOS WHERE ID_ALUNO = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            DialogResult resultado = MessageBox.Show("Tem certeza de que deseja excluir este aluno? Esta ação não pode ser revertida.",
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
                    MessageBox.Show("Aluno(a) excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FrmEditarAluno_Load(object sender, EventArgs e)
        {

        }

        
    }
}
