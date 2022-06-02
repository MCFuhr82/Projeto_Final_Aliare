namespace ProjetoFinalAliare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Turma2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Turma", "Nome", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("public.Turma", "Nome");
        }
    }
}
