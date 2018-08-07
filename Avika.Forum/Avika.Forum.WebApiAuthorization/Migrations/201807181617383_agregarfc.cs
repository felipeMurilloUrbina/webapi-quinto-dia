namespace Avika.Forum.WebApiAuthorization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarfc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Rfc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Rfc");
        }
    }
}
