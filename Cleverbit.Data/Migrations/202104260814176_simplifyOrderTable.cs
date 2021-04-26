namespace Cleverbit.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class simplifyOrderTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "UserId", c => c.Guid(nullable: false));
            AddColumn("dbo.Orders", "ProductId", c => c.Guid(nullable: false));
            DropColumn("dbo.Orders", "Customer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Customer", c => c.String(nullable: false));
            DropColumn("dbo.Orders", "ProductId");
            DropColumn("dbo.Orders", "UserId");
        }
    }
}
