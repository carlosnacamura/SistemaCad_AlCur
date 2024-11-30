using CadAlunCurs.DAOB;
using CadAlunCurs.Formulários.Cadastrar;
using CadAlunCurs.Formulários.Editar;
using Model.Entidades;
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
    public partial class Aluno : Form
    {
        DataTable dados;
        DAOAlunos dao = new DAOAlunos();

        public Aluno()
        {
            InitializeComponent();
            dados = new DataTable();
            
            foreach (var atributos in typeof(EntidadeAlunos).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados = dao.ObterAlunos();

            dtAluno.DataSource = dados;
        }

        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtAluno.DataSource = dao.ObterAlunos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadastroAluno cadastro = new FrmCadastroAluno();
            cadastro.FormClosed += Fechou_Editar_FormClosed;
            cadastro.ShowDialog();
        }

        private void dtAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dtAluno.Rows[e.RowIndex].Cells[0].Value);
                FrmEditarAluno editar = new FrmEditarAluno(id);
                editar.FormClosed += Fechou_Editar_FormClosed;
                editar.ShowDialog();
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            dtAluno.DataSource = dao.Pesquisar(txtPesquisa.Text);
        }

        private void Aluno_Load(object sender, EventArgs e)
        {

        }
    }
}
