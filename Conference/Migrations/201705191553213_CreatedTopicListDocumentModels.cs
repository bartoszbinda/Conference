namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedTopicListDocumentModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 300),
                        ApplicationUserId = c.String(),
                        Abstract = c.String(nullable: false, maxLength: 2000),
                        Body = c.String(nullable: false),
                        References = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 300),
                        Document_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Documents", t => t.Document_Id)
                .Index(t => t.Document_Id);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Topics", "Document_Id", "dbo.Documents");
            DropIndex("dbo.Topics", new[] { "Document_Id" });
            DropTable("dbo.Topics");
            DropTable("dbo.Documents");
        }
    }
}
