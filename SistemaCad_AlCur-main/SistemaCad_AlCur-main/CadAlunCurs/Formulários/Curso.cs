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
        DAOCurso dao = new DAOCurso();
        public Curso()
        {
             InitializeComponent();
            dados = new DataTable();
            
            foreach (var atributos in typeof(EntidadeCurso).GetProperties())
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
    }
}
