using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadAlunCurs.Formulários.Editar
{
    private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
    private SqlConnection Conexao;
    public partial class txtDigl : Form
    {
        public txtDigl()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string query = "insert into CURSO (NOME_CUR, SIGLA) Values (@nomeCur, @sigla)";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@nomeCur", txtNome.Text));
            comando.Parameters.Add(new SqlParameter("@sigla", txtSigla.Text));
            int resposta = comando.ExecuteNonQuery();
            if (resposta == 1)
            {
                MessageBox.Show("Curso cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDigl_Load(object sender, EventArgs e)
        {

        }
    }
}
