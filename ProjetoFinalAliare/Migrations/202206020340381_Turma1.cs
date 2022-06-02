namespace ProjetoFinalAliare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Turma1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("public.Aluno", "Turma_Semestre", "public.Turma");
            RenameColumn(table: "public.Aluno", name: "Turma_Semestre", newName: "Turma_Id");
            RenameIndex(table: "public.Aluno", name: "IX_Turma_Semestre", newName: "IX_Turma_Id");
            DropPrimaryKey("public.Turma");
            AddColumn("public.Turma", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("public.Turma", "Semestre", c => c.Int(nullable: false));
            AddPrimaryKey("public.Turma", "Id");
            AddForeignKey("public.Aluno", "Turma_Id", "public.Turma", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("public.Aluno", "Turma_Id", "public.Turma");
            DropPrimaryKey("public.Turma");
            AlterColumn("public.Turma", "Semestre", c => c.Int(nullable: false, identity: true));
            DropColumn("public.Turma", "Id");
            AddPrimaryKey("public.Turma", "Semestre");
            RenameIndex(table: "public.Aluno", name: "IX_Turma_Id", newName: "IX_Turma_Semestre");
            RenameColumn(table: "public.Aluno", name: "Turma_Id", newName: "Turma_Semestre");
            AddForeignKey("public.Aluno", "Turma_Semestre", "public.Turma", "Semestre");
        }
    }
}
