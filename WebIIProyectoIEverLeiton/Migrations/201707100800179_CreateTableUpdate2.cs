namespace WebIIProyectoIEverLeiton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableUpdate2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuarios", "FkIdCliente_IdCliente", "dbo.Clientes");
            DropIndex("dbo.Usuarios", new[] { "FkIdCliente_IdCliente" });
            AddColumn("dbo.Usuarios", "Cliente_al_que_pertenece", c => c.String());
            AddColumn("dbo.Usuarios", "Contrasena", c => c.String());
            DropColumn("dbo.Usuarios", "FkIdCliente_IdCliente");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "FkIdCliente_IdCliente", c => c.Int());
            DropColumn("dbo.Usuarios", "Contrasena");
            DropColumn("dbo.Usuarios", "Cliente_al_que_pertenece");
            CreateIndex("dbo.Usuarios", "FkIdCliente_IdCliente");
            AddForeignKey("dbo.Usuarios", "FkIdCliente_IdCliente", "dbo.Clientes", "IdCliente");
        }
    }
}
