using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entidades;
using SistemaAlunosCursos.DAO;

namespace SistemaAlunosCursos.Formulários.Forms_Usuarios
{
    public partial class FrmCadastrarUsuario : Form
    {
        public FrmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DaoUsuarios dao = new DaoUsuarios();
            if (txtSenha.Text == txtConfirmSenha.Text) 
            {
                dao.Inserir(txtNome.Text, txtSenha.Text);
                MessageBox.Show("Cadastro feito com sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("As senhas não coincidem", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
