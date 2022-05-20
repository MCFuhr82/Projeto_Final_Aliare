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
                    })
                .PrimaryKey(t => t.Matricula);
            
            CreateTable(
                "public.Curso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Matricula_Matricula = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Aluno", t => t.Matricula_Matricula)
                .Index(t => t.Matricula_Matricula);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Curso", "Matricula_Matricula", "public.Aluno");
            DropIndex("public.Curso", new[] { "Matricula_Matricula" });
            DropTable("public.Curso");
            DropTable("public.Aluno");
        }
    }
}
