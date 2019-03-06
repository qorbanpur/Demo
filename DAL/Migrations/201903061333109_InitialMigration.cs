namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscription",
                c => new
                    {
                        SubscriptionId = c.Guid(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceIncVatAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CallMinutes = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SubscriptionId);
            
            CreateTable(
                "dbo.UserSubscription",
                c => new
                    {
                        UserSubscriptionId = c.Guid(nullable: false),
                        UserId = c.Int(nullable: false),
                        SubscriptionId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.UserSubscriptionId)
                .ForeignKey("dbo.Subscription", t => t.SubscriptionId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.SubscriptionId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserSubscription", "UserId", "dbo.User");
            DropForeignKey("dbo.UserSubscription", "SubscriptionId", "dbo.Subscription");
            DropIndex("dbo.UserSubscription", new[] { "SubscriptionId" });
            DropIndex("dbo.UserSubscription", new[] { "UserId" });
            DropTable("dbo.User");
            DropTable("dbo.UserSubscription");
            DropTable("dbo.Subscription");
        }
    }
}
