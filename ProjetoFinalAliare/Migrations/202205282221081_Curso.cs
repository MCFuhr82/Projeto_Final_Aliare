namespace ProjetoFinalAliare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Curso : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "public.Aluno", name: "IdCurso_Id", newName: "Curso_Id");
            RenameIndex(table: "public.Aluno", name: "IX_IdCurso_Id", newName: "IX_Curso_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "public.Aluno", name: "IX_Curso_Id", newName: "IX_IdCurso_Id");
            RenameColumn(table: "public.Aluno", name: "Curso_Id", newName: "IdCurso_Id");
        }
    }
}
