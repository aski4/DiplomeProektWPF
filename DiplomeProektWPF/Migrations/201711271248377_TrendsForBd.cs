namespace DiplomeProektWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrendsForBd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrendsForBds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Trends = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrendsForBds");
        }
    }
}
