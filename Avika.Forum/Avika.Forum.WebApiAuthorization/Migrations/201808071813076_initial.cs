namespace Avika.Forum.WebApiAuthorization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUsers", new[] { "RoleId" });
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "IncorporationDate", c => c.DateTime());
            DropColumn("dbo.AspNetUsers", "RoleId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "RoleId", c => c.String(maxLength: 128));
            DropColumn("dbo.AspNetUsers", "IncorporationDate");
            DropColumn("dbo.AspNetUsers", "BirthDate");
            CreateIndex("dbo.AspNetUsers", "RoleId");
            AddForeignKey("dbo.AspNetUsers", "RoleId", "dbo.AspNetRoles", "Id");
        }
    }
}
