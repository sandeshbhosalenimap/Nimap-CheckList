namespace CRUD_Operation_Sigle_Table.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLogIniNCotext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserLogIns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserLogIns");
        }
    }
}
