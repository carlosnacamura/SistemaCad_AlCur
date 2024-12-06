using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class EntidadeUsuarios
    {
        public int ID_USUARIOS { get; set; }
        public string NOME { get; set; }
        public string SENHA { get; set; }

        public EntidadeUsuarios(string nome, string senha)
        {
            NOME = nome;
            SENHA = senha;
        }
        public object[] Linha()
        {
            return new object[] { ID_USUARIOS,NOME,SENHA};
        }
    }
}
