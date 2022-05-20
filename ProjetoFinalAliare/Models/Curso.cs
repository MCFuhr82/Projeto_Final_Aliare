using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalAliare.Models
{
    [Table("Curso", Schema = "public")]
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        [Required]
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
