using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entidades
{
    public class EntidadeAlunos
    {
        public int ID_ALUNO { get; set; }
        public string NOME { get; set; }
        public string DATA_NASC { get; set; }
        public string EMAIL { get; set; }
        public long ID_CURSO { get; set; }

        public object[] Linha()
        {
            return new object[] { ID_ALUNO, NOME, DATA_NASC, EMAIL };
        }
    }
}
