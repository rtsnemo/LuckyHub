namespace StyleHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSpecialOfferToCloth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clothes", "SpecialOffer", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clothes", "SpecialOffer");
        }
    }
}
