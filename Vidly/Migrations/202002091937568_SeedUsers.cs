namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql
            (@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'28d29310-4d61-4e55-a2ed-28dff4008c46', N'admin@vidly.com', 0, N'AF60do7qaQzO8k3Vp5QUXFyuK3WL6hrzDNBPj+sV3Chkokbiq1Hq2RiCY5oapsA+QQ==', N'83e09e01-88f0-4100-9592-305676dd0f86', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4887d1bd-7829-46ab-a226-a27e9939257b', N'guest@vidly.com', 0, N'AOGyP2qkmU/wZgL9eI2GNP9GHVb/bYQbahQ6UhZvJTqwJe/orhGw/uWDW1CCzryS3Q==', N'b706dec8-80ce-4602-8179-a64130e526c9', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1f1959f5-2e7f-4a80-a779-1ac68f627b05', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'28d29310-4d61-4e55-a2ed-28dff4008c46', N'1f1959f5-2e7f-4a80-a779-1ac68f627b05')
            ");
        }

        public override void Down()
        {
        }
    }
}
