namespace DiplomeProektWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewLinks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TwitterUsersForBdFollowersFriendsForBds",
                c => new
                    {
                        TwitterUsersForBd_Id = c.Int(nullable: false),
                        FollowersFriendsForBd_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TwitterUsersForBd_Id, t.FollowersFriendsForBd_Id })
                .ForeignKey("dbo.TwitterUsersForBds", t => t.TwitterUsersForBd_Id, cascadeDelete: true)
                .ForeignKey("dbo.FollowersFriendsForBds", t => t.FollowersFriendsForBd_Id, cascadeDelete: true)
                .Index(t => t.TwitterUsersForBd_Id)
                .Index(t => t.FollowersFriendsForBd_Id);
            
            CreateTable(
                "dbo.HashTagsForBdTweetsForBds",
                c => new
                    {
                        HashTagsForBd_Id = c.Int(nullable: false),
                        TweetsForBd_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.HashTagsForBd_Id, t.TweetsForBd_Id })
                .ForeignKey("dbo.HashTagsForBds", t => t.HashTagsForBd_Id, cascadeDelete: true)
                .ForeignKey("dbo.TweetsForBds", t => t.TweetsForBd_Id, cascadeDelete: true)
                .Index(t => t.HashTagsForBd_Id)
                .Index(t => t.TweetsForBd_Id);
            
            AddColumn("dbo.TweetsForBds", "User_Id", c => c.Int());
            CreateIndex("dbo.TweetsForBds", "User_Id");
            AddForeignKey("dbo.TweetsForBds", "User_Id", "dbo.TwitterUsersForBds", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TweetsForBds", "User_Id", "dbo.TwitterUsersForBds");
            DropForeignKey("dbo.HashTagsForBdTweetsForBds", "TweetsForBd_Id", "dbo.TweetsForBds");
            DropForeignKey("dbo.HashTagsForBdTweetsForBds", "HashTagsForBd_Id", "dbo.HashTagsForBds");
            DropForeignKey("dbo.TwitterUsersForBdFollowersFriendsForBds", "FollowersFriendsForBd_Id", "dbo.FollowersFriendsForBds");
            DropForeignKey("dbo.TwitterUsersForBdFollowersFriendsForBds", "TwitterUsersForBd_Id", "dbo.TwitterUsersForBds");
            DropIndex("dbo.HashTagsForBdTweetsForBds", new[] { "TweetsForBd_Id" });
            DropIndex("dbo.HashTagsForBdTweetsForBds", new[] { "HashTagsForBd_Id" });
            DropIndex("dbo.TwitterUsersForBdFollowersFriendsForBds", new[] { "FollowersFriendsForBd_Id" });
            DropIndex("dbo.TwitterUsersForBdFollowersFriendsForBds", new[] { "TwitterUsersForBd_Id" });
            DropIndex("dbo.TweetsForBds", new[] { "User_Id" });
            DropColumn("dbo.TweetsForBds", "User_Id");
            DropTable("dbo.HashTagsForBdTweetsForBds");
            DropTable("dbo.TwitterUsersForBdFollowersFriendsForBds");
        }
    }
}
