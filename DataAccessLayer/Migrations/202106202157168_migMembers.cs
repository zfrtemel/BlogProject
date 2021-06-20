namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migMembers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        UserName = c.String(maxLength: 20),
                        Password = c.String(maxLength: 250),
                        BirthDate = c.DateTime(nullable: false),
                        MailSubscribe = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MemberID);
            
            AddColumn("dbo.Comments", "MemberID", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "MemberID");
            AddForeignKey("dbo.Comments", "MemberID", "dbo.Members", "MemberID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "MemberID", "dbo.Members");
            DropIndex("dbo.Comments", new[] { "MemberID" });
            DropColumn("dbo.Comments", "MemberID");
            DropTable("dbo.Members");
        }
    }
}
