namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedForeignKeyInCommentAndPosts : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Posts", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Posts", "ApplicationUserId");
            RenameColumn(table: "dbo.Comments", name: "ApplicationUser_Id", newName: "ApplicationUserId");
            RenameColumn(table: "dbo.Posts", name: "ApplicationUser_Id", newName: "ApplicationUserId");
            RenameIndex(table: "dbo.Comments", name: "IX_ApplicationUser_Id", newName: "IX_ApplicationUserId");
            AlterColumn("dbo.Posts", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Posts", "ApplicationUserId");
            DropColumn("dbo.Comments", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "UserId", c => c.Int(nullable: false));
            DropIndex("dbo.Posts", new[] { "ApplicationUserId" });
            AlterColumn("dbo.Posts", "ApplicationUserId", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Comments", name: "IX_ApplicationUserId", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.Posts", name: "ApplicationUserId", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.Comments", name: "ApplicationUserId", newName: "ApplicationUser_Id");
            AddColumn("dbo.Posts", "ApplicationUserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "ApplicationUser_Id");
        }
    }
}
