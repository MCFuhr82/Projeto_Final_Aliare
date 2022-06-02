using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalAliare.Models
{
    [Table("Turma", Schema = "public")]
    public class Turma
    {
        [Key]
        public int Id { get; private set; }
        [Required]
        public int Semestre { get; private set; }
        [Required]
        public string Periodo { get; private set; }
        [Required]
        public string Nome { get; private set; }
        public virtual Curso Curso { get; set; }
        public virtual ICollection<Aluno> Alunos { get; private set; }

        public Turma() {  }
        public Turma(int semestre, string periodo, string nome)
        {
            Semestre = semestre;
            Periodo = periodo;
            Nome = nome;
        }

    }
}
