namespace DiplomeProektWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFFC : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TwitterUsersForBdFollowersFriendsForBds", "TwitterUsersForBd_Id", "dbo.TwitterUsersForBds");
            DropForeignKey("dbo.TwitterUsersForBdFollowersFriendsForBds", "FollowersFriendsForBd_Id", "dbo.FollowersFriendsForBds");
            DropIndex("dbo.TwitterUsersForBdFollowersFriendsForBds", new[] { "TwitterUsersForBd_Id" });
            DropIndex("dbo.TwitterUsersForBdFollowersFriendsForBds", new[] { "FollowersFriendsForBd_Id" });
            AddColumn("dbo.FollowersFriendsForBds", "User_Id", c => c.Int());
            CreateIndex("dbo.FollowersFriendsForBds", "User_Id");
            AddForeignKey("dbo.FollowersFriendsForBds", "User_Id", "dbo.TwitterUsersForBds", "Id");
            DropTable("dbo.TwitterUsersForBdFollowersFriendsForBds");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TwitterUsersForBdFollowersFriendsForBds",
                c => new
                    {
                        TwitterUsersForBd_Id = c.Int(nullable: false),
                        FollowersFriendsForBd_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TwitterUsersForBd_Id, t.FollowersFriendsForBd_Id });
            
            DropForeignKey("dbo.FollowersFriendsForBds", "User_Id", "dbo.TwitterUsersForBds");
            DropIndex("dbo.FollowersFriendsForBds", new[] { "User_Id" });
            DropColumn("dbo.FollowersFriendsForBds", "User_Id");
            CreateIndex("dbo.TwitterUsersForBdFollowersFriendsForBds", "FollowersFriendsForBd_Id");
            CreateIndex("dbo.TwitterUsersForBdFollowersFriendsForBds", "TwitterUsersForBd_Id");
            AddForeignKey("dbo.TwitterUsersForBdFollowersFriendsForBds", "FollowersFriendsForBd_Id", "dbo.FollowersFriendsForBds", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TwitterUsersForBdFollowersFriendsForBds", "TwitterUsersForBd_Id", "dbo.TwitterUsersForBds", "Id", cascadeDelete: true);
        }
    }
}
