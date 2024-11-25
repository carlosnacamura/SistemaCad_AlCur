using CadAlunCurs.DAOB;
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
            dados = dao.ObterCursos();

            dtCurso.DataSource = dados;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
        }

        private void dtCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Curso_Load(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
