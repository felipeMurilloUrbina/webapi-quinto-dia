namespace Avika.Forum.WebApiAuthorization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ultimosCambios : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "GranjaId", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Nombre", c => c.String());
            AddColumn("dbo.AspNetUsers", "Apellido", c => c.String());
            AddColumn("dbo.AspNetUsers", "Activo", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "Name");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "CompanyId");
            DropColumn("dbo.AspNetUsers", "DepartmentId");
            DropColumn("dbo.AspNetUsers", "BirthDate");
            DropColumn("dbo.AspNetUsers", "IncorporationDate");
            DropColumn("dbo.AspNetUsers", "Rfc");
            DropColumn("dbo.AspNetUsers", "Language");
            DropColumn("dbo.AspNetUsers", "Active");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "Language", c => c.String());
            AddColumn("dbo.AspNetUsers", "Rfc", c => c.String());
            AddColumn("dbo.AspNetUsers", "IncorporationDate", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "DepartmentId", c => c.Int());
            AddColumn("dbo.AspNetUsers", "CompanyId", c => c.Int());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            DropColumn("dbo.AspNetUsers", "Activo");
            DropColumn("dbo.AspNetUsers", "Apellido");
            DropColumn("dbo.AspNetUsers", "Nombre");
            DropColumn("dbo.AspNetUsers", "GranjaId");
        }
    }
}
