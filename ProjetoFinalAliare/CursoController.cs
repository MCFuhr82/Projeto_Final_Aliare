using ProjetoFinalAliare.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalAliare
{
    public static class CursoController
    {
        
        //Select cursos
        public static List<Curso> lerCursos()
        {
            var context = new Context();

            IEnumerable<Curso> cursos = from p in context.Curso select p;

            return cursos.ToList();
            
        }

        //Select Curso por Nome
        public static Curso SelectAlunoPorNome(string nome)
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
            catch (DbUpdateException ex)
            {
                //toDo
                throw;             
            }
        }

    }
}
