namespace CharactersApiTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelClassValidationAdd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Characters", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Characters", "FavFood", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Characters", "PlotImportance", c => c.String(nullable: false, maxLength: 1));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Characters", "PlotImportance", c => c.String(nullable: false));
            AlterColumn("dbo.Characters", "FavFood", c => c.String(nullable: false));
            AlterColumn("dbo.Characters", "Name", c => c.String(nullable: false));
        }
    }
}
