namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateFKinTopic : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Topics", name: "Document_Id", newName: "DocumentId");
            RenameIndex(table: "dbo.Topics", name: "IX_Document_Id", newName: "IX_DocumentId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Topics", name: "IX_DocumentId", newName: "IX_Document_Id");
            RenameColumn(table: "dbo.Topics", name: "DocumentId", newName: "Document_Id");
        }
    }
}
