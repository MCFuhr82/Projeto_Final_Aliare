namespace ProjetoFinalAliare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BD_Inicio1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("public.Curso", "Matricula_Matricula", "public.Aluno");
            DropIndex("public.Curso", new[] { "Matricula_Matricula" });
            AddColumn("public.Aluno", "IdCurso_Id", c => c.Int());
            CreateIndex("public.Aluno", "IdCurso_Id");
            AddForeignKey("public.Aluno", "IdCurso_Id", "public.Curso", "Id");
            DropColumn("public.Curso", "Matricula_Matricula");
        }
        
        public override void Down()
        {
            AddColumn("public.Curso", "Matricula_Matricula", c => c.Int());
            DropForeignKey("public.Aluno", "IdCurso_Id", "public.Curso");
            DropIndex("public.Aluno", new[] { "IdCurso_Id" });
            DropColumn("public.Aluno", "IdCurso_Id");
            CreateIndex("public.Curso", "Matricula_Matricula");
            AddForeignKey("public.Curso", "Matricula_Matricula", "public.Aluno", "Matricula");
        }
    }
}
