namespace Avika.Forum.WebApiAuthorization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class quitaColeccionUsuariosConexion : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserConexions", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserConexions", "Conexion_Id", "dbo.Conexions");
            DropIndex("dbo.UserConexions", new[] { "User_Id" });
            DropIndex("dbo.UserConexions", new[] { "Conexion_Id" });
            AddColumn("dbo.Conexions", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Conexions", "User_Id");
            AddForeignKey("dbo.Conexions", "User_Id", "dbo.AspNetUsers", "Id");
            DropTable("dbo.UserConexions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserConexions",
                c => new
                    {
                        User_Id = c.String(nullable: false, maxLength: 128),
                        Conexion_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Conexion_Id });
            
            DropForeignKey("dbo.Conexions", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Conexions", new[] { "User_Id" });
            DropColumn("dbo.Conexions", "User_Id");
            CreateIndex("dbo.UserConexions", "Conexion_Id");
            CreateIndex("dbo.UserConexions", "User_Id");
            AddForeignKey("dbo.UserConexions", "Conexion_Id", "dbo.Conexions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserConexions", "User_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
