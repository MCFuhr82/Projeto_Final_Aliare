using ProjetoFinalAliare.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalAliare
{
    public class Context : DbContext
    {
        public Context() : base("PgFaculdade")
        {

        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
    }
}
