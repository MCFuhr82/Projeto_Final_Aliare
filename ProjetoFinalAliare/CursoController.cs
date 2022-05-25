using ProjetoFinalAliare.Models;
using System;
using System.Collections.Generic;
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
    }
}
