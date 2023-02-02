namespace LazyLoadingFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CollageCources",
                c => new
                    {
                        CourceId = c.Int(nullable: false, identity: true),
                        CourceName = c.String(),
                        CollageStudent_StudentId = c.Int(),
                    })
                .PrimaryKey(t => t.CourceId)
                .ForeignKey("dbo.CollageStudents", t => t.CollageStudent_StudentId)
                .Index(t => t.CollageStudent_StudentId);
            
            CreateTable(
                "dbo.CollageStudents",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        StudentDescription = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CollageCources", "CollageStudent_StudentId", "dbo.CollageStudents");
            DropIndex("dbo.CollageCources", new[] { "CollageStudent_StudentId" });
            DropTable("dbo.CollageStudents");
            DropTable("dbo.CollageCources");
        }
    }
}
