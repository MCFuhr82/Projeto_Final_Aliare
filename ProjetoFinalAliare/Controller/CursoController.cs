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
    public static class CursoController
    {
        
        //Select cursos
        public static List<Curso> SelecionarCursos()
        {
            var context = new Context();

            IEnumerable<Curso> cursos = from p in context.Curso select p;

            return cursos.ToList();
            
        }

        //Select Curso por Id
        public static Curso SelectCursoPorId(int id)
        {
            using (var context = new Context())
            {
                var curso = context.Curso.Where(x => x.Id == id).FirstOrDefault();

                return curso;
            }
        }

        //Select Curso por Nome
        public static Curso SelectCursoPorNome(string nome)
        {
            using (var context = new Context())
            {
                var curso = context.Curso.Where(x => x.Nome == nome).FirstOrDefault();

                return curso;
            }
        }

        //Delete Curso
        public static void DeleteCurso(int idCurso)
        {
            try
            {
                using (var context = new Context())
                {
                    var curso = context.Curso.Where(x => x.Id == idCurso).FirstOrDefault();

                    context.Curso.Remove(curso);
                    context.SaveChanges();
                }

            }
            catch (DbUpdateException)
            {
                throw;             
            }
        }

        //Inserir Curso
        public static void InserirCurso(Curso curso)
        {
            using (var context = new Context())
            {
                context.Curso.Add(curso);
                context.SaveChanges();
            }
        }

        //Update Curso
        public static void UpdateCurso(Curso curso)
        {
            using (var context = new Context())
            {
                context.Entry(curso).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        //Retorna uma lista de Alunos por Curso
        public static List<Aluno> ListaAlunos(string nomeCurso)
        {
            using (var context = new Context())
            {
                var curso = context.Curso.Where(x => x.Nome == nomeCurso).FirstOrDefault();
                var alunos = curso.Alunos.ToList();
                return alunos;
            }
        }

    }
}
