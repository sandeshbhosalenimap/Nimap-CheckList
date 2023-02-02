namespace FluentApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbl_Course",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 200),
                        Level = c.Int(nullable: false),
                        FullPrice = c.Single(nullable: false),
                        Author_Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 200),
                        AuthorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorID)
                .Index(t => t.AuthorID);
            
            CreateTable(
                "dbo.Covers",
                c => new
                    {
                        id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.tbl_Course", t => t.id)
                .Index(t => t.id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CourseTags",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        TagID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.TagID })
                .ForeignKey("dbo.tbl_Course", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.TagID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.CourseTags", "CourseId", "dbo.tbl_Course");
            DropForeignKey("dbo.Covers", "id", "dbo.tbl_Course");
            DropForeignKey("dbo.tbl_Course", "AuthorID", "dbo.Authors");
            DropIndex("dbo.CourseTags", new[] { "TagID" });
            DropIndex("dbo.CourseTags", new[] { "CourseId" });
            DropIndex("dbo.Covers", new[] { "id" });
            DropIndex("dbo.tbl_Course", new[] { "AuthorID" });
            DropTable("dbo.CourseTags");
            DropTable("dbo.Tags");
            DropTable("dbo.Covers");
            DropTable("dbo.tbl_Course");
            DropTable("dbo.Authors");
        }
    }
}
