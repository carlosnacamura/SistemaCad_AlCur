using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAlunosCursos.DAO;
using SistemaAlunosCursos.Formulários.Forms_Alunos;
using SistemaAlunosCursos.Formulários.Forms_Cursos;

namespace SistemaAlunosCursos.Formulários
{
   
    public partial class FrmMenu : Form
    {
        DaoUsuarios dao = new DaoUsuarios();
        FrmMain main = new FrmMain();
        public FrmMenu()
        {
            InitializeComponent();
            
        }


        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
        public void FecharForm(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }
        private void btnAlunos_Click(object sender, EventArgs e)
        {
            FrmAlunos a = new FrmAlunos();
            a.Show();
            a.FormClosed += FecharForm;
            this.Hide();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            FrmCursos c = new FrmCursos();
            c.Show();
            c.FormClosed += FecharForm;
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
