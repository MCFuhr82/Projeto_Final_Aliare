using ProjetoFinalAliare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalAliare
{
    public static class AlunoController
    {
        //Select Alunos
        public static List<Aluno> ReadAlunos()
        {
            using (var context = new Context())
            {
                IEnumerable<Aluno> alunos = from aluno in context.Aluno select aluno;
                return alunos.ToList();
            } 
        }

        //Select Aluno por ID
        public static Aluno SelectAlunoPorId(int matricula)
        {
            using (var context = new Context())
            {
                var aluno = context.Aluno.Where(x => x.Matricula == matricula).FirstOrDefault();

                return aluno;
            }
        }

        //Delete Aluno
        public static void DeleteAluno(int matricula)
        {
            using (var context = new Context())
            {
                var aluno = context.Aluno.Where(x => x.Matricula == matricula).FirstOrDefault();
                
                context.Aluno.Remove(aluno);
                context.SaveChanges();
             }
         }
     }
}
