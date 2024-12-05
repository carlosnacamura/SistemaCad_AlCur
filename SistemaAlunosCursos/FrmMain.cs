using System;
using System.Windows.Forms;
using Model.Entidades;
using SistemaAlunosCursos.DAO;
using SistemaAlunosCursos.Formulários;

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
        private void FecharForm(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (dao.UsuarioConfirmado(txtNome.Text,txtSenha.Text))
            {
                FrmMenu menu = new FrmMenu();
                menu.FormClosed += FecharForm;
                this.Hide();
                txtNome.Text = "";
                txtSenha.Text = "";
                txtNome.Focus();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuário e senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
