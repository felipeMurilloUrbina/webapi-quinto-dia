namespace Avika.Forum.WebApiAuthorization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregaConexionModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conexions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserConexions",
                c => new
                    {
                        User_Id = c.String(nullable: false, maxLength: 128),
                        Conexion_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Conexion_Id })
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Conexions", t => t.Conexion_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Conexion_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserConexions", "Conexion_Id", "dbo.Conexions");
            DropForeignKey("dbo.UserConexions", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.UserConexions", new[] { "Conexion_Id" });
            DropIndex("dbo.UserConexions", new[] { "User_Id" });
            DropTable("dbo.UserConexions");
            DropTable("dbo.Conexions");
        }
    }
}
