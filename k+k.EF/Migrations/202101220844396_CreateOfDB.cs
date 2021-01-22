namespace k_k.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOfDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.kukNotices",
                c => new
                    {
                        NoticeID = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Date = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NoticeID)
                .ForeignKey("dbo.kukUsers", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.kukUsers",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.kukNotices", "UserID", "dbo.kukUsers");
            DropIndex("dbo.kukNotices", new[] { "UserID" });
            DropTable("dbo.kukUsers");
            DropTable("dbo.kukNotices");
        }
    }
}
