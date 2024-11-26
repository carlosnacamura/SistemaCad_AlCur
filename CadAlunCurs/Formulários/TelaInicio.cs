using CadAlunCurs.Formulários.Cadastrar;
using CadAlunCurs.Formulários.Editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadAlunCurs.Formulários
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            FrmCadastroCurso cc = new FrmCadastroCurso();
            cc.ShowDialog();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            FrmCadastroAluno ca = new FrmCadastroAluno();
            ca.ShowDialog();
        }
    }
}
