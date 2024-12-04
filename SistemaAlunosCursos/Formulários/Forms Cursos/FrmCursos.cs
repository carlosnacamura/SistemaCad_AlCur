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
using SistemaAlunosCursos.Formulários.Forms_Alunos;

namespace SistemaAlunosCursos.Formulários.Forms_Cursos
{
    public partial class FrmCursos : Form
    {
        DaoCursos dao = new DaoCursos();
        DataTable dados;
        int LinhaSelecionada;
        public FrmCursos()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridCursos.DataSource = dados;
            foreach (var atributos in typeof(EntidadeCursos).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dtGridCursos.DataSource = dao.ObterCursos();
        }
        private void Fechou_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGridCursos.DataSource = dao.ObterCursos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadastrarCurso c = new FrmCadastrarCurso();
            c.FormClosed += Fechou_Editar_FormClosed;
            c.ShowDialog();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dtGridCursos.DataSource = dao.Pesquisar(txtPesquisa.Text);
        }

        private void dtGridCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(
                        dtGridCursos.Rows[e.RowIndex].Cells[0].Value);


                    FrmEditarCurso editar = new FrmEditarCurso(id);


                    editar.FormClosed += Fechou_Editar_FormClosed;

                    editar.ShowDialog();
                }
            }
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {

        }
    }
}
