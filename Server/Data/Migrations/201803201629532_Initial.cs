namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Role = c.Int(nullable: false),
                        SSID = c.String(),
                        Firstname = c.String(),
                        BirthDate = c.DateTime(),
                        DiscountRate = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        Lastname = c.String(),
                        Description = c.String(),
                        Picture = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        ActiveSince = c.DateTime(),
                        ActiveLast = c.DateTime(),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Picture = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        ActiveSince = c.DateTime(),
                        ActiveLast = c.DateTime(),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Connections",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Company = c.Int(nullable: false),
                        Description = c.String(),
                        Picture = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        ActiveSince = c.DateTime(),
                        ActiveLast = c.DateTime(),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VehicleID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        PriceID = c.Int(nullable: false),
                        StartDate = c.DateTime(),
                        FinalDate = c.DateTime(),
                        Returned = c.DateTime(),
                        IsOverdue = c.Boolean(nullable: false),
                        Description = c.String(),
                        Picture = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        ActiveSince = c.DateTime(),
                        ActiveLast = c.DateTime(),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Prices", t => t.PriceID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.VehicleID, cascadeDelete: true)
                .Index(t => t.VehicleID)
                .Index(t => t.UserID)
                .Index(t => t.PriceID);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BasePrice = c.Double(nullable: false),
                        SubTotal = c.Double(nullable: false),
                        TotalDue = c.Double(nullable: false),
                        TotalPayed = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BranchID = c.Int(nullable: false),
                        ManufacturerID = c.Int(nullable: false),
                        Model = c.String(),
                        Brand = c.String(),
                        Transmission = c.String(),
                        Color = c.String(),
                        LicenseID = c.String(),
                        Mileage = c.Int(nullable: false),
                        Owners = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        MarketPrice = c.Int(nullable: false),
                        Description = c.String(),
                        Picture = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        ActiveSince = c.DateTime(),
                        ActiveLast = c.DateTime(),
                        Longitude = c.Double(nullable: false),
                        Latitude = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Created = c.DateTime(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Branches", t => t.BranchID, cascadeDelete: true)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerID, cascadeDelete: true)
                .Index(t => t.BranchID)
                .Index(t => t.ManufacturerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "VehicleID", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "ManufacturerID", "dbo.Manufacturers");
            DropForeignKey("dbo.Vehicles", "BranchID", "dbo.Branches");
            DropForeignKey("dbo.Orders", "UserID", "dbo.Users");
            DropForeignKey("dbo.Orders", "PriceID", "dbo.Prices");
            DropForeignKey("dbo.Accounts", "UserID", "dbo.Users");
            DropIndex("dbo.Vehicles", new[] { "ManufacturerID" });
            DropIndex("dbo.Vehicles", new[] { "BranchID" });
            DropIndex("dbo.Orders", new[] { "PriceID" });
            DropIndex("dbo.Orders", new[] { "UserID" });
            DropIndex("dbo.Orders", new[] { "VehicleID" });
            DropIndex("dbo.Accounts", new[] { "UserID" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.Prices");
            DropTable("dbo.Orders");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Connections");
            DropTable("dbo.Branches");
            DropTable("dbo.Users");
            DropTable("dbo.Accounts");
        }
    }
}
