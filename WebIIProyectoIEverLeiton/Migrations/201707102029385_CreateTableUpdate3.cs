namespace WebIIProyectoIEverLeiton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableUpdate3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Rol", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Rol", c => c.String());
        }
    }
}
