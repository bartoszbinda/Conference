namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManyToManyTopicsDocumentsMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TopicDocuments",
                c => new
                    {
                        Topic_Id = c.Int(nullable: false),
                        Document_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Topic_Id, t.Document_Id })
                .ForeignKey("dbo.Topics", t => t.Topic_Id, cascadeDelete: true)
                .ForeignKey("dbo.Documents", t => t.Document_Id, cascadeDelete: true)
                .Index(t => t.Topic_Id)
                .Index(t => t.Document_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TopicDocuments", "Document_Id", "dbo.Documents");
            DropForeignKey("dbo.TopicDocuments", "Topic_Id", "dbo.Topics");
            DropIndex("dbo.TopicDocuments", new[] { "Document_Id" });
            DropIndex("dbo.TopicDocuments", new[] { "Topic_Id" });
            DropTable("dbo.TopicDocuments");
        }
    }
}
