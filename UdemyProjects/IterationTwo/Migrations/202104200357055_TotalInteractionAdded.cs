namespace CharactersApiTwo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TotalInteractionAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "TotalInteractions", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "TotalInteractions");
        }
    }
}
