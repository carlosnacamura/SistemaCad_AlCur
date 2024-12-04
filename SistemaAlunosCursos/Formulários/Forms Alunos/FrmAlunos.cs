using System;
using System.Data;
using System.Windows.Forms;
using Model.Entidades;
using SistemaAlunosCursos.DAO;

namespace SistemaAlunosCursos.Formulários.Forms_Alunos
{
    public partial class FrmAlunos : Form
    {
        DaoAlunos dao = new DaoAlunos();
        DataTable dados;
        int LinhaSelecionada;
        public FrmAlunos()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridAlunos.DataSource = dados;
            foreach (var atributos in typeof(EntidadeAlunos).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dtGridAlunos.DataSource = dao.ObterAlunos();
        }

        private void FrmAlunos_Load(object sender, EventArgs e)
        {

        }
        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridAlunos.DataSource = dao.ObterAlunos();
        }
        private void dtGridAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(
                        dtGridAlunos.Rows[e.RowIndex].Cells[0].Value);


                    FrmEditarAluno editar = new FrmEditarAluno(id);

                    
                    editar.FormClosed += Fechou_Editar_FormClosed;

                    editar.ShowDialog();
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridAlunos.DataSource = dao.Pesquisar(txtPesquisa.Text);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadastrarAluno cadastro = new FrmCadastrarAluno();
            cadastro.FormClosed += Fechou_Editar_FormClosed;
            cadastro.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
