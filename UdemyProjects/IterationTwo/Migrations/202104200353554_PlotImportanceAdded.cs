namespace CharactersApiTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlotImportanceAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "PlotImportance", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "PlotImportance");
        }
    }
}
