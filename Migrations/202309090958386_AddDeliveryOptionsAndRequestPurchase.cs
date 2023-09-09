namespace StyleHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDeliveryOptionsAndRequestPurchase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeliveryOptions",
                c => new
                    {
                        DeliveryId = c.Int(nullable: false, identity: true),
                        DeliveryName = c.String(),
                    })
                .PrimaryKey(t => t.DeliveryId);
            
            CreateTable(
                "dbo.PurchaseRequests",
                c => new
                    {
                        PurchaseId = c.Int(nullable: false, identity: true),
                        ClothId = c.Int(nullable: false),
                        DeliveryId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PurchaseRequests");
            DropTable("dbo.DeliveryOptions");
        }
    }
}
