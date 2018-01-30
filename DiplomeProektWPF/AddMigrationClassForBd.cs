using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomeProektWPF
{
    public partial class AddMigrationClassForBd : DbMigration
    {
        public override void Up()
        {
            CreateTable("dbo.TrendsForBd", c => new
            {
                Id = c.Int(nullable: false, identity: true),
                Trends = c.String(maxLength: 50),
            })
            .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.TrendsForBd");
        }
    }
}
