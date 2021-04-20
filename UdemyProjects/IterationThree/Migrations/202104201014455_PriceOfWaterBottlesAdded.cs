namespace WaterBottlesApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriceOfWaterBottlesAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WaterBottles", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WaterBottles", "Price");
        }
    }
}
