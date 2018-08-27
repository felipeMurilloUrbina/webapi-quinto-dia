namespace Avika.Forum.WebApiAuthorization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregaCampoConexion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Conexions", "ConexionString", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Conexions", "ConexionString");
        }
    }
}
