namespace DiplomeProektWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FollowersFriendsForBds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Followers = c.Int(),
                        Friends = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HashTagsForBds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HashTags = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TweetsForBds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                        TimeOfTweet = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TwitterUsersForBds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        FullName = c.String(maxLength: 50),
                        ScreenName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TwitterUsersForBds");
            DropTable("dbo.TweetsForBds");
            DropTable("dbo.HashTagsForBds");
            DropTable("dbo.FollowersFriendsForBds");
        }
    }
}
