namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class defaultdatapp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "ProfilePicture", c => c.String(maxLength: 250, nullable: false, defaultValue: "~/images/news/user1.png"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "ProfilePicture", c => c.String());
        }
    }
}
