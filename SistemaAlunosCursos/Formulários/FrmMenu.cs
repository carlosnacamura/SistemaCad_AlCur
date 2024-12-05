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
        public FrmMenu()
        {
            InitializeComponent();
            
        }


        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            FrmAlunos a = new FrmAlunos();
            a.ShowDialog();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            FrmCursos c = new FrmCursos();
            c.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
