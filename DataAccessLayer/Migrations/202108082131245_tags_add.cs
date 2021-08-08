namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tags_add : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TagBlogs", "Tag_TagID", "dbo.Tags");
            DropForeignKey("dbo.TagBlogs", "Blog_BlogId", "dbo.Blogs");
            DropIndex("dbo.TagBlogs", new[] { "Tag_TagID" });
            DropIndex("dbo.TagBlogs", new[] { "Blog_BlogId" });
            AddColumn("dbo.Tags", "BlogId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tags", "BlogId");
            AddForeignKey("dbo.Tags", "BlogId", "dbo.Blogs", "BlogId", cascadeDelete: true);
            DropColumn("dbo.Tags", "CategoryID");
            DropTable("dbo.TagBlogs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TagBlogs",
                c => new
                    {
                        Tag_TagID = c.Int(nullable: false),
                        Blog_BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_TagID, t.Blog_BlogId });
            
            AddColumn("dbo.Tags", "CategoryID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Tags", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Tags", new[] { "BlogId" });
            DropColumn("dbo.Tags", "BlogId");
            CreateIndex("dbo.TagBlogs", "Blog_BlogId");
            CreateIndex("dbo.TagBlogs", "Tag_TagID");
            AddForeignKey("dbo.TagBlogs", "Blog_BlogId", "dbo.Blogs", "BlogId", cascadeDelete: true);
            AddForeignKey("dbo.TagBlogs", "Tag_TagID", "dbo.Tags", "TagID", cascadeDelete: true);
        }
    }
}
