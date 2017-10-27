namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTopicLIstToDocument : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Topics", "Document_Id", c => c.Int());
            CreateIndex("dbo.Topics", "Document_Id");
            AddForeignKey("dbo.Topics", "Document_Id", "dbo.Documents", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Topics", "Document_Id", "dbo.Documents");
            DropIndex("dbo.Topics", new[] { "Document_Id" });
            DropColumn("dbo.Topics", "Document_Id");
        }
    }
}
