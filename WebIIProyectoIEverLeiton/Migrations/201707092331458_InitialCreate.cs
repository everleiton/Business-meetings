namespace WebIIProyectoIEverLeiton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        CedulaJuridica = c.Int(nullable: false),
                        Nombre = c.String(),
                        Pagina = c.String(),
                        Direccion = c.String(),
                        Telefono = c.Int(nullable: false),
                        Sector = c.String(),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.Reuniones",
                c => new
                    {
                        IdReunion = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Dia = c.String(),
                        Hora = c.String(),
                        Virtual = c.Boolean(nullable: false),
                        client_IdCliente = c.Int(),
                        UsuarioEncargado_IdUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.IdReunion)
                .ForeignKey("dbo.Clientes", t => t.client_IdCliente)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioEncargado_IdUsuario)
                .Index(t => t.client_IdCliente)
                .Index(t => t.UsuarioEncargado_IdUsuario);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellidos = c.String(),
                        Correo = c.String(),
                        Telefono = c.Int(nullable: false),
                        Puesto = c.String(),
                        Rol = c.String(),
                        FkIdCliente_IdCliente = c.Int(),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .ForeignKey("dbo.Clientes", t => t.FkIdCliente_IdCliente)
                .Index(t => t.FkIdCliente_IdCliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reuniones", "UsuarioEncargado_IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "FkIdCliente_IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.Reuniones", "client_IdCliente", "dbo.Clientes");
            DropIndex("dbo.Usuarios", new[] { "FkIdCliente_IdCliente" });
            DropIndex("dbo.Reuniones", new[] { "UsuarioEncargado_IdUsuario" });
            DropIndex("dbo.Reuniones", new[] { "client_IdCliente" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Reuniones");
            DropTable("dbo.Clientes");
        }
    }
}
