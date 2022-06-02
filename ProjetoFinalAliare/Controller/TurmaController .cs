using ProjetoFinalAliare.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalAliare
{
    public static class TurmaController
    {
        
        //Selecionar turmas
        public static List<Turma> SelecionarTurmas()
        {
            var context = new Context();

            IEnumerable<Turma> turmas = from p in context.Turma select p;

            return turmas.ToList();
            
        }

        //Selecionar Turma por Nome
        public static Turma SelecionarTurmaPorNome(string nome)
        {
            using (var context = new Context())
            {
                var turma = context.Turma.Where(x => x.Nome == nome).FirstOrDefault();

                return turma;
            }
        }

        
        //Deletar Turma
        public static void DeletarTurma(int semestre)
        {
            try
            {
                using (var context = new Context())
                {
                    var turma = context.Turma.Where(x => x.Semestre == semestre).FirstOrDefault();

                    context.Turma.Remove(turma);
                    context.SaveChanges();
                }

            }
            catch (DbUpdateException)
            {
                throw;             
            }
        }

        //Inserir Turma
        public static void InserirTurma(Turma turma)
        {
            using (var context = new Context())
            {
                context.Turma.Add(turma);
                context.SaveChanges();
            }
        }

        //Update Turma
        public static void UpdateTurma(Turma turma)
        {
            using (var context = new Context())
            {
                context.Entry(turma).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //Retorna uma lista de Alunos por Turma
        public static List<Aluno> ListaAlunos(int semestre, string periodo)
        {
            using (var context = new Context())
            {
                var turma = context.Turma.Where(x => x.Semestre == semestre && x.Periodo == periodo).FirstOrDefault();
                var alunos = turma.Alunos.ToList();
                return alunos;
            }
        }

    }
}
