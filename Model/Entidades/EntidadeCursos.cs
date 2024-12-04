using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class EntidadeCursos
    {
        public int ID_CURSO { get; set; }
        public string NOME_CUR { get; set; }
        public string SIGLA { get; set; }


        public object[] Linha()
        {
            return new object[] { ID_CURSO, NOME_CUR, SIGLA};
        }
    }
}
