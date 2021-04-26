namespace Cleverbit.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_auditable_fields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "CreatedDate");
            DropColumn("dbo.Products", "UpdatedDate");
            DropColumn("dbo.Products", "IsActive");
            DropColumn("dbo.Orders", "CreatedDate");
            DropColumn("dbo.Orders", "UpdatedDate");
            DropColumn("dbo.Orders", "IsActive");
        }
    }
}
