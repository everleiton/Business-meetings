using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebIIProyectoIEverLeiton.Models
{
    public class DBContext : System.Data.Entity.DbContext
    {

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Reunion> Reunion { get; set; }
    }
}