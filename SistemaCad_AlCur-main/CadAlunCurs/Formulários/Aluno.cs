using CadAlunCurs.DAOB;
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void dtAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Aluno_Load(object sender, EventArgs e)
        {

        }
    }
}
