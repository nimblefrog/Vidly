namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMembershipTypePropertyName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "DisscountRate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DisscountRate", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "DiscountRate");
        }
    }
}
