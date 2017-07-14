namespace WebIIProyectoIEverLeiton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableUpdates : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Reuniones", name: "client_IdCliente", newName: "FkIdCliente_IdCliente");
            RenameIndex(table: "dbo.Reuniones", name: "IX_client_IdCliente", newName: "IX_FkIdCliente_IdCliente");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Reuniones", name: "IX_FkIdCliente_IdCliente", newName: "IX_client_IdCliente");
            RenameColumn(table: "dbo.Reuniones", name: "FkIdCliente_IdCliente", newName: "client_IdCliente");
        }
    }
}
