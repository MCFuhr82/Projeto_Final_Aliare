namespace ProjetoFinalAliare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Turma : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Turma",
                c => new
                    {
                        Semestre = c.Int(nullable: false, identity: true),
                        Periodo = c.String(nullable: false),
                        Curso_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Semestre)
                .ForeignKey("public.Curso", t => t.Curso_Id)
                .Index(t => t.Curso_Id);
            
            AddColumn("public.Aluno", "Turma_Semestre", c => c.Int());
            CreateIndex("public.Aluno", "Turma_Semestre");
            AddForeignKey("public.Aluno", "Turma_Semestre", "public.Turma", "Semestre");
        }
        
        public override void Down()
        {
            DropForeignKey("public.Turma", "Curso_Id", "public.Curso");
            DropForeignKey("public.Aluno", "Turma_Semestre", "public.Turma");
            DropIndex("public.Turma", new[] { "Curso_Id" });
            DropIndex("public.Aluno", new[] { "Turma_Semestre" });
            DropColumn("public.Aluno", "Turma_Semestre");
            DropTable("public.Turma");
        }
    }
}
