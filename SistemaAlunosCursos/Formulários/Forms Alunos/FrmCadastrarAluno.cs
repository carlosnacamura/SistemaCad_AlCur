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

namespace SistemaAlunosCursos.Formulários.Forms_Alunos
{
    public partial class FrmCadastrarAluno : Form
    {
        //private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private string LinhaConexao = "Server=CLAUDIA1968\\DBCARLOS;Database=SistemAlunCurs;User=carkapo;Password=112233; ";
        private SqlConnection Conexao;
        DaoAlunos dao = new DaoAlunos();
        public FrmCadastrarAluno()
        {
            InitializeComponent();
            cbCurso.DataSource = dao.PreencherComboBox();
            cbCurso.DisplayMember = "NOME_CUR";
            cbCurso.ValueMember = "ID_CURSO";
        }

        private void FrmCadastrarAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string query = "insert into ALUNOS (NOME, IDADE, EMAIL,ID_CURSO) Values (@nome, @idade, @email,@idCurso)";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
            comando.Parameters.Add(new SqlParameter("@idade", numIdade.Text));
            comando.Parameters.Add(new SqlParameter("@email", txtEmail.Text));
            comando.Parameters.Add(new SqlParameter("@idCurso", cbCurso.SelectedValue));


            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Aluno(a) cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
