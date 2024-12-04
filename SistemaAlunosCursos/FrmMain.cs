using System;
using System.Windows.Forms;
using SistemaAlunosCursos.Formulários;

namespace SistemaAlunosCursos
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string user = "user";
            string senha = "112233";

            if (txtNome.Text == user && txtSenha.Text == senha)
            {
                FrmMenu i = new FrmMenu();
                i.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor coloque um usuário válido", "Usuário Inválido",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
