namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFirstNameLastNameToUser1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.AspNetUsers", "IsReviewer", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "IsModerator", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsModerator");
            DropColumn("dbo.AspNetUsers", "IsReviewer");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
