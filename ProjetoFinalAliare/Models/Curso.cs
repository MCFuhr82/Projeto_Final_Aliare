using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalAliare.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Aluno Matricula { get; private set; }

        public Curso() { }

        public Curso(string nome)
        {
            Nome = nome;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

    }
}
