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
    public partial class Curso : Form
    {
        DataTable dados;
        DAOCursos dao = new DAOCursos();
        public Curso()
        {
             InitializeComponent();
            dados = new DataTable();
            
            foreach (var atributos in typeof(EntidadeCursos).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dtCurso.DataSource = dados;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadastroCurso cadastro = new FrmCadastroCurso();
            cadastro.FormClosed += Fechou_Editar_FormClosed;
            cadastro.ShowDialog();
        }

        private void dtCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dtCurso.Rows[e.RowIndex].Cells[0].Value);
                FrmEditarCurso editar = new FrmEditarCurso(id);
                editar.FormClosed += Fechou_Editar_FormClosed;
                editar.ShowDialog();
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            dtCurso.DataSource = dao.Pesquisar(txtPesquisa.Text);
        }
        private void Curso_Load(object sender, EventArgs e)
        {

        }
    }
}
