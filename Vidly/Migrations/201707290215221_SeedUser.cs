namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'351c9afd-dabd-458c-a521-030f5bfb8cd3', N'admin@vidly.com', 0, N'AAH25L7+8U1n5BPiNU1BLl1Oh9oQgqNS2qJDjZ/35fFnNBM9BtDPg5wgvyR8h+yjRA==', N'0dbbe382-6144-44a1-b503-1598930c9231', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b073fd73-d337-4c3b-9430-d4ccca927047', N'guest@vidly.com', 0, N'ANB6uDPcp39VFsS37FgC5kYTur3QDZIxYGZVxPfGcQ3X6HQlCTxQ6/CQ/Fy/oNnU+w==', N'e752d3d2-9f5b-4589-80c7-958199ff5174', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')


                INSERT INTO[dbo].[AspNetRoles]([Id], [Name]) VALUES(N'd48170bd-5588-43ff-9a24-2c201bd54a24', N'CanManageMovies')
                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'351c9afd-dabd-458c-a521-030f5bfb8cd3', N'd48170bd-5588-43ff-9a24-2c201bd54a24')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
