namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeTopicList : DbMigration
    {
        public override void Up()
        {
            Sql(@"
        INSERT INTO [dbo].[Topics] ([Name]) VALUES ('Cloud Computing')
        INSERT INTO [dbo].[Topics] ([Name]) VALUES ('Artificial Intelligence')
        INSERT INTO [dbo].[Topics] ([Name]) VALUES ('Networking')
        INSERT INTO [dbo].[Topics] ([Name]) VALUES ('Security')
        INSERT INTO [dbo].[Topics] ([Name]) VALUES ('Internet of Things')
        INSERT INTO [dbo].[Topics] ([Name]) VALUES ('Object Oriented Programming')
        INSERT INTO [dbo].[Topics] ([Name]) VALUES ('Functional Programming')
        INSERT INTO [dbo].[Topics] ([Name]) VALUES ('Machine Learning')
        INSERT INTO [dbo].[Topics] ([Name]) VALUES ('Deep Learning')
        INSERT INTO [dbo].[Topics] ([Name]) VALUES ('Neural Networks')
        INSERT INTO [dbo].[Topics] ([Name]) VALUES ('Web Frameworks')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
