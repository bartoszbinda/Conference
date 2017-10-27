namespace Conference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateModeIsReviewerRole : DbMigration
    {
        public override void Up()
        {
            Sql(@"
        INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [IsReviewer], [IsModerator]) VALUES (N'cecbad9b-1f3b-4e04-ae2f-b30dca3080ed', N'bartoszdariuszbinda@gmail.com', 0, N'AOH8qhQBO+VNIIughWN0E4/AllQxjAoCIpNrzMs5Eq0yFLrjVI0KSRxhnwqm5nmMiA==', N'16967799-367b-4af1-9184-fd729b0dea12', NULL, 0, 0, NULL, 1, 0, N'bartoszdariuszbinda@gmail.com', N'Bartosz', N'Binda', 0, 0)
        INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [IsReviewer], [IsModerator]) VALUES (N'f60a2319-1269-44b2-90ef-f7b646dcbb71', N'batinex@gmail.com', 0, N'AGYUb/cZ+NYUX6vY8X/RyUh3UQDFbXF+I62qJA7oXUUZqEqVsk7L3QXSFp2Pp4q1Ng==', N'233c8479-26f7-4f55-80ac-e731948cc3a9', NULL, 0, 0, NULL, 1, 0, N'batinex@gmail.com', N'Bartosz', N'Binda', 0, 0)
            ");
            Sql(@"
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4a686f78-d995-41cc-bed9-76396ba202f7', N'IsAdmin')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f60a2319-1269-44b2-90ef-f7b646dcbb71', N'4a686f78-d995-41cc-bed9-76396ba202f7')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
