namespace Bullers.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db_cr : DbMigration
    {
        public override void Up()
        {
          //  DropForeignKey("dbo.CommonProducts", "UserID", "dbo.Users");
          //  DropIndex("dbo.CommonProducts", new[] { "UserID" });
            AddColumn("dbo.CommonProducts", "OwnerID", c => c.Int());
          //  DropColumn("dbo.CommonProducts", "UserID");
        }
        
        public override void Down()
        {
           // AddColumn("dbo.CommonProducts", "UserID", c => c.Int(nullable: false));
          //  DropColumn("dbo.CommonProducts", "OwnerID");
           // CreateIndex("dbo.CommonProducts", "UserID");
           // AddForeignKey("dbo.CommonProducts", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
        }
    }
}
