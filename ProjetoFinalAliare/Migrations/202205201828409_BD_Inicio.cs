namespace ProjetoFinalAliare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BD_Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Aluno",
                c => new
                    {
                        Matricula = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        CPF = c.String(nullable: false),
                        Celular = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        CEP = c.String(nullable: false),
                        Endereco = c.String(nullable: false),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(),
                        Cidade = c.String(nullable: false),
                        Estado = c.String(nullable: false),
                        IdCurso_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Matricula)
                .ForeignKey("public.Curso", t => t.IdCurso_Id)
                .Index(t => t.IdCurso_Id);
            
            CreateTable(
                "public.Curso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        CargaHoraria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Aluno", "IdCurso_Id", "public.Curso");
            DropIndex("public.Aluno", new[] { "IdCurso_Id" });
            DropTable("public.Curso");
            DropTable("public.Aluno");
        }
    }
}
