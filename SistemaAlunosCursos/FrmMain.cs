using System;
using System.Windows.Forms;
using Model.Entidades;
using SistemaAlunosCursos.DAO;
using SistemaAlunosCursos.Formulários;
using SistemaAlunosCursos.Formulários.Forms_Usuarios;
using Microsoft.VisualBasic;
using System.Net.NetworkInformation;
namespace SistemaAlunosCursos
{
    public partial class FrmMain : Form
    {
        DaoUsuarios dao = new DaoUsuarios();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        public void FecharForm(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (dao.UsuarioConfirmado(txtNome.Text,txtSenha.Text))
            {
                FrmMenu menu = new FrmMenu(txtNome.Text);
                menu.FormClosed += FecharForm;
                this.Hide();
                txtNome.Text = "";
                txtSenha.Text = "";
                txtNome.Focus();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblAdicionarUsuario_Click(object sender, EventArgs e)
        {
            string senha = Interaction.InputBox("Digite a senha para acessar o cadastro de usuário:", "Autenticação", "");
            string senhaCorreta = "etec";

            if (senha == senhaCorreta)
            {
                FrmCadastrarUsuario cu = new FrmCadastrarUsuario();
                cu.Show();
            }
            else
            {
                MessageBox.Show("Senha incorreta. Acesso negado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
