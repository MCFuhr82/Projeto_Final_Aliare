using ProjetoFinalAliare.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalAliare
{
    public static class AlunoController
    {
        //Selecionar Alunos
        public static List<Aluno> ReadAlunos()
        {
            using (var context = new Context())
            {
                var alunos = context.Aluno.Include(c => c.Curso).ToList();
                return alunos;
            } 
        }

        //Selecionar Aluno por ID
        public static Aluno SelectAlunoPorId(int matricula)
        {
            using (var context = new Context())
            {
                var aluno = context.Aluno.Where(x => x.Matricula == matricula).FirstOrDefault();

                return aluno;
            }
        }

        //Deletar Aluno
        public static void DeletarAluno(int matricula)
        {
            using (var context = new Context())
            {
                var aluno = context.Aluno.Where(x => x.Matricula == matricula).FirstOrDefault();
                
                context.Aluno.Remove(aluno);
                context.SaveChanges();
             }
         }

        //Inserir Aluno
        public static void InserirAluno(Aluno aluno)
        {
            using (var context = new Context())
            {
                context.Aluno.Add(aluno);
                context.SaveChanges();
            }
        }

        //Update aluno
        public static void UpdateAluno(Aluno aluno)
        {
            using (var context = new Context())
            {
                context.Entry(aluno).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
     }
}
