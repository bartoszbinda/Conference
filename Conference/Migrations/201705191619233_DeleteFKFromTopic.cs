namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteFKFromTopic : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Topics", "Document_Id", "dbo.Documents");
            DropIndex("dbo.Topics", new[] { "Document_Id" });
            DropColumn("dbo.Topics", "Document_Id");

        }
        
        public override void Down()
        {
            AddColumn("dbo.Topics", "Document_Id", c => c.Int());
            CreateIndex("dbo.Topics", "Document_Id");
            AddForeignKey("dbo.Topics", "Document_Id", "dbo.Documents", "Id");
        }
    }
}
