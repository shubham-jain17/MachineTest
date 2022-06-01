namespace MachineTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductInformations",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 255),
                        ProductCategory = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Sku = c.String(nullable: false, maxLength: 8),
                        Product_Name = c.String(nullable: false, maxLength: 50),
                        Qty = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Sku);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.ProductInformations");
        }
    }
}
