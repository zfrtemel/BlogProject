namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class statusmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
            AddColumn("dbo.Admins", "StatusId", c => c.Int());
            AddColumn("dbo.Authors", "StatusId", c => c.Int());
            AddColumn("dbo.Blogs", "StatusId", c => c.Int());
            AddColumn("dbo.Categories", "StatusId", c => c.Int());
            AddColumn("dbo.Comments", "StatusId", c => c.Int());
            CreateIndex("dbo.Admins", "StatusId");
            CreateIndex("dbo.Authors", "StatusId");
            CreateIndex("dbo.Blogs", "StatusId");
            CreateIndex("dbo.Categories", "StatusId");
            CreateIndex("dbo.Comments", "StatusId");
            AddForeignKey("dbo.Admins", "StatusId", "dbo.Status", "StatusId");
            AddForeignKey("dbo.Categories", "StatusId", "dbo.Status", "StatusId");
            AddForeignKey("dbo.Comments", "StatusId", "dbo.Status", "StatusId");
            AddForeignKey("dbo.Blogs", "StatusId", "dbo.Status", "StatusId");
            AddForeignKey("dbo.Authors", "StatusId", "dbo.Status", "StatusId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Authors", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Blogs", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Comments", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Categories", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Admins", "StatusId", "dbo.Status");
            DropIndex("dbo.Comments", new[] { "StatusId" });
            DropIndex("dbo.Categories", new[] { "StatusId" });
            DropIndex("dbo.Blogs", new[] { "StatusId" });
            DropIndex("dbo.Authors", new[] { "StatusId" });
            DropIndex("dbo.Admins", new[] { "StatusId" });
            DropColumn("dbo.Comments", "StatusId");
            DropColumn("dbo.Categories", "StatusId");
            DropColumn("dbo.Blogs", "StatusId");
            DropColumn("dbo.Authors", "StatusId");
            DropColumn("dbo.Admins", "StatusId");
            DropTable("dbo.Status");
        }
    }
}
