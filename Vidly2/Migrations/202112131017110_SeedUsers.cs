namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'46bf9ae0-f7e4-4f32-a402-f09987a515df', N'guest@vidly.com', 0, N'ADC4CNK+JVJXLf/19+u35PEGMiUbOBoceTVlEXBxZvnw0VQ0FoUh3CBQPOo2pkPvjA==', N'a37cedb5-7572-48c3-a820-df6eb6e42d4a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cc8483fa-dc5b-4267-93af-b85e4026e0bc', N'admin@vidly.com', 0, N'ANJ8jPjVfSTnQcoOkka6fdggvR/GB93A2q3+hzB6krpNMGRsaYSY56H2s3peQssomQ==', N'b4b47748-0f7b-4042-9d60-417eac7f8397', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0d227f0e-1915-4a07-8412-6f9dd4263ec4', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cc8483fa-dc5b-4267-93af-b85e4026e0bc', N'0d227f0e-1915-4a07-8412-6f9dd4263ec4')
            ");
        }

        public override void Down()
        {
        }
    }
}
