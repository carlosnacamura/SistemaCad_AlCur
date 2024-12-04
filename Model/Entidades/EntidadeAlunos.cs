using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class EntidadeAlunos
    {
        public int ID_ALUNO { get; set; }
        public string NOME { get; set; }
        public int IDADE { get; set; }
        public string EMAIL { get; set; }
        public int ID_CURSO { get; set; }




        public object[] Linha()
        {
            return new object[] { ID_ALUNO, NOME, IDADE, EMAIL,ID_CURSO};
        }
    }
}
